
using NHibernate;
using SistemiBazaPodataka.Entiteti;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prodavnica
{
    public partial class AzuriranjePravnihZasputnika : Form
    {
        public klijenti cln = null;

        public IList<pravniZastupnik> ostali;
        public IList<zastupa> trenutni;

        public AzuriranjePravnihZasputnika()
        {
            InitializeComponent();
        }


        public AzuriranjePravnihZasputnika(klijenti k)
        {
            InitializeComponent();
            this.cln = k;


            ISession s = DataLayer.GetSession();

            try
            {
                s.Lock(cln, LockMode.None);
                trenutni = cln.pravniZastupnici;
                foreach (zastupa a in trenutni)
                    if(a.vazeciFleg == 1)
                        lbLicniPravniZastupnici.Items.Add(a.ZastupaZastupnik);

               ostali = s.QueryOver<pravniZastupnik>().List();

                if (trenutni.Count == 0)
                    foreach (pravniZastupnik z in ostali)
                        lbPravniZastupnici.Items.Add(z);
                else
                    foreach (pravniZastupnik z in ostali)
                    {
                       if(trenutni.Where( x => x.ZastupaZastupnik.Id == z.Id && x.vazeciFleg == 1).Count() == 0)
                            lbPravniZastupnici.Items.Add(z);
                    }

                s.Close();
            }
            catch (Exception ex)
            {


            }



        }


        private void brtAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (lbPravniZastupnici.SelectedIndex > -1 && lbLicniPravniZastupnici.SelectedIndex < lbPravniZastupnici.Items.Count)
                {


                    ISession s = DataLayer.GetSession();
                    pravniZastupnik p = (pravniZastupnik)lbPravniZastupnici.Items[lbPravniZastupnici.SelectedIndex];
                    IEnumerable<zastupa> ee = cln.pravniZastupnici.Where(x => x.ZastupaZastupnik.Id == p.Id);
                    if (ee.Count() != 0)
                        cln.pravniZastupnici.Where(x => x.ZastupaZastupnik.Id == p.Id).First().vazeciFleg = 1;
                    else
                    {
                        cln.pravniZastupnici.Add(new zastupa() { ZastupaKlijent = cln, ZastupaZastupnik = p, vazeciFleg = 1 });
                    }

                    s.SaveOrUpdate(cln);
                    s.Flush();
                    s.Close();

                    lbPravniZastupnici.Items.Remove(p);
                    lbLicniPravniZastupnici.Items.Add(p);

                    lbLicniPravniZastupnici.Refresh();
                    lbPravniZastupnici.Refresh();

                    MessageBox.Show("Uspesno dodato zastupnistvo.");
                    Console.WriteLine("Oke.");

                }
                



            }
            catch( Exception ex)
            {

                MessageBox.Show("Neuspeh");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
     

            try
            {
                if (lbLicniPravniZastupnici.SelectedIndex > -1 && lbLicniPravniZastupnici.SelectedIndex < lbLicniPravniZastupnici.Items.Count)
                {
                    ISession s = DataLayer.GetSession();
                    pravniZastupnik p = (pravniZastupnik)lbLicniPravniZastupnici.Items[lbLicniPravniZastupnici.SelectedIndex];
                    cln.pravniZastupnici.Where(x => x.ZastupaZastupnik.Id == p.Id).First().vazeciFleg = 0;

                    s.Update(cln);
                    s.Flush();
                    s.Close();

                    lbLicniPravniZastupnici.Items.Remove(p);
                    lbPravniZastupnici.Items.Add(p);

                    lbLicniPravniZastupnici.Refresh();
                    lbPravniZastupnici.Refresh();

                    MessageBox.Show("Uspesno brisano zastupnistvo.");
                    Console.WriteLine("Oke.");



                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Neuspeh");
            }

        }
    }
}
