namespace Prodavnica
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbZaIzdavanje = new System.Windows.Forms.ListBox();
            this.lbNaProdaju = new System.Windows.Forms.ListBox();
            this.lbLicneNekretnine = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azurirajPravneZastupnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNekretnineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lbZaIzdavanje
            // 
            this.lbZaIzdavanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbZaIzdavanje.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZaIzdavanje.FormattingEnabled = true;
            this.lbZaIzdavanje.ItemHeight = 20;
            this.lbZaIzdavanje.Location = new System.Drawing.Point(3, 3);
            this.lbZaIzdavanje.Name = "lbZaIzdavanje";
            this.lbZaIzdavanje.Size = new System.Drawing.Size(694, 309);
            this.lbZaIzdavanje.TabIndex = 1;
            this.lbZaIzdavanje.Click += new System.EventHandler(this.lbZaIzdavanje_Click);
            this.lbZaIzdavanje.SelectedIndexChanged += new System.EventHandler(this.lbZaIzdavanje_SelectedIndexChanged);
            // 
            // lbNaProdaju
            // 
            this.lbNaProdaju.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNaProdaju.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaProdaju.FormattingEnabled = true;
            this.lbNaProdaju.ItemHeight = 20;
            this.lbNaProdaju.Location = new System.Drawing.Point(3, 3);
            this.lbNaProdaju.Name = "lbNaProdaju";
            this.lbNaProdaju.Size = new System.Drawing.Size(694, 309);
            this.lbNaProdaju.TabIndex = 2;
            this.lbNaProdaju.Click += new System.EventHandler(this.lbNaProdaju_Click);
            // 
            // lbLicneNekretnine
            // 
            this.lbLicneNekretnine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLicneNekretnine.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicneNekretnine.FormattingEnabled = true;
            this.lbLicneNekretnine.ItemHeight = 20;
            this.lbLicneNekretnine.Location = new System.Drawing.Point(3, 3);
            this.lbLicneNekretnine.Name = "lbLicneNekretnine";
            this.lbLicneNekretnine.Size = new System.Drawing.Size(694, 309);
            this.lbLicneNekretnine.TabIndex = 1;
            this.lbLicneNekretnine.Click += new System.EventHandler(this.lbLicneNekretnine_Click);
            this.lbLicneNekretnine.MouseEnter += new System.EventHandler(this.lbLicneNekretnine_MouseEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.azurirajPravneZastupnikeToolStripMenuItem,
            this.dodajNekretnineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profileToolStripMenuItem.Text = "Profil";
            // 
            // azurirajPravneZastupnikeToolStripMenuItem
            // 
            this.azurirajPravneZastupnikeToolStripMenuItem.Name = "azurirajPravneZastupnikeToolStripMenuItem";
            this.azurirajPravneZastupnikeToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.azurirajPravneZastupnikeToolStripMenuItem.Text = "Azuriraj pravne zastupnike";
            this.azurirajPravneZastupnikeToolStripMenuItem.Click += new System.EventHandler(this.azurirajPravneZastupnikeToolStripMenuItem_Click);
            // 
            // dodajNekretnineToolStripMenuItem
            // 
            this.dodajNekretnineToolStripMenuItem.Name = "dodajNekretnineToolStripMenuItem";
            this.dodajNekretnineToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.dodajNekretnineToolStripMenuItem.Text = "Dodaj nekretnine";
            this.dodajNekretnineToolStripMenuItem.Click += new System.EventHandler(this.dodajNekretnineToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(708, 341);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbZaIzdavanje);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nekretnine za izdavanje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbNaProdaju);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nekretnine na prodaju";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbLicneNekretnine);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(700, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Licne nekretnine";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 385);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbZaIzdavanje;
        private System.Windows.Forms.ListBox lbNaProdaju;
        private System.Windows.Forms.ListBox lbLicneNekretnine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azurirajPravneZastupnikeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem dodajNekretnineToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}