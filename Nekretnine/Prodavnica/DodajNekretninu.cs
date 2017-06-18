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
    public partial class DodajNekretninu : Form
    {

        public IList<fotografija> slike = new List<fotografija>();
        int temp = -1;
        public Form frm;
        klijenti cln;
        public DodajNekretninu()
        {
            InitializeComponent();
        }

        public DodajNekretninu(int id, Form form)
        {
            frm = form;
            InitializeComponent();
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            

            gbTipIzdavanja.Enabled = false;
            gbVremenskiPeriod.Enabled = false;

            ISession s = DataLayer.GetSession();

            try
            {
                cln = s.QueryOver<klijenti>().Where(x => x.Id == id).List<klijenti>().First<klijenti>();
                IList<agent> a = s.QueryOver<agent>().List();


                cbAgenti.DataSource = a;

                s.Close();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Puce");
            }
        }

        private void btnDodajNektetninu_Click(object sender, EventArgs e)
        {

            ISession s = DataLayer.GetSession();

            try
            {
                s.Lock(cln, LockMode.None);
                if(rbIzdavanje.Checked)
                {
                    if (rbDuzi.Checked && rbDuzi.Enabled)
                    {

                        duzi_period n = new duzi_period();
                        n.Grad = tbGrad.Text;
                        n.Lokacija = tbLokacija.Text;
                        n.Ulica = tbUlica.Text;
                        n.Opstina = tbOpstina.Text;
                        n.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                        n.Broj = Int32.Parse(rbBrojuUlici.Text);
                        n.Kvadratura = Int32.Parse(tbKvadratura.Text);
                        n.Datum_Izgradnje = dtDatumIzgradnje.Value;
                        n.Cena = Int32.Parse(tbCena.Text);
                        n.Tip = tbTip.Text;
                        n.Sprat_Broj = tbSpratBroj.Text;
                        n.Opis = tbOpis.Text;
                        n.Tip_Ponude = "izdavanje";
                        n.Agent = (agent)cbAgenti.SelectedItem;
                        n.Vlasnik = cln;
                        cln.LicneNekretnine.Add(n);
                       
                        if (cbUponudi.Checked)
                        {
                            n.U_Ponudi_Fleg = 1;
                        }
                        else
                        {
                            n.U_Ponudi_Fleg = 0;
                        }
                        if (cbPravnaFizicka.Checked)
                        {
                            n.Fizicka_Pavna_Lica_Fleg = 1;
                        }
                        else
                        {
                            n.Fizicka_Pavna_Lica_Fleg = 0;
                        }
                        n.Br_Meseci = Int32.Parse(tbBrMeseci.Text);
                        s.SaveOrUpdate(n);
                        foreach (fotografija f in slike)
                        {
                            f.Pripada = n;
                            n.Fotografije.Add(f);
                        }
                        s.SaveOrUpdate(n);

                        MessageBox.Show("Uspesno dodata nekretnina.");
                    }
                    else
                    {
                        kraci_period n = new kraci_period();
                        n.Grad = tbGrad.Text;
                        n.Lokacija = tbLokacija.Text;
                        n.Ulica = tbUlica.Text;
                        n.Opstina = tbOpstina.Text;
                        n.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                        n.Broj = Int32.Parse(rbBrojuUlici.Text);
                        n.Kvadratura = Int32.Parse(tbKvadratura.Text);
                        n.Datum_Izgradnje = dtDatumIzgradnje.Value;
                        n.Cena = Int32.Parse(tbCena.Text);
                        n.Tip = tbTip.Text;
                        n.Sprat_Broj = tbSpratBroj.Text;
                        n.Opis = tbOpis.Text;
                        n.Tip_Ponude = "izdavanje";
                        n.Agent = (agent)cbAgenti.SelectedItem;
                        n.Vlasnik = cln;
                        cln.LicneNekretnine.Add(n);
                        if (cbUponudi.Checked)
                        {
                            n.U_Ponudi_Fleg = 1;
                        }
                        else
                        {
                            n.U_Ponudi_Fleg = 0;
                        }
                        n.Od = dpOd.Value;
                        n.Do = dpDo.Value;
                        n.Godina = Int32.Parse(tbGodina.Text);
                        s.SaveOrUpdate(n);
                        foreach (fotografija f in slike)
                        {
                            n.Fotografije.Add(f);
                        }
                        s.SaveOrUpdate(n);

                        MessageBox.Show("Uspesno dodata nekretnina.");
                    }
                }
                //
                //PRODAJA
                //
                else if (rbProdaja.Checked)
                {
                    

                        nekretnina n = new nekretnina();
                        n.Grad = tbGrad.Text;
                        n.Lokacija = tbLokacija.Text;
                        n.Ulica = tbUlica.Text;
                        n.Opstina = tbOpstina.Text;
                        n.Br_Parcele = Int32.Parse(tbBrojParcele.Text);
                        n.Broj = Int32.Parse(rbBrojuUlici.Text);
                        n.Kvadratura = Int32.Parse(tbKvadratura.Text);
                        n.Datum_Izgradnje = dtDatumIzgradnje.Value;
                        n.Cena = Int32.Parse(tbCena.Text);
                        n.Tip = tbTip.Text;
                        n.Sprat_Broj = tbSpratBroj.Text;
                        n.Opis = tbOpis.Text;
                        n.Tip_Ponude = "prodaja";
                        n.Agent = (agent)cbAgenti.SelectedItem;
                        n.Vlasnik = cln;
                        cln.LicneNekretnine.Add(n);

                        if (cbUponudi.Checked)
                        {
                            n.U_Ponudi_Fleg = 1;
                        }
                        else
                        {
                            n.U_Ponudi_Fleg = 0;
                        }
                        
                        
                        s.SaveOrUpdate(n);
                        foreach (fotografija f in slike)
                        {
                            f.Pripada = n;
                            n.Fotografije.Add(f);
                        }
                        s.SaveOrUpdate(n);

                    MessageBox.Show("Uspesno dodata nekretnina.");



                }
                
                s.Flush();
                s.Close();
                frm.Refresh();


            }
            catch ( Exception ex)
            {
                MessageBox.Show("Uneli ste nesto pogresno.");
            }

        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Image files (*.jpg, *jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *jpe; *.jfif; *.png";
            DialogResult dr = OpenFd.ShowDialog();

            if (dr != DialogResult.Cancel)
            {
                fotografija slika = new fotografija()
                {
                    foto = fotografija.ConvertImgToByte(Image.FromFile(OpenFd.FileName))

                };
                slike.Add(slika);
                pbSlika.Image = Image.FromFile(OpenFd.FileName);
                if(slike.Count == 1)
                {
                    temp = 0;
                }
                else
                {
                    temp++;
                }
            }
        }

        private void btnPredhodna_Click(object sender, EventArgs e)
        {
            if (temp == 0)
                temp = slike.Count-1;
            else
                temp--;
            pbSlika.Image = (Bitmap)((new ImageConverter()).ConvertFrom(slike[temp].foto));
        }

        private void btnSledeca_Click(object sender, EventArgs e)
        {
            if (temp == slike.Count - 1)
                temp = 0;
            else
                temp++;
            pbSlika.Image = (Bitmap)((new ImageConverter()).ConvertFrom(slike[temp].foto));

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gbTipIzdavanja.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gbTipIzdavanja.Enabled = false;
            gbVremenskiPeriod.Enabled = false;
        }

        private void rbDuzi_CheckedChanged(object sender, EventArgs e)
        {
            gbVremenskiPeriod.Enabled = true;
            tbBrMeseci.Enabled = true;
            cbPravnaFizicka.Enabled = true;
            tbGodina.Enabled = false;
            dpDo.Enabled = false;
            dpOd.Enabled = false;
        }

        private void rbKarci_CheckedChanged(object sender, EventArgs e)
        {
            gbVremenskiPeriod.Enabled = true;
            tbBrMeseci.Enabled = false;
            cbPravnaFizicka.Enabled = false;
            tbGodina.Enabled = true;
            dpDo.Enabled = true;
            dpOd.Enabled = true;
        }
    }
}
