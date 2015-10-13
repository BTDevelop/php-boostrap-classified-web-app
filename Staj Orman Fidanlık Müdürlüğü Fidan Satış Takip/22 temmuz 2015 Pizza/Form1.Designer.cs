namespace Fidan_Satis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grpKisisel = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAdres = new MetroFramework.Controls.MetroTextBox();
            this.txtAdSoyad = new MetroFramework.Controls.MetroTextBox();
            this.grpUrunTur = new MetroFramework.Controls.MetroTile();
            this.rbtnKayin = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnKaraAgac = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnCam = new MetroFramework.Controls.MetroRadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEk = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbYas = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnGoster = new MetroFramework.Controls.MetroButton();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.txtToplamFiyat = new MetroFramework.Controls.MetroTextBox();
            this.txtBirimFiyat = new MetroFramework.Controls.MetroTextBox();
            this.chcEkleme = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btnTumSil = new MetroFramework.Controls.MetroButton();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cmbAraTur = new MetroFramework.Controls.MetroComboBox();
            this.txtAra = new MetroFramework.Controls.MetroTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpKisisel.SuspendLayout();
            this.grpUrunTur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "20-Free-Tree-PNG-Images.png");
            this.ımageList1.Images.SetKeyName(1, "20-Free-Tree-PNG-Images-Platycladus-orientalis.png");
            this.ımageList1.Images.SetKeyName(2, "20-Free-Tree-PNG-Images-Mahogani05L.png");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // grpKisisel
            // 
            this.grpKisisel.ActiveControl = null;
            this.grpKisisel.Controls.Add(this.metroLabel2);
            this.grpKisisel.Controls.Add(this.metroLabel1);
            this.grpKisisel.Controls.Add(this.txtAdres);
            this.grpKisisel.Controls.Add(this.txtAdSoyad);
            this.grpKisisel.Location = new System.Drawing.Point(12, 89);
            this.grpKisisel.Name = "grpKisisel";
            this.grpKisisel.Size = new System.Drawing.Size(580, 119);
            this.grpKisisel.Style = MetroFramework.MetroColorStyle.Green;
            this.grpKisisel.TabIndex = 7;
            this.grpKisisel.Text = "Müşteri Bilgileri";
            this.grpKisisel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.grpKisisel.TileCount = 1;
            this.grpKisisel.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grpKisisel.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Ad Soyad:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Lines = new string[0];
            this.txtAdres.Location = new System.Drawing.Point(116, 53);
            this.txtAdres.MaxLength = 32767;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.PasswordChar = '\0';
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdres.SelectedText = "";
            this.txtAdres.Size = new System.Drawing.Size(389, 51);
            this.txtAdres.TabIndex = 1;
            this.txtAdres.UseSelectable = true;
            this.txtAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Lines = new string[0];
            this.txtAdSoyad.Location = new System.Drawing.Point(116, 23);
            this.txtAdSoyad.MaxLength = 32767;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PasswordChar = '\0';
            this.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdSoyad.SelectedText = "";
            this.txtAdSoyad.Size = new System.Drawing.Size(389, 23);
            this.txtAdSoyad.TabIndex = 0;
            this.txtAdSoyad.UseSelectable = true;
            this.txtAdSoyad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdSoyad_KeyDown);
            // 
            // grpUrunTur
            // 
            this.grpUrunTur.ActiveControl = null;
            this.grpUrunTur.Controls.Add(this.rbtnKayin);
            this.grpUrunTur.Controls.Add(this.rbtnKaraAgac);
            this.grpUrunTur.Controls.Add(this.rbtnCam);
            this.grpUrunTur.Controls.Add(this.pictureBox1);
            this.grpUrunTur.Location = new System.Drawing.Point(12, 214);
            this.grpUrunTur.Name = "grpUrunTur";
            this.grpUrunTur.Size = new System.Drawing.Size(580, 203);
            this.grpUrunTur.Style = MetroFramework.MetroColorStyle.Green;
            this.grpUrunTur.TabIndex = 7;
            this.grpUrunTur.Text = "Depodaki Fidanlar";
            this.grpUrunTur.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.grpUrunTur.TileCount = 2;
            this.grpUrunTur.UseSelectable = true;
            // 
            // rbtnKayin
            // 
            this.rbtnKayin.AutoSize = true;
            this.rbtnKayin.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbtnKayin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnKayin.Location = new System.Drawing.Point(12, 72);
            this.rbtnKayin.Name = "rbtnKayin";
            this.rbtnKayin.Size = new System.Drawing.Size(79, 15);
            this.rbtnKayin.Style = MetroFramework.MetroColorStyle.Green;
            this.rbtnKayin.TabIndex = 3;
            this.rbtnKayin.Text = "Kayın Ağacı";
            this.rbtnKayin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbtnKayin.UseCustomForeColor = true;
            this.rbtnKayin.UseSelectable = true;
            this.rbtnKayin.CheckedChanged += new System.EventHandler(this.rbtnKayin_CheckedChanged);
            // 
            // rbtnKaraAgac
            // 
            this.rbtnKaraAgac.AutoSize = true;
            this.rbtnKaraAgac.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbtnKaraAgac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnKaraAgac.Location = new System.Drawing.Point(12, 49);
            this.rbtnKaraAgac.Name = "rbtnKaraAgac";
            this.rbtnKaraAgac.Size = new System.Drawing.Size(74, 15);
            this.rbtnKaraAgac.Style = MetroFramework.MetroColorStyle.Green;
            this.rbtnKaraAgac.TabIndex = 2;
            this.rbtnKaraAgac.Text = "Kara Ağaç";
            this.rbtnKaraAgac.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbtnKaraAgac.UseCustomForeColor = true;
            this.rbtnKaraAgac.UseSelectable = true;
            this.rbtnKaraAgac.CheckedChanged += new System.EventHandler(this.rbtnKaraAgac_CheckedChanged);
            // 
            // rbtnCam
            // 
            this.rbtnCam.AutoSize = true;
            this.rbtnCam.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbtnCam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnCam.Location = new System.Drawing.Point(12, 27);
            this.rbtnCam.Name = "rbtnCam";
            this.rbtnCam.Size = new System.Drawing.Size(77, 15);
            this.rbtnCam.Style = MetroFramework.MetroColorStyle.Green;
            this.rbtnCam.TabIndex = 1;
            this.rbtnCam.Text = "Çam Ağacı";
            this.rbtnCam.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rbtnCam.UseCustomForeColor = true;
            this.rbtnCam.UseSelectable = true;
            this.rbtnCam.CheckedChanged += new System.EventHandler(this.rbtnCam_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grpEk
            // 
            this.grpEk.ActiveControl = null;
            this.grpEk.Controls.Add(this.metroLabel6);
            this.grpEk.Controls.Add(this.metroLabel5);
            this.grpEk.Controls.Add(this.metroLabel4);
            this.grpEk.Controls.Add(this.metroLabel3);
            this.grpEk.Controls.Add(this.cmbYas);
            this.grpEk.Controls.Add(this.metroButton1);
            this.grpEk.Controls.Add(this.btnGoster);
            this.grpEk.Controls.Add(this.nmrAdet);
            this.grpEk.Controls.Add(this.txtToplamFiyat);
            this.grpEk.Controls.Add(this.txtBirimFiyat);
            this.grpEk.Controls.Add(this.chcEkleme);
            this.grpEk.Location = new System.Drawing.Point(12, 423);
            this.grpEk.Name = "grpEk";
            this.grpEk.Size = new System.Drawing.Size(580, 345);
            this.grpEk.Style = MetroFramework.MetroColorStyle.Green;
            this.grpEk.TabIndex = 7;
            this.grpEk.Text = "Depodaki Orman Ürünleri";
            this.grpEk.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.grpEk.TileCount = 3;
            this.grpEk.UseSelectable = true;
            this.grpEk.Click += new System.EventHandler(this.grpEk_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 122);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Adet:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(21, 95);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Toplam Fiyat:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 65);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(74, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Birim Fiyat:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 39);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Ağaç Yaşı:";
            // 
            // cmbYas
            // 
            this.cmbYas.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbYas.FormattingEnabled = true;
            this.cmbYas.ItemHeight = 19;
            this.cmbYas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbYas.Location = new System.Drawing.Point(156, 34);
            this.cmbYas.Name = "cmbYas";
            this.cmbYas.Size = new System.Drawing.Size(191, 25);
            this.cmbYas.TabIndex = 7;
            this.cmbYas.UseSelectable = true;
            this.cmbYas.SelectedIndexChanged += new System.EventHandler(this.cmbYas_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(411, 105);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(120, 36);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Yeni Kayıt Ekle";
            this.metroButton1.UseSelectable = true;
            // 
            // btnGoster
            // 
            this.btnGoster.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGoster.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnGoster.Highlight = true;
            this.btnGoster.Location = new System.Drawing.Point(411, 65);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(120, 34);
            this.btnGoster.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGoster.TabIndex = 5;
            this.btnGoster.Text = "Kayıt Ekle";
            this.btnGoster.UseSelectable = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(156, 121);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(191, 20);
            this.nmrAdet.TabIndex = 4;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.ValueChanged += new System.EventHandler(this.nmrAdet_ValueChanged);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Lines = new string[0];
            this.txtToplamFiyat.Location = new System.Drawing.Point(156, 91);
            this.txtToplamFiyat.MaxLength = 32767;
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.PasswordChar = '\0';
            this.txtToplamFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToplamFiyat.SelectedText = "";
            this.txtToplamFiyat.Size = new System.Drawing.Size(191, 23);
            this.txtToplamFiyat.TabIndex = 3;
            this.txtToplamFiyat.UseSelectable = true;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Lines = new string[0];
            this.txtBirimFiyat.Location = new System.Drawing.Point(156, 61);
            this.txtBirimFiyat.MaxLength = 32767;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.PasswordChar = '\0';
            this.txtBirimFiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBirimFiyat.SelectedText = "";
            this.txtBirimFiyat.Size = new System.Drawing.Size(191, 23);
            this.txtBirimFiyat.TabIndex = 2;
            this.txtBirimFiyat.UseSelectable = true;
            // 
            // chcEkleme
            // 
            this.chcEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(163)))), ((int)(((byte)(73)))));
            this.chcEkleme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chcEkleme.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chcEkleme.ForeColor = System.Drawing.SystemColors.Info;
            this.chcEkleme.FormattingEnabled = true;
            this.chcEkleme.Items.AddRange(new object[] {
            "Çam Ağaç Tohumu",
            "Kara Ağaç Tohumu",
            "Kayın Ağacı Tohumu"});
            this.chcEkleme.Location = new System.Drawing.Point(0, 200);
            this.chcEkleme.Name = "chcEkleme";
            this.chcEkleme.Size = new System.Drawing.Size(581, 136);
            this.chcEkleme.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.ActiveControl = null;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.btnTumSil);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.cmbAraTur);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(599, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 679);
            this.groupBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.groupBox1.TabIndex = 8;
            this.groupBox1.Text = "Faturalama";
            this.groupBox1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.groupBox1.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Fidan_Satis.Properties.Resources.image_logo;
            this.pictureBox2.Location = new System.Drawing.Point(68, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroLabel8);
            this.metroTile1.Controls.Add(this.metroLabel7);
            this.metroTile1.Location = new System.Drawing.Point(333, 484);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(282, 65);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 9;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(57, 36);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(185, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Tüm Hakları Saklıdır 2014-2015";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(75, 11);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(155, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "BTİ Tarafından Yapılmıştır.";
            // 
            // metroButton5
            // 
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(333, 398);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(128, 35);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton5.TabIndex = 8;
            this.metroButton5.Text = "Fişi Yazdır";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(333, 439);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(128, 36);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton4.TabIndex = 7;
            this.metroButton4.Text = "Fişi Önizle";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.btnBaskiOnizleme_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(333, 352);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(128, 40);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Fiş Düzenle";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.btnSayfaAyarlari_Click);
            // 
            // btnTumSil
            // 
            this.btnTumSil.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTumSil.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnTumSil.Highlight = true;
            this.btnTumSil.Location = new System.Drawing.Point(333, 307);
            this.btnTumSil.Name = "btnTumSil";
            this.btnTumSil.Size = new System.Drawing.Size(128, 39);
            this.btnTumSil.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnTumSil.TabIndex = 5;
            this.btnTumSil.Text = "Tümünü Temizle";
            this.btnTumSil.UseSelectable = true;
            this.btnTumSil.Click += new System.EventHandler(this.btnTumSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSil.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSil.Highlight = true;
            this.btnSil.Location = new System.Drawing.Point(333, 258);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(128, 43);
            this.btnSil.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Seç Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(16, 258);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(311, 43);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Ara";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cmbAraTur
            // 
            this.cmbAraTur.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbAraTur.FormattingEnabled = true;
            this.cmbAraTur.ItemHeight = 19;
            this.cmbAraTur.Items.AddRange(new object[] {
            "Ad Soyad",
            "Adres",
            "Ağaç Türü"});
            this.cmbAraTur.Location = new System.Drawing.Point(184, 229);
            this.cmbAraTur.Name = "cmbAraTur";
            this.cmbAraTur.Size = new System.Drawing.Size(143, 25);
            this.cmbAraTur.TabIndex = 2;
            this.cmbAraTur.UseSelectable = true;
            this.cmbAraTur.SelectedIndexChanged += new System.EventHandler(this.cmbAraTur_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Lines = new string[0];
            this.txtAra.Location = new System.Drawing.Point(16, 229);
            this.txtAra.MaxLength = 32767;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAra.SelectedText = "";
            this.txtAra.Size = new System.Drawing.Size(162, 23);
            this.txtAra.TabIndex = 1;
            this.txtAra.UseSelectable = true;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(16, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(582, 200);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackMaxSize = 100;
            this.ClientSize = new System.Drawing.Size(1231, 772);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpEk);
            this.Controls.Add(this.grpUrunTur);
            this.Controls.Add(this.grpKisisel);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "    Erzurum Orman Findanlık Müdürlüğü Fidan Satışı";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKisisel.ResumeLayout(false);
            this.grpKisisel.PerformLayout();
            this.grpUrunTur.ResumeLayout(false);
            this.grpUrunTur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEk.ResumeLayout(false);
            this.grpEk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroTile grpKisisel;
        private MetroFramework.Controls.MetroTextBox txtAdres;
        private MetroFramework.Controls.MetroTextBox txtAdSoyad;
        private MetroFramework.Controls.MetroTile grpUrunTur;
        private MetroFramework.Controls.MetroRadioButton rbtnKayin;
        private MetroFramework.Controls.MetroRadioButton rbtnKaraAgac;
        private MetroFramework.Controls.MetroRadioButton rbtnCam;
        private MetroFramework.Controls.MetroTile grpEk;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnGoster;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private MetroFramework.Controls.MetroTextBox txtBirimFiyat;
        private MetroFramework.Controls.MetroTile groupBox1;
        private MetroFramework.Controls.MetroButton btnTumSil;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cmbAraTur;
        private MetroFramework.Controls.MetroTextBox txtAra;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroComboBox cmbYas;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtToplamFiyat;
        private System.Windows.Forms.CheckedListBox chcEkleme;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

