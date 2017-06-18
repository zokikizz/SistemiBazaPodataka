namespace Prodavnica
{
    partial class AzuriranjePravnihZasputnika
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
            this.lbLicniPravniZastupnici = new System.Windows.Forms.ListBox();
            this.lbPravniZastupnici = new System.Windows.Forms.ListBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.brtAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLicniPravniZastupnici
            // 
            this.lbLicniPravniZastupnici.FormattingEnabled = true;
            this.lbLicniPravniZastupnici.Location = new System.Drawing.Point(13, 22);
            this.lbLicniPravniZastupnici.Name = "lbLicniPravniZastupnici";
            this.lbLicniPravniZastupnici.Size = new System.Drawing.Size(230, 95);
            this.lbLicniPravniZastupnici.TabIndex = 0;
            // 
            // lbPravniZastupnici
            // 
            this.lbPravniZastupnici.FormattingEnabled = true;
            this.lbPravniZastupnici.Location = new System.Drawing.Point(253, 22);
            this.lbPravniZastupnici.Name = "lbPravniZastupnici";
            this.lbPravniZastupnici.Size = new System.Drawing.Size(231, 95);
            this.lbPravniZastupnici.TabIndex = 1;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(13, 129);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // brtAdd
            // 
            this.brtAdd.Location = new System.Drawing.Point(253, 129);
            this.brtAdd.Name = "brtAdd";
            this.brtAdd.Size = new System.Drawing.Size(75, 23);
            this.brtAdd.TabIndex = 3;
            this.brtAdd.Text = "Add";
            this.brtAdd.UseVisualStyleBackColor = true;
            this.brtAdd.Click += new System.EventHandler(this.brtAdd_Click);
            // 
            // AzuriranjePravnihZasputnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 164);
            this.Controls.Add(this.brtAdd);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.lbPravniZastupnici);
            this.Controls.Add(this.lbLicniPravniZastupnici);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AzuriranjePravnihZasputnika";
            this.ShowIcon = false;
            this.Text = "Azuriranje pravnih zastupnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLicniPravniZastupnici;
        private System.Windows.Forms.ListBox lbPravniZastupnici;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button brtAdd;
    }
}