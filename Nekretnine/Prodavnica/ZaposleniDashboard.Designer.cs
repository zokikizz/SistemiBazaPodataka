namespace Prodavnica
{
    partial class ZaposleniDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUgovori = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbUgovori = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbOzakupu = new System.Windows.Forms.GroupBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMesecnaRenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKupoprodajni = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOsnovnaCena = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbZakupu = new System.Windows.Forms.RadioButton();
            this.rbKuporpodajni = new System.Windows.Forms.RadioButton();
            this.cbPravniZastupnikProdavca = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbPravniZastupnikKupca = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbKupacZakupac = new System.Windows.Forms.ComboBox();
            this.cbNotar = new System.Windows.Forms.ComboBox();
            this.cbNekretnina = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDatumPotpisivanja = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBonusAgentu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNaknadaZaAgenciju = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNaknadaNotaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajUgovor = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabUgovori.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOzakupu.SuspendLayout();
            this.gbKupoprodajni.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUgovori
            // 
            this.tabUgovori.Controls.Add(this.tabPage1);
            this.tabUgovori.Controls.Add(this.tabPage2);
            this.tabUgovori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUgovori.Location = new System.Drawing.Point(0, 0);
            this.tabUgovori.Name = "tabUgovori";
            this.tabUgovori.SelectedIndex = 0;
            this.tabUgovori.Size = new System.Drawing.Size(651, 673);
            this.tabUgovori.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbUgovori);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 647);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ugovor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbUgovori
            // 
            this.lbUgovori.FormattingEnabled = true;
            this.lbUgovori.Location = new System.Drawing.Point(330, 6);
            this.lbUgovori.Name = "lbUgovori";
            this.lbUgovori.Size = new System.Drawing.Size(310, 641);
            this.lbUgovori.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbOzakupu);
            this.groupBox1.Controls.Add(this.gbKupoprodajni);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnDodajUgovor);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 644);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugovor";
            // 
            // gbOzakupu
            // 
            this.gbOzakupu.Controls.Add(this.dtpDo);
            this.gbOzakupu.Controls.Add(this.dtpOd);
            this.gbOzakupu.Controls.Add(this.label3);
            this.gbOzakupu.Controls.Add(this.label7);
            this.gbOzakupu.Controls.Add(this.tbMesecnaRenta);
            this.gbOzakupu.Controls.Add(this.label1);
            this.gbOzakupu.Location = new System.Drawing.Point(8, 419);
            this.gbOzakupu.Name = "gbOzakupu";
            this.gbOzakupu.Size = new System.Drawing.Size(280, 105);
            this.gbOzakupu.TabIndex = 36;
            this.gbOzakupu.TabStop = false;
            this.gbOzakupu.Text = "O zakupu:";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(62, 75);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 37;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(62, 46);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mesecna Renta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Do:";
            // 
            // tbMesecnaRenta
            // 
            this.tbMesecnaRenta.Location = new System.Drawing.Point(99, 23);
            this.tbMesecnaRenta.Name = "tbMesecnaRenta";
            this.tbMesecnaRenta.Size = new System.Drawing.Size(54, 20);
            this.tbMesecnaRenta.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Od:";
            // 
            // gbKupoprodajni
            // 
            this.gbKupoprodajni.Controls.Add(this.label2);
            this.gbKupoprodajni.Controls.Add(this.tbOsnovnaCena);
            this.gbKupoprodajni.Location = new System.Drawing.Point(8, 356);
            this.gbKupoprodajni.Name = "gbKupoprodajni";
            this.gbKupoprodajni.Size = new System.Drawing.Size(280, 57);
            this.gbKupoprodajni.TabIndex = 35;
            this.gbKupoprodajni.TabStop = false;
            this.gbKupoprodajni.Text = "Kupoprodajni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Osnovna cena";
            // 
            // tbOsnovnaCena
            // 
            this.tbOsnovnaCena.Location = new System.Drawing.Point(91, 24);
            this.tbOsnovnaCena.Name = "tbOsnovnaCena";
            this.tbOsnovnaCena.Size = new System.Drawing.Size(47, 20);
            this.tbOsnovnaCena.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbZakupu);
            this.groupBox3.Controls.Add(this.rbKuporpodajni);
            this.groupBox3.Controls.Add(this.cbPravniZastupnikProdavca);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cbPravniZastupnikKupca);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cbKupacZakupac);
            this.groupBox3.Controls.Add(this.cbNotar);
            this.groupBox3.Controls.Add(this.cbNekretnina);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpDatumPotpisivanja);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbBonusAgentu);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbNaknadaZaAgenciju);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbNaknadaNotaru);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 331);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opste:";
            // 
            // rbZakupu
            // 
            this.rbZakupu.AutoSize = true;
            this.rbZakupu.Location = new System.Drawing.Point(189, 20);
            this.rbZakupu.Name = "rbZakupu";
            this.rbZakupu.Size = new System.Drawing.Size(72, 17);
            this.rbZakupu.TabIndex = 55;
            this.rbZakupu.TabStop = true;
            this.rbZakupu.Text = "o_zakupu";
            this.rbZakupu.UseVisualStyleBackColor = true;
            // 
            // rbKuporpodajni
            // 
            this.rbKuporpodajni.AutoSize = true;
            this.rbKuporpodajni.Location = new System.Drawing.Point(8, 20);
            this.rbKuporpodajni.Name = "rbKuporpodajni";
            this.rbKuporpodajni.Size = new System.Drawing.Size(86, 17);
            this.rbKuporpodajni.TabIndex = 54;
            this.rbKuporpodajni.TabStop = true;
            this.rbKuporpodajni.Text = "kupoprodajni";
            this.rbKuporpodajni.UseVisualStyleBackColor = true;
            // 
            // cbPravniZastupnikProdavca
            // 
            this.cbPravniZastupnikProdavca.FormattingEnabled = true;
            this.cbPravniZastupnikProdavca.Location = new System.Drawing.Point(145, 291);
            this.cbPravniZastupnikProdavca.Name = "cbPravniZastupnikProdavca";
            this.cbPravniZastupnikProdavca.Size = new System.Drawing.Size(121, 21);
            this.cbPravniZastupnikProdavca.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(133, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Pravni zastupnik prodavca";
            // 
            // cbPravniZastupnikKupca
            // 
            this.cbPravniZastupnikKupca.FormattingEnabled = true;
            this.cbPravniZastupnikKupca.Location = new System.Drawing.Point(134, 264);
            this.cbPravniZastupnikKupca.Name = "cbPravniZastupnikKupca";
            this.cbPravniZastupnikKupca.Size = new System.Drawing.Size(121, 21);
            this.cbPravniZastupnikKupca.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Pravni zastupnik kupca";
            // 
            // cbKupacZakupac
            // 
            this.cbKupacZakupac.FormattingEnabled = true;
            this.cbKupacZakupac.Location = new System.Drawing.Point(107, 233);
            this.cbKupacZakupac.Name = "cbKupacZakupac";
            this.cbKupacZakupac.Size = new System.Drawing.Size(121, 21);
            this.cbKupacZakupac.TabIndex = 49;
            this.cbKupacZakupac.SelectedIndexChanged += new System.EventHandler(this.cbKupacZakupac_SelectedIndexChanged);
            // 
            // cbNotar
            // 
            this.cbNotar.FormattingEnabled = true;
            this.cbNotar.Location = new System.Drawing.Point(48, 206);
            this.cbNotar.Name = "cbNotar";
            this.cbNotar.Size = new System.Drawing.Size(180, 21);
            this.cbNotar.TabIndex = 48;
            // 
            // cbNekretnina
            // 
            this.cbNekretnina.FormattingEnabled = true;
            this.cbNekretnina.Location = new System.Drawing.Point(72, 179);
            this.cbNekretnina.Name = "cbNekretnina";
            this.cbNekretnina.Size = new System.Drawing.Size(224, 21);
            this.cbNekretnina.TabIndex = 46;
            this.cbNekretnina.SelectedIndexChanged += new System.EventHandler(this.cbNekretnina_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Kupac ili zakupac";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Notar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Nekretnina:";
            // 
            // dtpDatumPotpisivanja
            // 
            this.dtpDatumPotpisivanja.CustomFormat = "dd-MM-yyyy";
            this.dtpDatumPotpisivanja.Location = new System.Drawing.Point(107, 147);
            this.dtpDatumPotpisivanja.Name = "dtpDatumPotpisivanja";
            this.dtpDatumPotpisivanja.Size = new System.Drawing.Size(181, 20);
            this.dtpDatumPotpisivanja.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Datum potisivanja";
            // 
            // tbBonusAgentu
            // 
            this.tbBonusAgentu.Location = new System.Drawing.Point(88, 50);
            this.tbBonusAgentu.Name = "tbBonusAgentu";
            this.tbBonusAgentu.Size = new System.Drawing.Size(40, 20);
            this.tbBonusAgentu.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bonus agentu:";
            // 
            // tbNaknadaZaAgenciju
            // 
            this.tbNaknadaZaAgenciju.Location = new System.Drawing.Point(120, 76);
            this.tbNaknadaZaAgenciju.Name = "tbNaknadaZaAgenciju";
            this.tbNaknadaZaAgenciju.Size = new System.Drawing.Size(57, 20);
            this.tbNaknadaZaAgenciju.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Naknada za agenciju";
            // 
            // tbNaknadaNotaru
            // 
            this.tbNaknadaNotaru.Location = new System.Drawing.Point(121, 112);
            this.tbNaknadaNotaru.Name = "tbNaknadaNotaru";
            this.tbNaknadaNotaru.Size = new System.Drawing.Size(134, 20);
            this.tbNaknadaNotaru.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Naknada Notaru";
            // 
            // btnDodajUgovor
            // 
            this.btnDodajUgovor.Location = new System.Drawing.Point(92, 530);
            this.btnDodajUgovor.Name = "btnDodajUgovor";
            this.btnDodajUgovor.Size = new System.Drawing.Size(90, 23);
            this.btnDodajUgovor.TabIndex = 27;
            this.btnDodajUgovor.Text = "Dodaj ugovor";
            this.btnDodajUgovor.UseVisualStyleBackColor = true;
            this.btnDodajUgovor.Click += new System.EventHandler(this.btnDodajUgovor_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 647);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pravni zastupnik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ZaposleniDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 673);
            this.Controls.Add(this.tabUgovori);
            this.Name = "ZaposleniDashboard";
            this.Text = "ZaposleniDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZaposleniDashboard_FormClosing);
            this.tabUgovori.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbOzakupu.ResumeLayout(false);
            this.gbOzakupu.PerformLayout();
            this.gbKupoprodajni.ResumeLayout(false);
            this.gbKupoprodajni.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUgovori;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbUgovori;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbOzakupu;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMesecnaRenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbKupoprodajni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOsnovnaCena;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbBonusAgentu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNaknadaZaAgenciju;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNaknadaNotaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajUgovor;
        private System.Windows.Forms.DateTimePicker dtpDatumPotpisivanja;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbKupacZakupac;
        private System.Windows.Forms.ComboBox cbNotar;
        private System.Windows.Forms.ComboBox cbNekretnina;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPravniZastupnikKupca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPravniZastupnikProdavca;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbZakupu;
        private System.Windows.Forms.RadioButton rbKuporpodajni;
    }
}