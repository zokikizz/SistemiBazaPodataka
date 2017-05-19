using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemiBazaPodataka.Entiteti;

namespace Prodavnica
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // radi, ovaj zaposleni vec postoji
        {
            try
            {
                ISession s = DataLayer.GetSession();

                agent a = new agent() { Ime = "zoki", Email_Zaposlenog = "kizz@gmail.com", Password_Zaposlenog = "zoki", Prezime = "p", Staz = 4 };
                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska.");
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                klijenti k = new klijenti() { Ime = "Zoran", Prezime = "Pecic", Email = "zokikizz@elfak.rs", Password = "zokikizz", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 1, Prodavac_fleg = 1 };
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska.");
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                klijenti k = new klijenti() { Ime = "Zorannn", Prezime = "Pecic", Email = "caocao", Password = "caoooo", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 0, Prodavac_fleg = 1 };
                kraci_period nek = new kraci_period() { Broj = 11, Br_Parcele = 10, Cena = 20000, Datum_Izgradnje = DateTime.Now, Grad = "Krusevac", Id_Ugovora_O_Zastupanju = 101, Kvadratura = 65, Lokacija = "Pejton", Opis = "Lepa kuca", Opstina = "Krusevac", Sprat_Broj = "5", Tip = "Kuca", Ulica = "Vojvodjanska", U_Ponudi_Fleg = 1, Br_Meseci = 0, Do = DateTime.Now, Od = DateTime.Now, Godina = 10 };
                agent agent = s.Load<agent>(21);
                k.LicneNekretnine.Add(nek);
                nek.Agent = agent;
                nek.Vlasnik = k;
                fotografija f = new fotografija() { Path = "url" };
                nek.Fotografije.Add(f);
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska.");
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();



                klijenti k = new klijenti() { Ime = "Zorannn", Prezime = "Pecic", Email = "caoooo@email.com", Password = "zokikizz", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 1, Prodavac_fleg = 0 };
                //klijenti k1 = new klijenti() { Ime = "Zorannn", Prezime = "Pecic", Email = "???????????????", Password = "zokikizz", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 0, Prodavac_fleg = 1 };

                ugovor_o_izdavanju ug = new ugovor_o_izdavanju() { BonusAgentu = 9f, MesecnaRenta = 2f, Od = DateTime.Now, Do = DateTime.Now, Datum_Potpisivanja = DateTime.Now, Naknada_notaru = 1f, Naknada_Za_Agenciju = 2f };
                //kupoprodajni_ugovor ug = new kupoprodajni_ugovor() { BonusAgentu = 9f, Datum_Potpisivanja = DateTime.Now, Naknada_notaru = 1f, Kupoprodajni_fleg = 1, Naknada_Za_Agenciju = 2f, Osnovna_cena = 1f, MesecnaRenta = 0 };
                notar notar = s.Load<notar>(21);
                klijenti prodavac = s.Load<klijenti>(33);
                k.UgovorOKupovini.Add(ug);
                ug.Kupac_ili_zakupac = k;

                ug.Notar = notar;
                ug.Prodavac = prodavac;
                nekretnina nek = prodavac.LicneNekretnine.FirstOrDefault();

                ug.Nekretnina = nek;
                ug.Agent = nek.Agent;
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Greska.");
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                notar not = new notar() { Ime = "Jovan", Prezime = "Pesic" };

                s.SaveOrUpdate(not);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh.");

            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska.");
                MessageBox.Show(ec.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) // pitaj bogdanovica !!!
        {
            try
            {
                ISession s = DataLayer.GetSession();

                klijenti prodavac = s.Load<klijenti>(33);
                MessageBox.Show(prodavac.LicneNekretnine[0].Id_Ugovora_O_Zastupanju.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska.");
                MessageBox.Show(ec.Message);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                klijenti k = new klijenti() { Ime = "Klijent", Prezime = "Klijentic", Email = "klijentklijentic@elfak.rs", Password = "zokikizz", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 1, Prodavac_fleg = 1 };
                agent a = new agent() { Ime = "Zaposleni", Email_Zaposlenog = "zaposlenizaposlenic@gmail.com", Password_Zaposlenog = "kobicar", Prezime = "Urosevic", Staz = 4 };
                klijentTelefon ktele = new klijentTelefon() { Br_Tel = 1234567, Vazeci_Fleg = 1 };
                zaposleniTelefon ztele = new zaposleniTelefon() { Br_Tel = 7654321, Vazeci_Fleg = 1 };
                k.brojeviTelefona.Add(ktele);
                a.BrojeviTelefona.Add(ztele);
                ktele.Pripada = k;
                ztele.Pripada = a;
                s.SaveOrUpdate(k);
                s.SaveOrUpdate(a);
                s.Close();
                MessageBox.Show("Uspesno.");
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska.");
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                klijenti prodavac = new klijenti() { Ime = "Prodavac", Prezime = "Prodavcevic", Email = "prodavac@elfak.rs", Password = "zokikizz", Grad = "Krusevac", Broj = 24, Ulica = "Lomnicke borbe", Kupac_fleg = 1, Prodavac_fleg = 1 };
                pravniZastupnik p = new pravniZastupnik() { Ime = "Zastupnik", Prezime = "Zastupnikovic", MatBr = 12345678, NazivAgencije = "World Line", Grad = "Krusevac", Ulica = "Vojvodjanska", Broj = 10 };
                prodavac.pravniZastupnici[prodavac.pravniZastupnici.Count] = new zastupa();
                prodavac.pravniZastupnici[prodavac.pravniZastupnici.Count].ZastupaZastupnik = p;
                //p.KlijetiKojeZastupa.Add(prodavac);
                s.SaveOrUpdate(prodavac);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska");
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            nekretnina nek = null;
            try
            {
                ISession s = DataLayer.GetSession();
                nek = s.QueryOver<nekretnina>().
                    Where(x => x.Vlasnik == ((s.QueryOver<klijenti>().Where(klij => klij.Email == "zokikizz")).List()[0]))
                    .List()[0];
                fotografija f = new fotografija() { Path = "url" };

                nek.Fotografije.Add(f);
                f.Pripada = nek;

                s.SaveOrUpdate(nek);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspeh");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        #region klijenti CRUD
        //radi sve
        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            klijenti k = new klijenti();

            try
            {
                ISession s = DataLayer.GetSession();



                k.Ime = tbImeKlijenta.Text;
                k.Prezime = tbPrezime.Text;
                k.Email = tbEmail.Text;
                k.Password = tbPassword.Text;
                k.Grad = tbGrad.Text;
                k.Ulica = tbUlica.Text;
                k.Kupac_fleg = Int32.Parse(tbKupacFleg.Text);
                k.Prodavac_fleg = Int32.Parse(tbProdavacFleg.Text);
                k.Broj = Int32.Parse(tbBrojUUlici.Text);

                s.SaveOrUpdate(k);

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

        private void btnUcitajKlijenta_Click(object sender, EventArgs e)
        {
            klijenti k = new klijenti();

            try
            {
                ISession s = DataLayer.GetSession();

                string email = tbEmail.Text;
                IList<klijenti> klijenti1 = s.QueryOver<klijenti>().Where(x => x.Email == email).List();
                k = klijenti1[0];


                tbImeKlijenta.Text = k.Ime;
                tbPrezime.Text = k.Prezime;
                tbEmail.Text = k.Email;
                tbPassword.Text = k.Password;
                tbGrad.Text = k.Grad;
                tbUlica.Text = k.Ulica;
                tbKupacFleg.Text = k.Kupac_fleg.ToString();
                tbProdavacFleg.Text = k.Prodavac_fleg.ToString();
                tbBrojUUlici.Text = k.Broj.ToString();


                s.Close();
                MessageBox.Show("USPEH.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIzbrisiKlijentaPoEmal_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                string email = tbEmail.Text;

                IList<klijenti> klijenti1 = s.QueryOver<klijenti>().Where(x => x.Email == email).List();
                s.Delete(klijenti1[0]);
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

        private void btnAzurirajKlijentaPoEmail_Click(object sender, EventArgs e)
        {
            klijenti k = new klijenti();

            try
            {
                ISession s = DataLayer.GetSession();
                string email = tbEmail.Text;
                k = s.QueryOver<klijenti>().Where(x => x.Email == email).List()[0];


                k.Ime = tbImeKlijenta.Text;
                k.Prezime = tbPrezime.Text;
                k.Email = tbEmail.Text;
                k.Password = tbPassword.Text;
                k.Grad = tbGrad.Text;
                k.Ulica = tbUlica.Text;
                k.Kupac_fleg = Int32.Parse(tbKupacFleg.Text);
                k.Prodavac_fleg = Int32.Parse(tbProdavacFleg.Text);
                k.Broj = Int32.Parse(tbBrojUUlici.Text);

                s.Update(k);

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



        #endregion

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
                        tbPrezime.Text = String.Empty;
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

        #region nekretnine CRUD

        private void btnDodajNekretninu_Click(object sender, EventArgs e)
        {
            nekretnina n = null;

            try
            {
                ISession s = DataLayer.GetSession();

                if (tbTipIzdavanja.Text == "kraci")
                { //radi
                    kraci_period k = new kraci_period();

                    k.Tip_Ponude = tbTipPonude.Text;
                    k.Tip_Izdavanja = tbTipIzdavanja.Text;
                    k.Sprat_Broj = tbSprat_Broj.Text;
                    k.Opstina = tbOpstina.Text;
                    k.Opis = tbOpis.Text;
                    k.Lokacija = tbLokacija.Text;
                    k.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    k.Od = DateTime.Now;
                    k.Do = DateTime.Now;
                    k.Godina = 2017;
                    k.Ulica = tbUliceNektetnine.Text;
                    k.Grad = tbGradNekretnine.Text;
                    k.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                    k.Br_Meseci = Int32.Parse(tbBrojMeseci.Text);
                    k.Broj = Int32.Parse(tbBrojUUliciNekretnine.Text);
                    k.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    k.Cena = Int32.Parse(tbCena.Text);
                    k.Datum_Izgradnje = DateTime.Now;
                    k.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);
                    k.Tip = "pitaj boga";
                    k.Vlasnik = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List()[0];
                    k.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];

                    n = k;

                }
                else if (tbTipIzdavanja.Text == "duzi")
                {
                    duzi_period d = new duzi_period();


                    d.Tip_Ponude = tbTipPonude.Text;
                    d.Sprat_Broj = tbSprat_Broj.Text;
                    d.Tip_Izdavanja = tbTipIzdavanja.Text;
                    d.Tip = "atribut";
                    d.Ulica = tbUliceNektetnine.Text;
                    d.Grad = tbGradNekretnine.Text;
                    d.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                    d.Opstina = tbOpstina.Text;
                    d.Opis = tbOpis.Text;
                    d.Lokacija = tbLokacija.Text;
                    d.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    d.Broj = Int32.Parse(tbBrojUUliciNekretnine.Text);
                    d.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    d.Cena = Int32.Parse(tbCena.Text);
                    d.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);

                    d.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];
                    d.Vlasnik = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List()[0];
                    d.Fizicka_Pavna_Lica_Fleg = 1;
                    d.Datum_Izgradnje = DateTime.Now;
                    d.Br_Meseci = Int32.Parse(tbBrojMeseci.Text);


                    n = d;

                }
                else
                {
                    n = new nekretnina();


                    n.Tip = "ne znam";
                    n.Sprat_Broj = tbSprat_Broj.Text;
                    n.Tip_Ponude = tbTipPonude.Text;
                    n.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    n.Opstina = tbOpstina.Text;
                    n.Lokacija = tbLokacija.Text;
                    n.Opis = tbOpis.Text;
                    n.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    n.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);
                    n.Grad = tbGradNekretnine.Text;
                    n.Broj = Int32.Parse(tbBrojUUliciNekretnine.Text);
                    n.Cena = Int32.Parse(tbCena.Text);
                    n.Datum_Izgradnje = DateTime.Now;
                    //n.Tip_Izdavanja = "kraci";
                    n.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                    n.Ulica = tbUliceNektetnine.Text;

                    IList<klijenti> k = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List();
                    n.Vlasnik = k[0];
                    n.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];

                }

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();

                MessageBox.Show("USPEH");

            }
            catch (Exception ex)
            {

                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }




        private void btnUcitajNekretnine_Click(object sender, EventArgs e)
        {
            nekretnina nekretninaa = null;

            try
            {
                string email = tbEmail.Text;
                ISession s = DataLayer.GetSession();
                IList<nekretnina> lista = s.QueryOver<nekretnina>().
                    Where(nek => nek.Vlasnik ==
                   ((s.QueryOver<klijenti>().Where(klij => klij.Email == email)).List()[0]))
                    .List();


                foreach (nekretnina n in lista)
                {
                    if (n.GetType() == typeof(kraci_period))
                    { //radi
                        kraci_period k = n as kraci_period;

                        tbTipPonude.Text = k.Tip_Ponude;
                        tbTipIzdavanja.Text = k.Tip_Izdavanja;
                        tbSprat_Broj.Text = k.Sprat_Broj;
                        tbOpstina.Text = k.Opstina;
                        tbOpis.Text = k.Opis;
                        tbLokacija.Text = k.Lokacija;
                        tbKvadratura.Text = k.Kvadratura.ToString();

                        tbUliceNektetnine.Text = k.Ulica;
                        tbGradNekretnine.Text = k.Grad;
                        tbBrojParcele.Text = k.Br_Parcele.ToString();
                        tbBrojMeseci.Text = k.Br_Meseci.ToString();
                        tbBrojUUliciNekretnine.Text = k.Broj.ToString();
                        tbUPonudiFleg.Text = k.U_Ponudi_Fleg.ToString();
                        tbCena.Text = k.Cena.ToString();
                        tbIdUgovoraOZastupanju.Text = k.Id_Ugovora_O_Zastupanju.ToString();



                    }
                    else if (n.GetType() == typeof(duzi_period))
                    {
                        duzi_period d = n as duzi_period;


                        tbTipPonude.Text = d.Tip_Ponude;
                        tbSprat_Broj.Text = d.Sprat_Broj;
                        tbTipIzdavanja.Text = d.Tip_Izdavanja;

                        tbUliceNektetnine.Text = d.Ulica;
                        tbGradNekretnine.Text = d.Grad;
                        tbBrojParcele.Text = d.Br_Parcele.ToString();
                        tbOpstina.Text = d.Opstina;
                        tbOpis.Text = d.Opis;
                        tbLokacija.Text = d.Lokacija;
                        tbKvadratura.Text = d.Kvadratura.ToString();
                        tbBrojUUlici.Text = d.Broj.ToString();
                        tbUPonudiFleg.Text = d.U_Ponudi_Fleg.ToString();
                        tbCena.Text = d.Cena.ToString();
                        tbIdUgovoraOZastupanju.Text = d.Id_Ugovora_O_Zastupanju.ToString();

                        tbBrojMeseci.Text = d.Br_Meseci.ToString();




                    }
                    else
                    {
                        nekretninaa = n;


                        n.Sprat_Broj = tbSprat_Broj.Text;
                        n.Tip_Ponude = tbTipPonude.Text;
                        tbUPonudiFleg.Text = n.U_Ponudi_Fleg.ToString();
                        tbOpstina.Text = n.Opstina;
                        tbLokacija.Text = n.Lokacija;
                        tbOpis.Text = n.Opis;
                        tbKvadratura.Text = n.Kvadratura.ToString();
                        tbIdUgovoraOZastupanju.Text = n.Id_Ugovora_O_Zastupanju.ToString();
                        tbGrad.Text = n.Grad;
                        tbBrojUUlici.Text = n.Broj.ToString();
                        tbCena.Text = n.Cena.ToString();
                        tbTipIzdavanja.Text = "NULL";
                        tbUlica.Text = n.Ulica;


                    }

                    MessageBox.Show("Vlasnik:" + n.Vlasnik.Ime + " " + n.Vlasnik.Email + "\n + " +
                        n.Agent.Ime + " " + n.Agent.Email_Zaposlenog);
                }

                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }



        private void btnAzurirajPrvuNekretninu_Click(object sender, EventArgs e)
        {
            nekretnina n = null;

            try
            {
                string email = tbEmail.Text;
                ISession s = DataLayer.GetSession();
                n = s.QueryOver<nekretnina>().Where(nek => nek.Vlasnik ==
                            (s.QueryOver<klijenti>().Where(k => k.Email == email).List()[0])).List()[0];


                if (n.GetType() == typeof(kraci_period))
                { //radi
                    kraci_period k = n as kraci_period;

                    k.Tip_Ponude = tbTipPonude.Text;
                    k.Tip_Izdavanja = tbTipIzdavanja.Text;
                    k.Sprat_Broj = tbSprat_Broj.Text;
                    k.Opstina = tbOpstina.Text;
                    k.Opis = tbOpis.Text;
                    k.Lokacija = tbLokacija.Text;
                    k.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    k.Od = DateTime.Now;
                    k.Do = DateTime.Now;
                    k.Godina = 2017;
                    k.Ulica = tbUliceNektetnine.Text;
                    k.Grad = tbGradNekretnine.Text;
                    k.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                    k.Br_Meseci = Int32.Parse(tbBrojMeseci.Text);
                    k.Broj = Int32.Parse(tbBrojUUliciNekretnine.Text);
                    k.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    k.Cena = Int32.Parse(tbCena.Text);
                    k.Datum_Izgradnje = DateTime.Now;
                    k.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);
                    k.Tip = "pitaj boga";
                    k.Vlasnik = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List()[0];
                    k.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];


                }
                else if (n.GetType() == typeof(duzi_period))
                {
                    duzi_period d = n as duzi_period;


                    d.Tip_Ponude = tbTipPonude.Text;
                    d.Sprat_Broj = tbSprat_Broj.Text;
                    d.Tip_Izdavanja = tbTipIzdavanja.Text;
                    d.Tip = "atribut";
                    d.Ulica = tbUliceNektetnine.Text;
                    d.Grad = tbGradNekretnine.Text;
                    d.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                    d.Opstina = tbOpstina.Text;
                    d.Opis = tbOpis.Text;
                    d.Lokacija = tbLokacija.Text;
                    d.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    d.Broj = Int32.Parse(tbBrojUUliciNekretnine.Text);
                    d.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    d.Cena = Int32.Parse(tbCena.Text);
                    d.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);

                    d.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];
                    d.Vlasnik = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List()[0];
                    d.Fizicka_Pavna_Lica_Fleg = 1;
                    d.Datum_Izgradnje = DateTime.Now;
                    d.Br_Meseci = Int32.Parse(tbBrojMeseci.Text);


                }
                else
                {

                    n.Tip = "ne znam";
                    n.Sprat_Broj = tbSprat_Broj.Text;
                    n.Tip_Ponude = tbTipPonude.Text;
                    n.U_Ponudi_Fleg = Int32.Parse(tbUPonudiFleg.Text);
                    n.Opstina = tbOpstina.Text;
                    n.Lokacija = tbLokacija.Text;
                    n.Opis = tbOpis.Text;
                    n.Kvadratura = Int32.Parse(tbKvadratura.Text);
                    n.Id_Ugovora_O_Zastupanju = Int32.Parse(tbIdUgovoraOZastupanju.Text);
                    n.Grad = tbGrad.Text;
                    n.Broj = Int32.Parse(tbBrojUUlici.Text);
                    n.Cena = Int32.Parse(tbCena.Text);
                    n.Datum_Izgradnje = DateTime.Now;
                    n.Tip_Izdavanja = null;
                    n.Ulica = tbUlica.Text;

                    IList<klijenti> k = s.QueryOver<klijenti>().Where(x => x.Email == "zokikizz").List();
                    n.Vlasnik = k[0];
                    n.Agent = s.QueryOver<agent>().Where(x => x.Email_Zaposlenog == "marepetrovic").List()[0];

                }

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();

                MessageBox.Show("USPEH");

            }
            catch (Exception ex)
            {

                MessageBox.Show("NEUSPEH.");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajPrvu_Click(object sender, EventArgs e)
        {
            UcitajJednuNekretninu();
        }

        public void UcitajJednuNekretninu()
        {
            nekretnina n = null;
            try
            {
                string email = tbEmail.Text;
                ISession s = DataLayer.GetSession();

                n = s.QueryOver<nekretnina>().
                    Where(nek => nek.Vlasnik ==
                   ((s.QueryOver<klijenti>().Where(klij => klij.Email == email)).List()[0]))
                    .List()[0];


                if (n.GetType() == typeof(kraci_period))
                {
                    kraci_period k = n as kraci_period;

                    tbTipPonude.Text = k.Tip_Ponude;
                    tbTipIzdavanja.Text = k.Tip_Izdavanja;
                    tbSprat_Broj.Text = k.Sprat_Broj;
                    tbOpstina.Text = k.Opstina;
                    tbOpis.Text = k.Opis;
                    tbLokacija.Text = k.Lokacija;
                    tbKvadratura.Text = k.Kvadratura.ToString();

                    tbUliceNektetnine.Text = k.Ulica;
                    tbGradNekretnine.Text = k.Grad;
                    tbBrojParcele.Text = k.Br_Parcele.ToString();
                    tbBrojMeseci.Text = k.Br_Meseci.ToString();
                    tbBrojUUliciNekretnine.Text = k.Broj.ToString();
                    tbUPonudiFleg.Text = k.U_Ponudi_Fleg.ToString();
                    tbCena.Text = k.Cena.ToString();
                    tbIdUgovoraOZastupanju.Text = k.Id_Ugovora_O_Zastupanju.ToString();




                }
                else if (n.GetType() == typeof(duzi_period))
                {
                    duzi_period d = n as duzi_period;


                    tbTipPonude.Text = d.Tip_Ponude;
                    tbSprat_Broj.Text = d.Sprat_Broj;
                    tbTipIzdavanja.Text = d.Tip_Izdavanja;

                    tbUliceNektetnine.Text = d.Ulica;
                    tbGradNekretnine.Text = d.Grad;
                    tbBrojParcele.Text = d.Br_Parcele.ToString();
                    tbOpstina.Text = d.Opstina;
                    tbOpis.Text = d.Opis;
                    tbLokacija.Text = d.Lokacija;
                    tbKvadratura.Text = d.Kvadratura.ToString();
                    tbBrojUUlici.Text = d.Broj.ToString();
                    tbUPonudiFleg.Text = d.U_Ponudi_Fleg.ToString();
                    tbCena.Text = d.Cena.ToString();
                    tbIdUgovoraOZastupanju.Text = d.Id_Ugovora_O_Zastupanju.ToString();

                    tbBrojMeseci.Text = d.Br_Meseci.ToString();


                }
                else
                {
                    nekretnina nekretninaa = new nekretnina();


                    n.Sprat_Broj = tbSprat_Broj.Text;
                    n.Tip_Ponude = tbTipPonude.Text;
                    tbUPonudiFleg.Text = n.U_Ponudi_Fleg.ToString();
                    tbOpstina.Text = n.Opstina;
                    tbLokacija.Text = n.Lokacija;
                    tbOpis.Text = n.Opis;
                    tbKvadratura.Text = n.Kvadratura.ToString();
                    tbIdUgovoraOZastupanju.Text = n.Id_Ugovora_O_Zastupanju.ToString();
                    tbGrad.Text = n.Grad;
                    tbBrojUUlici.Text = n.Broj.ToString();
                    tbCena.Text = n.Cena.ToString();
                    tbTipIzdavanja.Text = "NULL";
                    tbUlica.Text = n.Ulica;


                }

                MessageBox.Show("USPEH");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void btnIzbrisiPrvuNekretninu_Click(object sender, EventArgs e)
        {
            nekretnina n = null;
            try
            {
                ISession s = DataLayer.GetSession();
                string email = tbEmail.Text;
                n = s.QueryOver<nekretnina>().Where(nek => nek.Vlasnik ==
                (s.QueryOver<klijenti>().Where(k => k.Email == email).List()[0])).List()[0];
                s.Delete(n);
                s.Flush();
                s.Close();

                MessageBox.Show("Ma radi");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        #region ugovori CRUD
        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            ugovor u = null;

            try
            {
                ISession s = DataLayer.GetSession();
                string emailKupac = tbEmailKupca.Text;
                string emailProdavca = tbEmailProdavca.Text;
                if (tbTipUgovora.Text == "kupoprodajni")
                {
                    u = new kupoprodajni_ugovor()
                    {
                        Datum_Potpisivanja = DateTime.Now,
                        BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text),
                        Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text),
                        Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text),
                        MesecnaRenta = (float)Double.Parse(tbMesecnaRenta.Text), 
                        Osnovna_cena = (float)Double.Parse(tbOsnovnaCena.Text),

                    };
                }
                else if (tbTipUgovora.Text == "o_zakupu")
                {
                    u = new ugovor_o_izdavanju()
                    {
                        Datum_Potpisivanja = DateTime.Now,
                        BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text),
                        Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text),
                        Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text),
                        MesecnaRenta = (float)Double.Parse(tbMesecnaRenta.Text),
                        Od = DateTime.Now,
                        Do = DateTime.Now
                    };
                }
                u.Kupac_ili_zakupac = s.QueryOver<klijenti>().Where(x => x.Email == (s.QueryOver<klijenti>().Where(y => y.Email == emailKupac).List()[0]).Email).List()[0];
                u.Prodavac = s.QueryOver<klijenti>().Where(x => x.Email == (s.QueryOver<klijenti>().Where(y => y.Email == emailProdavca).List()[0]).Email).List()[0];
                u.Nekretnina = u.Prodavac.LicneNekretnine[0];
                u.Nekretnina.U_Ponudi_Fleg = 0;
                u.Notar = s.Load<notar>(41);
                u.Agent = u.Nekretnina.Agent;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();

                MessageBox.Show("Bravo");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
                MessageBox.Show(ex.Message);
            }
        }



        private void btnUcitajUgovor_Click(object sender, EventArgs e)
        {
            string emailProdavca = tbEmailProdavca.Text;
            ucitajUgovor(emailProdavca);

        }

        public void ucitajUgovor(string emailProdavca)
        {
            ugovor u = null;

            try
            {
                ISession s = DataLayer.GetSession();
                u = s.QueryOver<ugovor>().Where(x => x.Prodavac == (s.QueryOver<klijenti>().Where(y => y.Email == emailProdavca).List()[0])).List()[0];
                if (u.GetType() == typeof(ugovor_o_izdavanju))
                {
                    ugovor_o_izdavanju z = u as ugovor_o_izdavanju;
                    tbTipUgovora.Text = z.Tip_Ugovora;
                    tbBonusAgentu.Text = z.BonusAgentu.ToString();
                    tbNaknadaZaAgenciju.Text = z.Naknada_Za_Agenciju.ToString();
                    tbEmailKupca.Text = z.Kupac_ili_zakupac.Email;
                    tbEmailProdavca.Text = emailProdavca;
                    tbNaknadaNotaru.Text = z.Naknada_notaru.ToString();
                    tbMesecnaRenta.Text = z.MesecnaRenta.ToString();
                    tbOd.Text = z.Od.ToString();
                    tbDo.Text = z.Do.ToString();

                }
                else
                {
                    kupoprodajni_ugovor z = u as kupoprodajni_ugovor;
                    tbTipUgovora.Text = z.Tip_Ugovora;
                    tbBonusAgentu.Text = z.BonusAgentu.ToString();
                    tbNaknadaZaAgenciju.Text = z.Naknada_Za_Agenciju.ToString();
                    tbEmailKupca.Text = z.Kupac_ili_zakupac.Email;
                    tbEmailProdavca.Text = emailProdavca;
                    tbNaknadaNotaru.Text = z.Naknada_notaru.ToString();
                    tbMesecnaRenta.Text = z.MesecnaRenta.ToString();
                    tbOsnovnaCena.Text = z.Osnovna_cena.ToString();

                }

                s.Close();

                MessageBox.Show("Bravo");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ugovor u = null;
            string emailProdavca = tbEmailProdavca.Text;
            string emailKupca = tbEmailKupca.Text;
            try
            {
                ISession s = DataLayer.GetSession();
                u = s.QueryOver<ugovor>().Where(x => x.Prodavac == (s.QueryOver<klijenti>().Where(y => y.Email == emailProdavca).List()[0])).List()[0];

                if (u.GetType() == typeof(kupoprodajni_ugovor))
                {
                    kupoprodajni_ugovor k = u as kupoprodajni_ugovor;

                    k.Datum_Potpisivanja = DateTime.Now;
                    k.BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text);
                    k.Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text);
                    k.Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text);
                    k.MesecnaRenta = (float)Double.Parse(tbMesecnaRenta.Text);
                    k.Osnovna_cena = (float)Double.Parse(tbOsnovnaCena.Text);
                    u = k;

                }
                else if (u.GetType() == typeof(ugovor_o_izdavanju))
                {
                    ugovor_o_izdavanju z = u as ugovor_o_izdavanju;

                    z.Datum_Potpisivanja = DateTime.Now;
                    z.BonusAgentu = (float)Double.Parse(tbBonusAgentu.Text);
                    z.Naknada_Za_Agenciju = (float)Double.Parse(tbNaknadaZaAgenciju.Text);
                    z.Naknada_notaru = (float)Double.Parse(tbNaknadaNotaru.Text);
                    z.MesecnaRenta = (float)Double.Parse(tbMesecnaRenta.Text);
                    z.Od = DateTime.Now;
                    z.Do = DateTime.Now;
                    u = z;
                }
                u.Kupac_ili_zakupac = s.QueryOver<klijenti>().Where(x => x.Email == (s.QueryOver<klijenti>().Where(y => y.Email == emailKupca).List()[0]).Email).List()[0];
                u.Prodavac = s.QueryOver<klijenti>().Where(x => x.Email == (s.QueryOver<klijenti>().Where(y => y.Email == emailProdavca).List()[0]).Email).List()[0];
                u.Nekretnina = u.Prodavac.LicneNekretnine[0];
                u.Nekretnina.U_Ponudi_Fleg = 0;
                u.Notar = s.Load<notar>(41);
                u.Agent = u.Nekretnina.Agent;

                s.Update(u);
                s.Flush();
                s.Close();
                MessageBox.Show("Bravo");

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            string emailProdavca = tbEmailProdavca.Text;
            ugovor u = null;
            try
            {
                ISession s = DataLayer.GetSession();
                u = s.QueryOver<ugovor>().Where(x => x.Prodavac == (s.QueryOver<klijenti>().Where(y => y.Email == emailProdavca).List()[0])).List()[0];

                s.Delete(u);

                s.Flush();
                s.Close();
                MessageBox.Show("Uspeh");
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region pravnizastupnik CRUD
        private void btnDodajPravnog_Click(object sender, EventArgs e)
        {
            string emailKlijenta = tbEmailKlijenta.Text;
            klijenti k = null;
            try
            {
                ISession s = DataLayer.GetSession();
                k = s.QueryOver<klijenti>().Where(y => y.Email == emailKlijenta).List()[0];
                pravniZastupnik p = new pravniZastupnik()
                {
                    Ime = tbImeZastupnika.Text,
                    Prezime = tbPrezimeZastupnika.Text,
                    MatBr = Int32.Parse(tbMatBr.Text),
                    NazivAgencije = tbNazivAgencije.Text,
                    Grad = tbGradZastupnika.Text,
                    Ulica = tbUlicaZastupnika.Text,
                    Broj = Int32.Parse(tbBrojUliceZastupnika.Text)

                };

                s.SaveOrUpdate(p);


                zastupa z = new zastupa();
                z.ZastupaZastupnik = p;
                z.ZastupaKlijent = k;
                z.vazeciFleg = 1;
                k.pravniZastupnici.Add(z);
                

                //k.pravniZastupnici[k.pravniZastupnici.Count] = new zastupa();
                //k.pravniZastupnici[k.pravniZastupnici.Count].ZastupaZastupnik = p;
                
                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspeh");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public void ucitajPravnogZastupnika(string emailKlijenta)
        {

        }
        private void btnUcitajPravnog_Click(object sender, EventArgs e)
        {
            string emailKlijenta = tbEmailKlijenta.Text;
            pravniZastupnik k = null;
            try
            {
                ISession s = DataLayer.GetSession();
                klijenti klijent = s.QueryOver<klijenti>().Where(x => x.Email == emailKlijenta).List()[0];

                k = klijent.pravniZastupnici[0].ZastupaZastupnik;

                tbImeZastupnika.Text = k.Ime;
                tbPrezimeZastupnika.Text = k.Prezime;
                tbMatBr.Text = k.MatBr.ToString();
                tbNazivAgencije.Text = k.NazivAgencije;
                tbGradZastupnika.Text = k.Grad;
                tbUlicaZastupnika.Text = k.Ulica;
                tbBrojUliceZastupnika.Text = k.Broj.ToString();

                s.Close();
                MessageBox.Show("Uspeh");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnAzurirajPravnog_Click(object sender, EventArgs e)
        {
            string emailKlijenta = tbEmailKlijenta.Text;
            pravniZastupnik k = null;
            try
            {
                ISession s = DataLayer.GetSession();
                klijenti klijent = s.QueryOver<klijenti>().Where(x => x.Email == emailKlijenta).List()[0];
                k = klijent.pravniZastupnici[0].ZastupaZastupnik;

                k.Ime = tbImeZastupnika.Text;
                k.Prezime = tbPrezimeZastupnika.Text;
                k.MatBr = Int32.Parse(tbMatBr.Text);
                k.NazivAgencije = tbNazivAgencije.Text;
                k.Grad = tbGradZastupnika.Text;
                k.Ulica = tbUlicaZastupnika.Text;
                k.Broj = Int32.Parse(tbBrojUliceZastupnika.Text);

                s.Update(k);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspeh");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnIzbrisiPravnog_Click(object sender, EventArgs e)
        {
            string emailKlijenta = tbEmailKlijenta.Text;
            pravniZastupnik pravniZastupnik = null;
            try
            {
                ISession s = DataLayer.GetSession();
                klijenti klijent = s.QueryOver<klijenti>().Where(x => x.Email == emailKlijenta).List()[0];
                pravniZastupnik = klijent.pravniZastupnici[0].ZastupaZastupnik;
                klijent.pravniZastupnici[0] = null;
                
                s.Delete(pravniZastupnik);
                s.Flush();
                s.Close();

                MessageBox.Show("Uspeh");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        #endregion

    }
}
