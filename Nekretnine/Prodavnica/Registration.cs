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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();
            ITransaction t = s.Transaction;
            try
            {
                t.Begin();
                klijenti k = new klijenti();
                k.Ime = tbIme.Text;
                k.Prezime = tbPrezime.Text;
                k.Email = tbEmail.Text;
                k.Password = tbPassword.Text;
                k.Grad = tbGrad.Text;
                k.Ulica = tbUlica.Text;
                k.Broj = Int32.Parse(tbBroj.Text);
                if (cbKupacFleg.Checked == true)
                    k.Kupac_fleg = 1;
                else
                    k.Kupac_fleg = 0;

                if (cbProdavacFleg.Checked == true)
                    k.Prodavac_fleg = 1;
                else
                    k.Prodavac_fleg = 0;

                s.Save(k);
                s.Flush();

                t.Commit();
                s.Close();

                this.Close();
                MessageBox.Show("Registrovani ste. Sada se loginujte.");
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
                t.Rollback();
            }
        }
    }
}
