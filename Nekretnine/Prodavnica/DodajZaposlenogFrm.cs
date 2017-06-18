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
    public partial class DodajZaposlenogFrm : Form
    {
        public DodajZaposlenogFrm()
        {
            InitializeComponent();
        }


        #region Zaposleni CRUD
        //radi sve
        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {

            zaposleni z;

            try
            {
                ISession s = DataLayer.GetSession();

                if (tbTipZaposlenog.Text == "agent")
                {
                    agent ag = new agent();


                    ag.Ime = tbImeZaposlenog.Text;
                    ag.Prezime = tbPrezimeZaposlenog.Text;
                    ag.Email_Zaposlenog = tbEmailZaposlenog.Text;
                    ag.Password_Zaposlenog = tbPasswordZaposlenog.Text;
                    ag.Staz = Int32.Parse(tbStazZaposlenog.Text);
                    ag.Tip = tbTipZaposlenog.Text;

                    z = ag;
                }
                else
                {
                    admin ad = new admin();
                    ad.Email_Zaposlenog = tbEmailZaposlenog.Text;
                    ad.Password_Zaposlenog = tbPasswordZaposlenog.Text;
                    ad.Tip = tbTipZaposlenog.Text;

                    z = ad;
                }

                s.SaveOrUpdate(z);

                s.Flush();
                s.Close();
                MessageBox.Show("USPEH.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajZaposlenog_Click(object sender, EventArgs e)
        {

            zaposleni z;

            try
            {
                ISession s = DataLayer.GetSession();
                string email = tbEmailZaposlenog.Text;
                IList<zaposleni> zaposleni1 = s.QueryOver<zaposleni>().Where(x => x.Email_Zaposlenog == email).List();

                if (zaposleni1.Count > 0)
                {

                    z = zaposleni1[0];

                    if (z.GetType() == typeof(agent)) //ovako da ispitam tip da bi upisao tip
                    {
                        agent ag = z as agent;

                        tbImeZaposlenog.Text = ag.Ime;
                        tbPrezimeZaposlenog.Text = ag.Prezime;
                        tbEmailZaposlenog.Text = ag.Email_Zaposlenog;
                        tbPasswordZaposlenog.Text = ag.Password_Zaposlenog;
                        tbStazZaposlenog.Text = ag.Staz.ToString();
                        tbTipZaposlenog.Text = "agent";

                    }
                    else
                    {
                        admin ad = z as admin;
                        tbEmailZaposlenog.Text = ad.Email_Zaposlenog;
                        tbPasswordZaposlenog.Text = ad.Password_Zaposlenog;
                        tbStazZaposlenog.Text = String.Empty;
                        tbImeZaposlenog.Text = String.Empty;
                        tbPrezimeZaposlenog.Text = String.Empty;
                        tbTipZaposlenog.Text = "admin";
                    }

                    s.Close();
                    MessageBox.Show("USPEH.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAzurirajZaposlenog_Click(object sender, EventArgs e)
        {
            zaposleni z;

            try
            {
                ISession s = DataLayer.GetSession();
                string email = tbEmailZaposlenog.Text;
                IList<zaposleni> zaposleni1 = s.QueryOver<zaposleni>().Where(x => x.Email_Zaposlenog == email).List();

                if (zaposleni1.Count > 0)
                {

                    z = zaposleni1[0];

                    if (z.GetType() == typeof(agent)) //ovako da ispitam tip da bi upisao tip
                    {

                        agent ag = z as agent;


                        ag.Ime = tbImeZaposlenog.Text;
                        ag.Prezime = tbPrezimeZaposlenog.Text;
                        ag.Email_Zaposlenog = tbEmailZaposlenog.Text;
                        ag.Password_Zaposlenog = tbPasswordZaposlenog.Text;
                        ag.Staz = Int32.Parse(tbStazZaposlenog.Text);
                        ag.Tip = "agent";

                        z = ag;
                    }
                    else
                    {
                        admin ad = z as admin;
                        ad.Email_Zaposlenog = tbEmailZaposlenog.Text;
                        ad.Password_Zaposlenog = tbPasswordZaposlenog.Text;
                        ad.Tip = tbTipZaposlenog.Text;
                        ad.Tip = "admin";

                        z = ad;
                    }

                    //s.SaveOrUpdate(z); // ovo nece ne znam sto
                    s.Update(z);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("USPEH.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzbrisiZaposlenog_Click(object sender, EventArgs e)
        {
            zaposleni z;

            try
            {
                ISession s = DataLayer.GetSession();
                string email = tbEmailZaposlenog.Text;
                IList<zaposleni> zaposleni1 = s.QueryOver<zaposleni>().Where(x => x.Email_Zaposlenog == email).List();

                if (zaposleni1.Count > 0)
                {

                    z = zaposleni1[0];

                    s.Delete(z);
                    s.Flush();
                }

                s.Close();
                MessageBox.Show("USPEH.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
