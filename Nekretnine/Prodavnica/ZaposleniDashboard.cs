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
    public partial class ZaposleniDashboard : Form
    {
        nekretnina nek = null;
        Form f;
        public ZaposleniDashboard()
        {
            InitializeComponent();
        }

        public ZaposleniDashboard(zaposleni z, Form forma)
        {
            InitializeComponent();
            f = forma;

            try
            {

                ISession s = DataLayer.GetSession();
                IList<nekretnina> nekretnine = s.QueryOver<nekretnina>().Where(x => x.U_Ponudi_Fleg == 1 && x.Agent.Id_Zaposlenog == z.Id_Zaposlenog).List();
                IList<notar> notari = s.QueryOver<notar>().List();
                cbNekretnina.DataSource = nekretnine;
                cbNotar.DataSource = notari;
                cbPravniZastupnikKupca.Enabled = false;
                cbKupacZakupac.Enabled = false;

                btnDodajUgovor.Enabled = false;

                IList<ugovor> ugovori = s.QueryOver<ugovor>().Where(x => x.Agent.Id_Zaposlenog == z.Id_Zaposlenog).List();
                lbUgovori.DataSource = ugovori;


                s.Close();
               
            }
            catch (Exception ex)
            {

            }
        }

        private void cbNekretnina_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKupacZakupac.Enabled = true;
            nek = (nekretnina)cbNekretnina.SelectedItem;
            try
            {

                ISession s = DataLayer.GetSession();
                s.Lock(nek, LockMode.None);
                IList<klijenti> kupci = s.QueryOver<klijenti>().Where(x => x.Id != nek.Vlasnik.Id && x.Kupac_fleg == 1).List();
                cbKupacZakupac.DataSource = kupci;
                cbPravniZastupnikProdavca.DataSource = nek.Vlasnik.pravniZastupnici;
                s.Close();
            }

            catch(Exception ex)
            {

            }
        }

        private void cbKupacZakupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPravniZastupnikKupca.Enabled = true;
            try
            {
                klijenti k = (klijenti)cbKupacZakupac.SelectedItem;
                ISession s = DataLayer.GetSession();
                cbPravniZastupnikKupca.DataSource = k.pravniZastupnici;
                btnDodajUgovor.Enabled = true;
                s.Close();
            }

            catch (Exception ex)
            {

            }
        }

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            ugovor u = null;

            try
            {
                ISession s = DataLayer.GetSession();
                if (rbKuporpodajni.Checked)
                {
                    u = new kupoprodajni_ugovor()
                    {
                        Datum_Potpisivanja = dtpDatumPotpisivanja.Value,
                        BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text),
                        Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text),
                        Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text),
                        MesecnaRenta = 0,
                        Tip_Ugovora = rbKuporpodajni.Text,
                        Osnovna_cena = (float)Double.Parse(tbOsnovnaCena.Text),

                    };
                }
                else if (rbZakupu.Checked)
                {
                    u = new ugovor_o_izdavanju()
                    {
                        Datum_Potpisivanja = dtpDatumPotpisivanja.Value,
                        BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text),
                        Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text),
                        Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text),
                        MesecnaRenta = (float)Double.Parse(tbMesecnaRenta.Text),
                        Tip_Ugovora = rbZakupu.Text,
                        Od = DateTime.Now,
                        Do = DateTime.Now
                    };
                }
                u.Kupac_ili_zakupac = (klijenti)cbKupacZakupac.SelectedItem;
                u.Prodavac = nek.Vlasnik;
                u.Nekretnina = nek;
                nek.U_Ponudi_Fleg = 0;
                u.Notar = (notar)cbNotar.SelectedItem;
                u.Agent = u.Nekretnina.Agent;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno ste dodali ugovor.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail.");
                MessageBox.Show(ex.Message);
            }
        }

        private void ZaposleniDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Close();
        }
    }
}
