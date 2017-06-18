using NHibernate;
using NHibernate.Cfg.MappingSchema;
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
    public partial class Dashboard : Form
    {
        IList<nekretnina> zaIzdavanje = null;
        IList<nekretnina> naProdaju = null;
        public klijenti CurrentClient = new klijenti();
        private Login login;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(klijenti k)
        {
            CurrentClient = k;
            InitializeComponent();

            ISession s = DataLayer.GetSession();
            try
            {
               zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
                naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();




                foreach (nekretnina n in zaIzdavanje)
                    lbZaIzdavanje.Items.Add(n);



                foreach (nekretnina n in naProdaju)
                    lbNaProdaju.Items.Add(n);



                foreach (nekretnina n in CurrentClient.LicneNekretnine)
                    lbLicneNekretnine.Items.Add(n);
            }
            catch(Exception ec)
            {

            }
            
          


            s.Close();

        }

        public Dashboard(klijenti k, Login login) : this(k)
        {
            this.login = login;


            InitializeComponent();


            CurrentClient = k;
            ISession s = DataLayer.GetSession();
            try
            {
                zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
                naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();



                //foreach (nekretnina n in zaIzdavanje)
                //    lbZaIzdavanje.Items.Add(n);
                lbZaIzdavanje.DataSource = zaIzdavanje;


                lbNaProdaju.DataSource = naProdaju;

                lbLicneNekretnine.DataSource = CurrentClient.LicneNekretnine;
                //foreach (nekretnina n in naProdaju)
                //    lbNaProdaju.Items.Add(n);



                //foreach (nekretnina n in CurrentClient.LicneNekretnine)
                //    lbLicneNekretnine.Items.Add(n);

                s.Close();


            }
            catch (Exception ec)
            {

            }


        }

        private void lbLicneNekretnine_Click(object sender, EventArgs e)
        {
            if (lbLicneNekretnine != null)
            {
                FrmNekretnina n1 = new FrmNekretnina((nekretnina)lbLicneNekretnine.Items[lbLicneNekretnine.SelectedIndex]);
                n1.ShowDialog();

                ISession s = DataLayer.GetSession();

                


                try
                {
                    zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
                    naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();

                    lbZaIzdavanje.DataSource = zaIzdavanje;
                    lbNaProdaju.DataSource = naProdaju;
                    lbLicneNekretnine.DataSource = CurrentClient.LicneNekretnine;
                    //foreach (nekretnina n in zaIzdavanje)
                    //    lbZaIzdavanje.Items.Add(n);



                    //foreach (nekretnina n in naProdaju)
                    //    lbNaProdaju.Items.Add(n);



                    //foreach (nekretnina n in CurrentClient.LicneNekretnine)
                    //    lbLicneNekretnine.Items.Add(n);



                    s.Close();
                }
                catch (Exception ec)
                {

                }
            }
        }

        private void lbZaIzdavanje_Click(object sender, EventArgs e)
        {
            if (lbZaIzdavanje.SelectedIndex > -1)
            {
                FrmNekretnina n1 = new FrmNekretnina((nekretnina)lbZaIzdavanje.Items[lbZaIzdavanje.SelectedIndex]);
                n1.ShowDialog();

                ISession s = DataLayer.GetSession();

                //lbLicneNekretnine.Items.Clear();
                //lbNaProdaju.Items.Clear();
                //lbZaIzdavanje.Items.Clear();


                try
                {
                    zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
                    naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();

                    lbZaIzdavanje.DataSource = zaIzdavanje;
                    //foreach (nekretnina n in zaIzdavanje)
                    //lbZaIzdavanje.Items.Add(n);


                    lbNaProdaju.DataSource = lbNaProdaju;
                    //foreach (nekretnina n in naProdaju)
                    //    lbNaProdaju.Items.Add(n);


                    lbLicneNekretnine.DataSource = lbLicneNekretnine;
                    
                    //foreach (nekretnina n in CurrentClient.LicneNekretnine)
                    //    lbLicneNekretnine.Items.Add(n);

                    //lbLicneNekretnine.Refresh();
                    //lbNaProdaju.Refresh();
                    //lbZaIzdavanje.Refresh();

                    s.Close();
                }
                catch (Exception ec)
                {

                }

              
            }
        }

        private void lbNaProdaju_Click(object sender, EventArgs e)
        {
            if (lbNaProdaju.SelectedIndex > -1)
            {
                FrmNekretnina n1 = new FrmNekretnina((nekretnina)lbNaProdaju.Items[lbNaProdaju.SelectedIndex]);
                n1.ShowDialog();



                ISession s = DataLayer.GetSession();



                try
                {
                    zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
                    naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();

                    lbZaIzdavanje.DataSource = zaIzdavanje;
                    lbNaProdaju.DataSource = naProdaju;
                    lbLicneNekretnine.DataSource = CurrentClient.LicneNekretnine;
                    //foreach (nekretnina n in zaIzdavanje)
                    //    lbZaIzdavanje.Items.Add(n);



                    //foreach (nekretnina n in naProdaju)
                    //    lbNaProdaju.Items.Add(n);



                    //foreach (nekretnina n in CurrentClient.LicneNekretnine)
                    //    lbLicneNekretnine.Items.Add(n);

                    lbLicneNekretnine.Refresh();
                    lbNaProdaju.Refresh();
                    lbZaIzdavanje.Refresh();

                    s.Close();
                }
                catch (Exception ec)
                {

                }
            }
        }

        private void azurirajPravneZastupnikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AzuriranjePravnihZasputnika a = new AzuriranjePravnihZasputnika(CurrentClient);
            a.ShowDialog();
        }

        private void dodajNekretnineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajNekretninu d = new DodajNekretninu(CurrentClient.Id,this);

            d.Show();
           
            
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        private void lbZaIzdavanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lbZaIzdavanje.SelectedIndex > -1)
            //{
            //    FrmNekretnina n1 = new FrmNekretnina((nekretnina)lbZaIzdavanje.Items[lbZaIzdavanje.SelectedIndex]);
            //    n1.ShowDialog();

            //    ISession s = DataLayer.GetSession();

            //    lbLicneNekretnine.Items.Clear();
            //    lbNaProdaju.Items.Clear();
            //    lbZaIzdavanje.Items.Clear();


            //    try
            //    {
            //        zaIzdavanje = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "izdavanje" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();
            //        naProdaju = s.QueryOver<nekretnina>().Where(x => x.Tip_Ponude == "prodaja" && x.U_Ponudi_Fleg == 1 && x.Vlasnik.Id != CurrentClient.Id).List();


            //        foreach (nekretnina n in zaIzdavanje)
            //            lbZaIzdavanje.Items.Add(n);



            //        foreach (nekretnina n in naProdaju)
            //            lbNaProdaju.Items.Add(n);



            //        foreach (nekretnina n in CurrentClient.LicneNekretnine)
            //            lbLicneNekretnine.Items.Add(n);

            //        lbLicneNekretnine.Refresh();
            //        lbNaProdaju.Refresh();
            //        lbZaIzdavanje.Refresh();

            //        s.Close();
            //    }
            //    catch (Exception ec)
            //    {

            //    }
            //}
        }

        private void lbLicneNekretnine_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
