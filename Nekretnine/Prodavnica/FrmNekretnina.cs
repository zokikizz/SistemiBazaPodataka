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
    public partial class FrmNekretnina : Form
    {
        nekretnina Currentnekretnina;
        IList<fotografija> slike;
        int temp = -1;


        public FrmNekretnina()
        {
            InitializeComponent();
        }

        public FrmNekretnina(nekretnina n)
        {
            ISession s = DataLayer.GetSession();
            try { 
                InitializeComponent();
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;

                Currentnekretnina = n;
                s.Lock(Currentnekretnina, LockMode.Read);


                lbAdresa.Text = "Grad:" + Currentnekretnina.Grad + " Ulica: " + Currentnekretnina.Ulica + " Broj: " + Currentnekretnina.Broj + "\nOpstina: " + Currentnekretnina.Opstina + " Broj parcele: " + Currentnekretnina.Br_Parcele;

                lbAgent.Text = "Ime agenta: " + Currentnekretnina.Agent.Ime + " Prezime agenta: " + Currentnekretnina.Agent.Prezime;
                lbVlasnik.Text = "Ime vlasnika: " + Currentnekretnina.Vlasnik.Ime + " Prezime vlasnika: " + Currentnekretnina.Vlasnik.Prezime;
                lbCena.Text = " Cena:" + Currentnekretnina.Cena;
                lbOpis.Text = " Opis: " + Currentnekretnina.Opis;
                lbSpratBroj.Text = " Sprat/Broj: " + Currentnekretnina.Sprat_Broj;
                lbKvadratura.Text = "Kvadratura: " + Currentnekretnina.Kvadratura + " m^2";
                lbtip.Text = "Tip: " + Currentnekretnina.Tip;
                slike = n.Fotografije;
                if (slike.Count != 0)
                {
                    temp = 0;
                    pbSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(slike[temp].foto));
                }
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void btnPredhodna_Click(object sender, EventArgs e)
        {
            if (temp == 0)
                temp = slike.Count - 1;
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
    }
}
