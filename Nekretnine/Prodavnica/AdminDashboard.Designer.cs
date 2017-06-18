namespace Prodavnica
{
    partial class AdminDashboard
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
            this.lbListaZaposlenih = new System.Windows.Forms.ListBox();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListaZaposlenih
            // 
            this.lbListaZaposlenih.FormattingEnabled = true;
            this.lbListaZaposlenih.Location = new System.Drawing.Point(13, 13);
            this.lbListaZaposlenih.Name = "lbListaZaposlenih";
            this.lbListaZaposlenih.Size = new System.Drawing.Size(359, 277);
            this.lbListaZaposlenih.TabIndex = 0;
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(389, 13);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(145, 23);
            this.btnDodajZaposlenog.TabIndex = 1;
            this.btnDodajZaposlenog.Text = "Dodaj zaposlenog";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 302);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.lbListaZaposlenih);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaZaposlenih;
        private System.Windows.Forms.Button btnDodajZaposlenog;
    }
}