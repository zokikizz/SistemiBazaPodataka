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
    public partial class AdminDashboard : Form
    {
        private Login login;

        public AdminDashboard()
        {
            InitializeComponent();

            try
            {
                ISession s = DataLayer.GetSession();
                IList<zaposleni> z = s.QueryOver<zaposleni>().Where(x => x.Tip != "admin").List();
                lbListaZaposlenih.DataSource = z;


            }
            catch(Exception ex)
            {
                MessageBox.Show("lose");
            }
        }

        public AdminDashboard(Login login)
        {

            InitializeComponent();
            this.login = login;

            try
            {
                ISession s = DataLayer.GetSession();
                IList<agent> ag = s.QueryOver<agent>().List();
                lbListaZaposlenih.DataSource = ag;


            }
            catch (Exception ex)
            {
                MessageBox.Show("lose");
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposlenogFrm d = new DodajZaposlenogFrm();
            d.ShowDialog();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }
    }
}
