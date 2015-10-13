namespace PersonelTakip
{
    partial class KullanıcıGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıGiris));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtKulAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtParola = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.picStatic = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatic)).BeginInit();
            this.metroTile2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.txtKulAdi);
            this.metroTile1.Controls.Add(this.txtParola);
            this.metroTile1.Controls.Add(this.btnGiris);
            this.metroTile1.Controls.Add(this.metroLabel2);
            this.metroTile1.Controls.Add(this.metroLabel1);
            this.metroTile1.Controls.Add(this.picStatic);
            this.metroTile1.Location = new System.Drawing.Point(190, 84);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(356, 477);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.UseSelectable = true;
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.Lines = new string[0];
            this.txtKulAdi.Location = new System.Drawing.Point(95, 260);
            this.txtKulAdi.MaxLength = 32767;
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.PasswordChar = '\0';
            this.txtKulAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKulAdi.SelectedText = "";
            this.txtKulAdi.Size = new System.Drawing.Size(237, 23);
            this.txtKulAdi.TabIndex = 6;
            this.txtKulAdi.UseSelectable = true;
            this.txtKulAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKulAdi_KeyDown);
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Lines = new string[0];
            this.txtParola.Location = new System.Drawing.Point(95, 295);
            this.txtParola.MaxLength = 32767;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParola.SelectedText = "";
            this.txtParola.Size = new System.Drawing.Size(237, 23);
            this.txtParola.TabIndex = 5;
            this.txtParola.UseSelectable = true;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            // 
            // btnGiris
            // 
            this.btnGiris.Enabled = false;
            this.btnGiris.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGiris.Highlight = true;
            this.btnGiris.Location = new System.Drawing.Point(94, 324);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(238, 29);
            this.btnGiris.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseSelectable = true;
            this.btnGiris.UseStyleColors = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 299);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Şifre:";
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 265);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Kullanıcı Adı:";
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // picStatic
            // 
            this.picStatic.BackColor = System.Drawing.Color.Transparent;
            this.picStatic.Image = ((System.Drawing.Image)(resources.GetObject("picStatic.Image")));
            this.picStatic.Location = new System.Drawing.Point(111, 46);
            this.picStatic.Name = "picStatic";
            this.picStatic.Size = new System.Drawing.Size(149, 152);
            this.picStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatic.TabIndex = 0;
            this.picStatic.TabStop = false;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Controls.Add(this.metroLabel4);
            this.metroTile2.Controls.Add(this.metroLabel5);
            this.metroTile2.Controls.Add(this.metroLabel3);
            this.metroTile2.Location = new System.Drawing.Point(572, 181);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(176, 109);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(27, 32);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 15);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "BTİ Tarafından Yapılmıştır.";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.WrapToLine = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(70, 70);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 15);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "İletişim:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.WrapToLine = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(10, 51);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(150, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Tüm hakları saklıdır. 2014-2015";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.WrapToLine = true;
            // 
            // KullanıcıGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 567);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "KullanıcıGiris";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "OGM Personel Takip Giriş";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.KullanıcıGiris_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatic)).EndInit();
            this.metroTile2.ResumeLayout(false);
            this.metroTile2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox picStatic;
        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroTextBox txtKulAdi;
        private MetroFramework.Controls.MetroTextBox txtParola;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;

    }
}