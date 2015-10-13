namespace PersonelTakip
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl = new MetroFramework.Controls.MetroPanel();
            this.pnlIstatistik = new MetroFramework.Controls.MetroPanel();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.lstbxkisiler = new System.Windows.Forms.ListBox();
            this.chrtKisiler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picStatic_2 = new System.Windows.Forms.PictureBox();
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.picStatic = new System.Windows.Forms.PictureBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.btnGrafik = new MetroFramework.Controls.MetroButton();
            this.btnAktar = new MetroFramework.Controls.MetroButton();
            this.btnAnaliz = new MetroFramework.Controls.MetroButton();
            this.btnDosyaAc = new MetroFramework.Controls.MetroButton();
            this.txtDosyaYol = new MetroFramework.Controls.MetroTextBox();
            this.prgYuklen = new MetroFramework.Controls.MetroProgressSpinner();
            this.tmrProg = new System.Windows.Forms.Timer(this.components);
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.lblSayac = new MetroFramework.Controls.MetroLabel();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnl.SuspendLayout();
            this.pnlIstatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtKisiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.metroTile1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatic)).BeginInit();
            this.metroTile2.SuspendLayout();
            this.metroTile3.SuspendLayout();
            this.metroTile7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.pnlIstatistik);
            this.pnl.Controls.Add(this.picStatic_2);
            this.pnl.Controls.Add(this.dgwPersonel);
            this.pnl.HorizontalScrollbarBarColor = true;
            this.pnl.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl.HorizontalScrollbarSize = 10;
            this.pnl.Location = new System.Drawing.Point(299, 275);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1042, 490);
            this.pnl.Style = MetroFramework.MetroColorStyle.Green;
            this.pnl.TabIndex = 0;
            this.pnl.UseStyleColors = true;
            this.pnl.VerticalScrollbarBarColor = true;
            this.pnl.VerticalScrollbarHighlightOnWheel = false;
            this.pnl.VerticalScrollbarSize = 10;
            // 
            // pnlIstatistik
            // 
            this.pnlIstatistik.BackColor = System.Drawing.Color.White;
            this.pnlIstatistik.Controls.Add(this.metroTile8);
            this.pnlIstatistik.Controls.Add(this.metroTile6);
            this.pnlIstatistik.Controls.Add(this.metroTile5);
            this.pnlIstatistik.Controls.Add(this.lstbxkisiler);
            this.pnlIstatistik.Controls.Add(this.chrtKisiler);
            this.pnlIstatistik.HorizontalScrollbarBarColor = true;
            this.pnlIstatistik.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlIstatistik.HorizontalScrollbarSize = 10;
            this.pnlIstatistik.Location = new System.Drawing.Point(0, 0);
            this.pnlIstatistik.Name = "pnlIstatistik";
            this.pnlIstatistik.Size = new System.Drawing.Size(1042, 490);
            this.pnlIstatistik.TabIndex = 6;
            this.pnlIstatistik.UseCustomBackColor = true;
            this.pnlIstatistik.VerticalScrollbarBarColor = true;
            this.pnlIstatistik.VerticalScrollbarHighlightOnWheel = false;
            this.pnlIstatistik.VerticalScrollbarSize = 10;
            this.pnlIstatistik.Visible = false;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(550, 418);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(492, 28);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile8.TabIndex = 7;
            this.metroTile8.Text = "Grafikte Sabah Giriş/Sabah Çıkış ve Öğle Giriş/Akşam Çıkış 4 dönem toplamı listel" +
    "enmiştir.";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile8.UseSelectable = true;
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(532, 28);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(510, 28);
            this.metroTile6.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile6.TabIndex = 7;
            this.metroTile6.Text = "Çalışma Grafiği";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(0, 28);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(507, 28);
            this.metroTile5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Text = "Personel Listesi";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile5.UseSelectable = true;
            // 
            // lstbxkisiler
            // 
            this.lstbxkisiler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxkisiler.FormattingEnabled = true;
            this.lstbxkisiler.Location = new System.Drawing.Point(5, 74);
            this.lstbxkisiler.Name = "lstbxkisiler";
            this.lstbxkisiler.Size = new System.Drawing.Size(502, 403);
            this.lstbxkisiler.TabIndex = 6;
            this.lstbxkisiler.SelectedIndexChanged += new System.EventHandler(this.lstbxkisiler_SelectedIndexChanged);
            // 
            // chrtKisiler
            // 
            this.chrtKisiler.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Plaid;
            chartArea1.Name = "ChartArea1";
            this.chrtKisiler.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtKisiler.Legends.Add(legend1);
            this.chrtKisiler.Location = new System.Drawing.Point(585, 70);
            this.chrtKisiler.Name = "chrtKisiler";
            this.chrtKisiler.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtKisiler.Series.Add(series1);
            this.chrtKisiler.Size = new System.Drawing.Size(382, 296);
            this.chrtKisiler.TabIndex = 5;
            this.chrtKisiler.Text = "chart1";
            // 
            // picStatic_2
            // 
            this.picStatic_2.Image = ((System.Drawing.Image)(resources.GetObject("picStatic_2.Image")));
            this.picStatic_2.Location = new System.Drawing.Point(411, 28);
            this.picStatic_2.Name = "picStatic_2";
            this.picStatic_2.Size = new System.Drawing.Size(294, 311);
            this.picStatic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatic_2.TabIndex = 6;
            this.picStatic_2.TabStop = false;
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.AllowUserToAddRows = false;
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPersonel.Location = new System.Drawing.Point(0, 0);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.Size = new System.Drawing.Size(1042, 490);
            this.dgwPersonel.TabIndex = 5;
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "Örnek";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.picStatic);
            this.metroTile1.Location = new System.Drawing.Point(74, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(219, 167);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 1;
            this.metroTile1.UseSelectable = true;
            // 
            // picStatic
            // 
            this.picStatic.BackColor = System.Drawing.Color.Transparent;
            this.picStatic.Image = ((System.Drawing.Image)(resources.GetObject("picStatic.Image")));
            this.picStatic.Location = new System.Drawing.Point(32, 3);
            this.picStatic.Name = "picStatic";
            this.picStatic.Size = new System.Drawing.Size(160, 155);
            this.picStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatic.TabIndex = 0;
            this.picStatic.TabStop = false;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Controls.Add(this.btnGrafik);
            this.metroTile2.Controls.Add(this.btnAktar);
            this.metroTile2.Controls.Add(this.btnAnaliz);
            this.metroTile2.Controls.Add(this.btnDosyaAc);
            this.metroTile2.Controls.Add(this.txtDosyaYol);
            this.metroTile2.Controls.Add(this.prgYuklen);
            this.metroTile2.Location = new System.Drawing.Point(74, 177);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(219, 319);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.UseSelectable = true;
            // 
            // btnGrafik
            // 
            this.btnGrafik.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGrafik.Highlight = true;
            this.btnGrafik.Location = new System.Drawing.Point(4, 147);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(212, 35);
            this.btnGrafik.Style = MetroFramework.MetroColorStyle.Green;
            this.btnGrafik.TabIndex = 8;
            this.btnGrafik.Text = "Kişi Çalışma Grafiği Çıkar";
            this.btnGrafik.UseSelectable = true;
            this.btnGrafik.UseStyleColors = true;
            this.btnGrafik.Visible = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAktar.Highlight = true;
            this.btnAktar.Location = new System.Drawing.Point(4, 113);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(212, 28);
            this.btnAktar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAktar.TabIndex = 7;
            this.btnAktar.Text = "Analizleri Excel\'e Aktar";
            this.btnAktar.UseSelectable = true;
            this.btnAktar.UseStyleColors = true;
            this.btnAktar.Visible = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAnaliz.Highlight = true;
            this.btnAnaliz.Location = new System.Drawing.Point(4, 83);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(212, 28);
            this.btnAnaliz.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAnaliz.TabIndex = 6;
            this.btnAnaliz.Text = "Analiz Et";
            this.btnAnaliz.UseSelectable = true;
            this.btnAnaliz.UseStyleColors = true;
            this.btnAnaliz.Visible = false;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDosyaAc.Highlight = true;
            this.btnDosyaAc.Location = new System.Drawing.Point(4, 53);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(212, 28);
            this.btnDosyaAc.Style = MetroFramework.MetroColorStyle.Green;
            this.btnDosyaAc.TabIndex = 5;
            this.btnDosyaAc.Text = "Dosya Yükle";
            this.btnDosyaAc.UseSelectable = true;
            this.btnDosyaAc.UseStyleColors = true;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Enabled = false;
            this.txtDosyaYol.Lines = new string[0];
            this.txtDosyaYol.Location = new System.Drawing.Point(4, 25);
            this.txtDosyaYol.MaxLength = 32767;
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.PasswordChar = '\0';
            this.txtDosyaYol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDosyaYol.SelectedText = "";
            this.txtDosyaYol.Size = new System.Drawing.Size(212, 23);
            this.txtDosyaYol.Style = MetroFramework.MetroColorStyle.Green;
            this.txtDosyaYol.TabIndex = 4;
            this.txtDosyaYol.UseSelectable = true;
            this.txtDosyaYol.UseStyleColors = true;
            // 
            // prgYuklen
            // 
            this.prgYuklen.Location = new System.Drawing.Point(97, 241);
            this.prgYuklen.Maximum = 100;
            this.prgYuklen.Name = "prgYuklen";
            this.prgYuklen.Size = new System.Drawing.Size(25, 25);
            this.prgYuklen.Style = MetroFramework.MetroColorStyle.Yellow;
            this.prgYuklen.TabIndex = 3;
            this.prgYuklen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.prgYuklen.UseSelectable = true;
            // 
            // tmrProg
            // 
            this.tmrProg.Tick += new System.EventHandler(this.tmrProg_Tick);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Controls.Add(this.lblSayac);
            this.metroTile3.Location = new System.Drawing.Point(1141, 168);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(254, 52);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.UseSelectable = true;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSayac.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSayac.Location = new System.Drawing.Point(9, 14);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 0);
            this.lblSayac.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lblSayac.TabIndex = 0;
            this.lblSayac.UseCustomForeColor = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(74, 168);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(219, 10);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile4.TabIndex = 4;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Controls.Add(this.metroLabel4);
            this.metroTile7.Controls.Add(this.metroLabel5);
            this.metroTile7.Controls.Add(this.metroLabel3);
            this.metroTile7.Location = new System.Drawing.Point(-4, 587);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(181, 109);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile7.TabIndex = 5;
            this.metroTile7.UseSelectable = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 772);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1378, 780);
            this.MinimumSize = new System.Drawing.Size(1364, 736);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl.ResumeLayout(false);
            this.pnlIstatistik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtKisiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.metroTile1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStatic)).EndInit();
            this.metroTile2.ResumeLayout(false);
            this.metroTile3.ResumeLayout(false);
            this.metroTile3.PerformLayout();
            this.metroTile7.ResumeLayout(false);
            this.metroTile7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnl;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.DataGridView dgwPersonel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.PictureBox picStatic;
        private MetroFramework.Controls.MetroProgressSpinner prgYuklen;
        private System.Windows.Forms.Timer tmrProg;
        private System.Windows.Forms.PictureBox picStatic_2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel lblSayac;
        private MetroFramework.Controls.MetroButton btnAktar;
        private MetroFramework.Controls.MetroButton btnAnaliz;
        private MetroFramework.Controls.MetroButton btnDosyaAc;
        private MetroFramework.Controls.MetroTextBox txtDosyaYol;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtKisiler;
        private MetroFramework.Controls.MetroPanel pnlIstatistik;
        private System.Windows.Forms.ListBox lstbxkisiler;
        private MetroFramework.Controls.MetroButton btnGrafik;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

