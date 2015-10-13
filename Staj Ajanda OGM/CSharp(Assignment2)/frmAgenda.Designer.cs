namespace CSharp_Assignment2_
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBoxStatic = new System.Windows.Forms.PictureBox();
            this.takvim = new System.Windows.Forms.MonthCalendar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timerT = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSatA = new System.Windows.Forms.TextBox();
            this.txtSatM = new System.Windows.Forms.TextBox();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblThurs = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblTues = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFriA = new System.Windows.Forms.TextBox();
            this.txtThursA = new System.Windows.Forms.TextBox();
            this.txtWedA = new System.Windows.Forms.TextBox();
            this.txtTuesA = new System.Windows.Forms.TextBox();
            this.txtMonA = new System.Windows.Forms.TextBox();
            this.txtFriM = new System.Windows.Forms.TextBox();
            this.txtThursM = new System.Windows.Forms.TextBox();
            this.txtWedM = new System.Windows.Forms.TextBox();
            this.txtTuesM = new System.Windows.Forms.TextBox();
            this.txtMonM = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.picBoxStatic);
            this.groupBox1.Controls.Add(this.takvim);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takvim";
            // 
            // picBoxStatic
            // 
            this.picBoxStatic.Image = ((System.Drawing.Image)(resources.GetObject("picBoxStatic.Image")));
            this.picBoxStatic.Location = new System.Drawing.Point(26, 246);
            this.picBoxStatic.Name = "picBoxStatic";
            this.picBoxStatic.Size = new System.Drawing.Size(204, 193);
            this.picBoxStatic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxStatic.TabIndex = 1;
            this.picBoxStatic.TabStop = false;
            // 
            // takvim
            // 
            this.takvim.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.takvim.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.takvim.ForeColor = System.Drawing.Color.LimeGreen;
            this.takvim.Location = new System.Drawing.Point(9, 19);
            this.takvim.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.takvim.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.takvim.Name = "takvim";
            this.takvim.TabIndex = 0;
            this.takvim.TitleBackColor = System.Drawing.Color.LawnGreen;
            this.takvim.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.takvim.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.takvim.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.takvim_DateChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.Location = new System.Drawing.Point(554, 594);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.Location = new System.Drawing.Point(710, 594);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 28);
            this.txtSearch.TabIndex = 14;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrevious.Location = new System.Drawing.Point(554, 529);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(150, 28);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Geri";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(828, 529);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 28);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "İleri";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timerT
            // 
            this.timerT.Interval = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.txtSatA);
            this.groupBox2.Controls.Add(this.txtSatM);
            this.groupBox2.Controls.Add(this.lblSat);
            this.groupBox2.Controls.Add(this.lblFri);
            this.groupBox2.Controls.Add(this.lblThurs);
            this.groupBox2.Controls.Add(this.lblWed);
            this.groupBox2.Controls.Add(this.lblTues);
            this.groupBox2.Controls.Add(this.lblMon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtFriA);
            this.groupBox2.Controls.Add(this.txtThursA);
            this.groupBox2.Controls.Add(this.txtWedA);
            this.groupBox2.Controls.Add(this.txtTuesA);
            this.groupBox2.Controls.Add(this.txtMonA);
            this.groupBox2.Controls.Add(this.txtFriM);
            this.groupBox2.Controls.Add(this.txtThursM);
            this.groupBox2.Controls.Add(this.txtWedM);
            this.groupBox2.Controls.Add(this.txtTuesM);
            this.groupBox2.Controls.Add(this.txtMonM);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(277, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(981, 473);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haftalık Ajanda";
            // 
            // txtSatA
            // 
            this.txtSatA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtSatA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSatA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatA.Location = new System.Drawing.Point(791, 243);
            this.txtSatA.MaxLength = 300;
            this.txtSatA.Multiline = true;
            this.txtSatA.Name = "txtSatA";
            this.txtSatA.Size = new System.Drawing.Size(124, 196);
            this.txtSatA.TabIndex = 12;
            this.txtSatA.Enter += new System.EventHandler(this.txtSatA_Enter);
            this.txtSatA.Leave += new System.EventHandler(this.txtSatA_Leave);
            // 
            // txtSatM
            // 
            this.txtSatM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtSatM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSatM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatM.Location = new System.Drawing.Point(791, 41);
            this.txtSatM.MaxLength = 300;
            this.txtSatM.Multiline = true;
            this.txtSatM.Name = "txtSatM";
            this.txtSatM.Size = new System.Drawing.Size(124, 196);
            this.txtSatM.TabIndex = 6;
            this.txtSatM.Enter += new System.EventHandler(this.txtSatM_Enter);
            this.txtSatM.Leave += new System.EventHandler(this.txtSatM_Leave);
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSat.ForeColor = System.Drawing.Color.White;
            this.lblSat.Location = new System.Drawing.Point(788, 25);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(68, 17);
            this.lblSat.TabIndex = 11;
            this.lblSat.Text = "Cumartesi";
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFri.ForeColor = System.Drawing.Color.White;
            this.lblFri.Location = new System.Drawing.Point(646, 25);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(43, 17);
            this.lblFri.TabIndex = 11;
            this.lblFri.Text = "Cuma";
            // 
            // lblThurs
            // 
            this.lblThurs.AutoSize = true;
            this.lblThurs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThurs.ForeColor = System.Drawing.Color.White;
            this.lblThurs.Location = new System.Drawing.Point(504, 25);
            this.lblThurs.Name = "lblThurs";
            this.lblThurs.Size = new System.Drawing.Size(67, 17);
            this.lblThurs.TabIndex = 11;
            this.lblThurs.Text = "Perşembe";
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWed.ForeColor = System.Drawing.Color.White;
            this.lblWed.Location = new System.Drawing.Point(362, 25);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(69, 17);
            this.lblWed.TabIndex = 11;
            this.lblWed.Text = "Çarşamba";
            // 
            // lblTues
            // 
            this.lblTues.AutoSize = true;
            this.lblTues.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTues.ForeColor = System.Drawing.Color.White;
            this.lblTues.Location = new System.Drawing.Point(220, 25);
            this.lblTues.Name = "lblTues";
            this.lblTues.Size = new System.Drawing.Size(29, 17);
            this.lblTues.TabIndex = 11;
            this.lblTues.Text = "Salı";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMon.ForeColor = System.Drawing.Color.White;
            this.lblMon.Location = new System.Drawing.Point(78, 25);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(61, 17);
            this.lblMon.TabIndex = 11;
            this.lblMon.Text = "Pazartesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "18:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "12:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "13:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "9:00";
            // 
            // txtFriA
            // 
            this.txtFriA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtFriA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFriA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriA.Location = new System.Drawing.Point(649, 243);
            this.txtFriA.MaxLength = 300;
            this.txtFriA.Multiline = true;
            this.txtFriA.Name = "txtFriA";
            this.txtFriA.Size = new System.Drawing.Size(124, 196);
            this.txtFriA.TabIndex = 11;
            this.txtFriA.Enter += new System.EventHandler(this.txtFriA_Enter);
            this.txtFriA.Leave += new System.EventHandler(this.txtFriA_Leave);
            // 
            // txtThursA
            // 
            this.txtThursA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtThursA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThursA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThursA.Location = new System.Drawing.Point(508, 243);
            this.txtThursA.MaxLength = 300;
            this.txtThursA.Multiline = true;
            this.txtThursA.Name = "txtThursA";
            this.txtThursA.Size = new System.Drawing.Size(124, 196);
            this.txtThursA.TabIndex = 10;
            this.txtThursA.Enter += new System.EventHandler(this.txtThursA_Enter);
            this.txtThursA.Leave += new System.EventHandler(this.txtThursA_Leave);
            // 
            // txtWedA
            // 
            this.txtWedA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtWedA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWedA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWedA.Location = new System.Drawing.Point(367, 243);
            this.txtWedA.MaxLength = 300;
            this.txtWedA.Multiline = true;
            this.txtWedA.Name = "txtWedA";
            this.txtWedA.Size = new System.Drawing.Size(124, 196);
            this.txtWedA.TabIndex = 9;
            this.txtWedA.Enter += new System.EventHandler(this.txtWedA_Enter);
            this.txtWedA.Leave += new System.EventHandler(this.txtWedA_Leave);
            // 
            // txtTuesA
            // 
            this.txtTuesA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtTuesA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuesA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuesA.Location = new System.Drawing.Point(223, 243);
            this.txtTuesA.MaxLength = 300;
            this.txtTuesA.Multiline = true;
            this.txtTuesA.Name = "txtTuesA";
            this.txtTuesA.Size = new System.Drawing.Size(124, 196);
            this.txtTuesA.TabIndex = 8;
            this.txtTuesA.Enter += new System.EventHandler(this.txtTuesA_Enter);
            this.txtTuesA.Leave += new System.EventHandler(this.txtTuesA_Leave);
            // 
            // txtMonA
            // 
            this.txtMonA.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtMonA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonA.Location = new System.Drawing.Point(81, 243);
            this.txtMonA.MaxLength = 300;
            this.txtMonA.Multiline = true;
            this.txtMonA.Name = "txtMonA";
            this.txtMonA.Size = new System.Drawing.Size(124, 196);
            this.txtMonA.TabIndex = 7;
            this.txtMonA.Enter += new System.EventHandler(this.txtMonA_Enter);
            this.txtMonA.Leave += new System.EventHandler(this.txtMonA_Leave);
            // 
            // txtFriM
            // 
            this.txtFriM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtFriM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFriM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFriM.Location = new System.Drawing.Point(649, 41);
            this.txtFriM.MaxLength = 300;
            this.txtFriM.Multiline = true;
            this.txtFriM.Name = "txtFriM";
            this.txtFriM.Size = new System.Drawing.Size(124, 196);
            this.txtFriM.TabIndex = 5;
            this.txtFriM.Enter += new System.EventHandler(this.txtFriM_Enter);
            this.txtFriM.Leave += new System.EventHandler(this.txtFriM_Leave);
            // 
            // txtThursM
            // 
            this.txtThursM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtThursM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThursM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThursM.Location = new System.Drawing.Point(507, 41);
            this.txtThursM.MaxLength = 300;
            this.txtThursM.Multiline = true;
            this.txtThursM.Name = "txtThursM";
            this.txtThursM.Size = new System.Drawing.Size(124, 196);
            this.txtThursM.TabIndex = 4;
            this.txtThursM.Enter += new System.EventHandler(this.txtThursM_Enter);
            this.txtThursM.Leave += new System.EventHandler(this.txtThursM_Leave);
            // 
            // txtWedM
            // 
            this.txtWedM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtWedM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWedM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWedM.Location = new System.Drawing.Point(365, 41);
            this.txtWedM.MaxLength = 300;
            this.txtWedM.Multiline = true;
            this.txtWedM.Name = "txtWedM";
            this.txtWedM.Size = new System.Drawing.Size(124, 196);
            this.txtWedM.TabIndex = 3;
            this.txtWedM.Enter += new System.EventHandler(this.txtWedM_Enter);
            this.txtWedM.Leave += new System.EventHandler(this.txtWedM_Leave);
            // 
            // txtTuesM
            // 
            this.txtTuesM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtTuesM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuesM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuesM.Location = new System.Drawing.Point(223, 41);
            this.txtTuesM.MaxLength = 300;
            this.txtTuesM.Multiline = true;
            this.txtTuesM.Name = "txtTuesM";
            this.txtTuesM.Size = new System.Drawing.Size(124, 196);
            this.txtTuesM.TabIndex = 2;
            this.txtTuesM.Enter += new System.EventHandler(this.txtTuesM_Enter);
            this.txtTuesM.Leave += new System.EventHandler(this.txtTuesM_Leave);
            // 
            // txtMonM
            // 
            this.txtMonM.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtMonM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonM.Location = new System.Drawing.Point(81, 41);
            this.txtMonM.MaxLength = 300;
            this.txtMonM.Multiline = true;
            this.txtMonM.Name = "txtMonM";
            this.txtMonM.Size = new System.Drawing.Size(124, 196);
            this.txtMonM.TabIndex = 1;
            this.txtMonM.Enter += new System.EventHandler(this.txtMonM_Enter);
            this.txtMonM.Leave += new System.EventHandler(this.txtMonM_Leave);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.metroLabel1);
            this.metroTile1.Location = new System.Drawing.Point(999, 645);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(241, 117);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 20;
            this.metroTile1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.metroLabel1.Location = new System.Drawing.Point(35, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(173, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "BTİ Tarafından Geliştirilmiştir.";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(9, 193);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(233, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Kayıt Dosyasını Aç";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 706);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAgenda";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgenda_FormClosing);
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStatic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar takvim;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picBoxStatic;
        private System.Windows.Forms.Timer timerT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSatA;
        private System.Windows.Forms.TextBox txtSatM;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblThurs;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblTues;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFriA;
        private System.Windows.Forms.TextBox txtThursA;
        private System.Windows.Forms.TextBox txtWedA;
        private System.Windows.Forms.TextBox txtTuesA;
        private System.Windows.Forms.TextBox txtMonA;
        private System.Windows.Forms.TextBox txtFriM;
        private System.Windows.Forms.TextBox txtThursM;
        private System.Windows.Forms.TextBox txtWedM;
        private System.Windows.Forms.TextBox txtTuesM;
        private System.Windows.Forms.TextBox txtMonM;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

