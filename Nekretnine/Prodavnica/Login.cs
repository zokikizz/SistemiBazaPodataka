using NHibernate;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.Transaction;
                IList<klijenti> logIn = s.QueryOver<klijenti>().Where(x => x.Email == tbEmail.Text && x.Password == tbPassword.Text).List();



                if (logIn.Count != 0)
                {
                    //NHibernateUtil.Initialize(logIn[0].pravniZastupnici);
                    // MessageBox.Show("You are logged in.");


                    Dashboard d = new Dashboard(logIn[0], this);
                    d.Show();
                    s.Close();

                    this.Visible = false;

                }
                else
                {
                    IList<admin> adm = s.QueryOver<admin>().Where(x => x.Email_Zaposlenog == tbEmail.Text && x.Password_Zaposlenog == tbPassword.Text).List();
                    if (adm.Count != 0)
                    {
                        AdminDashboard a = new AdminDashboard(this);
                        a.Show();
                        this.Visible = false;
                    }
                    else {
                        IList<zaposleni> zap = s.QueryOver<zaposleni>().Where(x => x.Email_Zaposlenog == tbEmail.Text && x.Password_Zaposlenog == tbPassword.Text).List();

                        if (zap.Count != 0)
                        {
                            ZaposleniDashboard zd = new ZaposleniDashboard(zap[0], this);
                            zd.Show();
                            s.Close();

                            this.Visible = false;
                        }
                        else
                            MessageBox.Show("Ne postoji profil u bazi.");



                    }

                  

                }

               
                    //MessageBox.Show("Bad email or password.");

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void lbSingUp_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();

            r.ShowDialog();

        }
    }
}
