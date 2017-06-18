namespace Prodavnica
{
    partial class FrmNekretnina
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
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbKvadratura = new System.Windows.Forms.Label();
            this.lbtip = new System.Windows.Forms.Label();
            this.lbOpis = new System.Windows.Forms.Label();
            this.lbSpratBroj = new System.Windows.Forms.Label();
            this.lbAgent = new System.Windows.Forms.Label();
            this.lbVlasnik = new System.Windows.Forms.Label();
            this.btnSledeca = new System.Windows.Forms.Button();
            this.btnPredhodna = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(13, 115);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(40, 13);
            this.lbAdresa.TabIndex = 0;
            this.lbAdresa.Text = "Adresa";
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.Location = new System.Drawing.Point(12, 142);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(32, 13);
            this.lbCena.TabIndex = 1;
            this.lbCena.Text = "Cena";
            // 
            // lbKvadratura
            // 
            this.lbKvadratura.AutoSize = true;
            this.lbKvadratura.Location = new System.Drawing.Point(13, 84);
            this.lbKvadratura.Name = "lbKvadratura";
            this.lbKvadratura.Size = new System.Drawing.Size(59, 13);
            this.lbKvadratura.TabIndex = 2;
            this.lbKvadratura.Text = "Kvadratura";
            // 
            // lbtip
            // 
            this.lbtip.AutoSize = true;
            this.lbtip.Location = new System.Drawing.Point(12, 168);
            this.lbtip.Name = "lbtip";
            this.lbtip.Size = new System.Drawing.Size(18, 13);
            this.lbtip.TabIndex = 3;
            this.lbtip.Text = "tip";
            // 
            // lbOpis
            // 
            this.lbOpis.AutoSize = true;
            this.lbOpis.Location = new System.Drawing.Point(13, 220);
            this.lbOpis.Name = "lbOpis";
            this.lbOpis.Size = new System.Drawing.Size(26, 13);
            this.lbOpis.TabIndex = 4;
            this.lbOpis.Text = "opis";
            // 
            // lbSpratBroj
            // 
            this.lbSpratBroj.AutoSize = true;
            this.lbSpratBroj.Location = new System.Drawing.Point(13, 190);
            this.lbSpratBroj.Name = "lbSpratBroj";
            this.lbSpratBroj.Size = new System.Drawing.Size(58, 13);
            this.lbSpratBroj.TabIndex = 5;
            this.lbSpratBroj.Text = "svprat/broj";
            // 
            // lbAgent
            // 
            this.lbAgent.AutoSize = true;
            this.lbAgent.Location = new System.Drawing.Point(12, 18);
            this.lbAgent.Name = "lbAgent";
            this.lbAgent.Size = new System.Drawing.Size(35, 13);
            this.lbAgent.TabIndex = 6;
            this.lbAgent.Text = "Agent";
            // 
            // lbVlasnik
            // 
            this.lbVlasnik.AutoSize = true;
            this.lbVlasnik.Location = new System.Drawing.Point(12, 51);
            this.lbVlasnik.Name = "lbVlasnik";
            this.lbVlasnik.Size = new System.Drawing.Size(41, 13);
            this.lbVlasnik.TabIndex = 7;
            this.lbVlasnik.Text = "Vlasnik";
            // 
            // btnSledeca
            // 
            this.btnSledeca.Location = new System.Drawing.Point(560, 65);
            this.btnSledeca.Name = "btnSledeca";
            this.btnSledeca.Size = new System.Drawing.Size(53, 23);
            this.btnSledeca.TabIndex = 34;
            this.btnSledeca.Text = ">>";
            this.btnSledeca.UseVisualStyleBackColor = true;
            this.btnSledeca.Click += new System.EventHandler(this.btnSledeca_Click);
            // 
            // btnPredhodna
            // 
            this.btnPredhodna.Location = new System.Drawing.Point(316, 65);
            this.btnPredhodna.Name = "btnPredhodna";
            this.btnPredhodna.Size = new System.Drawing.Size(53, 23);
            this.btnPredhodna.TabIndex = 33;
            this.btnPredhodna.Text = "<<";
            this.btnPredhodna.UseVisualStyleBackColor = true;
            this.btnPredhodna.Click += new System.EventHandler(this.btnPredhodna_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(376, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(178, 126);
            this.pbSlika.TabIndex = 32;
            this.pbSlika.TabStop = false;
            // 
            // FrmNekretnina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(624, 284);
            this.Controls.Add(this.btnSledeca);
            this.Controls.Add(this.btnPredhodna);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lbVlasnik);
            this.Controls.Add(this.lbAgent);
            this.Controls.Add(this.lbSpratBroj);
            this.Controls.Add(this.lbOpis);
            this.Controls.Add(this.lbtip);
            this.Controls.Add(this.lbKvadratura);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.lbAdresa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNekretnina";
            this.ShowIcon = false;
            this.Text = "Nekretnina";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbKvadratura;
        private System.Windows.Forms.Label lbtip;
        private System.Windows.Forms.Label lbOpis;
        private System.Windows.Forms.Label lbSpratBroj;
        private System.Windows.Forms.Label lbAgent;
        private System.Windows.Forms.Label lbVlasnik;
        private System.Windows.Forms.Button btnSledeca;
        private System.Windows.Forms.Button btnPredhodna;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}