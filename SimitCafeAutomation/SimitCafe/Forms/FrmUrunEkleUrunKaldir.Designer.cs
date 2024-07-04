namespace SimitCafe.Forms
{
    partial class FrmUrunEkleUrunKaldir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunEkleUrunKaldir));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnAltaKatla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbxUrunAdiEkle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUrunFiyatiEkle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTarihEkle = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblSonucEkle = new System.Windows.Forms.Label();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.lblSonucKaldir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxUrunNoKaldir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMasaNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.nupAdet = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxToplamFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panelTop.Controls.Add(this.btnIleri);
            this.panelTop.Controls.Add(this.btnGeriDon);
            this.panelTop.Controls.Add(this.btnAltaKatla);
            this.panelTop.Controls.Add(this.btnKapat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1006, 29);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.Transparent;
            this.btnIleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIleri.FlatAppearance.BorderSize = 0;
            this.btnIleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnIleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIleri.ForeColor = System.Drawing.Color.White;
            this.btnIleri.Location = new System.Drawing.Point(27, 0);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(27, 29);
            this.btnIleri.TabIndex = 90;
            this.btnIleri.Text = "→";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGeriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeriDon.ForeColor = System.Drawing.Color.White;
            this.btnGeriDon.Location = new System.Drawing.Point(0, 0);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(27, 29);
            this.btnGeriDon.TabIndex = 89;
            this.btnGeriDon.Text = "←";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnAltaKatla
            // 
            this.btnAltaKatla.BackColor = System.Drawing.Color.Transparent;
            this.btnAltaKatla.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAltaKatla.FlatAppearance.BorderSize = 0;
            this.btnAltaKatla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAltaKatla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAltaKatla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaKatla.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaKatla.ForeColor = System.Drawing.Color.White;
            this.btnAltaKatla.Location = new System.Drawing.Point(950, 0);
            this.btnAltaKatla.Name = "btnAltaKatla";
            this.btnAltaKatla.Size = new System.Drawing.Size(28, 29);
            this.btnAltaKatla.TabIndex = 4;
            this.btnAltaKatla.Text = "– ";
            this.btnAltaKatla.UseVisualStyleBackColor = false;
            this.btnAltaKatla.Click += new System.EventHandler(this.btnAltaKatla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(978, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 29);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panelLeft.Controls.Add(this.lblTarih);
            this.panelLeft.Controls.Add(this.lblSaat);
            this.panelLeft.Controls.Add(this.guna2Panel4);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 29);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(125, 601);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            this.panelLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseUp);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(23, 573);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(50, 16);
            this.lblTarih.TabIndex = 8;
            this.lblTarih.Text = "label3";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(41, 554);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(50, 16);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "label3";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Location = new System.Drawing.Point(126, 90);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel4.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(562, 29);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1, 630);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Kaldır";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Black;
            this.guna2Panel5.Location = new System.Drawing.Point(127, 102);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(1065, 1);
            this.guna2Panel5.TabIndex = 5;
            // 
            // tbxUrunAdiEkle
            // 
            this.tbxUrunAdiEkle.BorderColor = System.Drawing.Color.Black;
            this.tbxUrunAdiEkle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunAdiEkle.DefaultText = "";
            this.tbxUrunAdiEkle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunAdiEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunAdiEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunAdiEkle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunAdiEkle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunAdiEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunAdiEkle.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunAdiEkle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunAdiEkle.Location = new System.Drawing.Point(158, 260);
            this.tbxUrunAdiEkle.Name = "tbxUrunAdiEkle";
            this.tbxUrunAdiEkle.PasswordChar = '\0';
            this.tbxUrunAdiEkle.PlaceholderText = "";
            this.tbxUrunAdiEkle.SelectedText = "";
            this.tbxUrunAdiEkle.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunAdiEkle.TabIndex = 6;
            this.tbxUrunAdiEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunAdiEkle_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // tbxUrunFiyatiEkle
            // 
            this.tbxUrunFiyatiEkle.BorderColor = System.Drawing.Color.Black;
            this.tbxUrunFiyatiEkle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunFiyatiEkle.DefaultText = "";
            this.tbxUrunFiyatiEkle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunFiyatiEkle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunFiyatiEkle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunFiyatiEkle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunFiyatiEkle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunFiyatiEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunFiyatiEkle.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunFiyatiEkle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunFiyatiEkle.Location = new System.Drawing.Point(379, 161);
            this.tbxUrunFiyatiEkle.Name = "tbxUrunFiyatiEkle";
            this.tbxUrunFiyatiEkle.PasswordChar = '\0';
            this.tbxUrunFiyatiEkle.PlaceholderText = "";
            this.tbxUrunFiyatiEkle.SelectedText = "";
            this.tbxUrunFiyatiEkle.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunFiyatiEkle.TabIndex = 8;
            this.tbxUrunFiyatiEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunFiyatiEkle_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(377, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarih:";
            // 
            // dtpTarihEkle
            // 
            this.dtpTarihEkle.BackColor = System.Drawing.Color.Transparent;
            this.dtpTarihEkle.BorderThickness = 1;
            this.dtpTarihEkle.Checked = true;
            this.dtpTarihEkle.FillColor = System.Drawing.Color.White;
            this.dtpTarihEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpTarihEkle.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTarihEkle.Location = new System.Drawing.Point(379, 259);
            this.dtpTarihEkle.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTarihEkle.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTarihEkle.Name = "dtpTarihEkle";
            this.dtpTarihEkle.Size = new System.Drawing.Size(169, 20);
            this.dtpTarihEkle.TabIndex = 12;
            this.dtpTarihEkle.Value = new System.DateTime(2024, 6, 26, 16, 32, 44, 183);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.FlatAppearance.BorderSize = 2;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(249, 525);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(185, 40);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle.FlatAppearance.BorderSize = 2;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(249, 571);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(185, 40);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblSonucEkle
            // 
            this.lblSonucEkle.AutoSize = true;
            this.lblSonucEkle.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucEkle.ForeColor = System.Drawing.Color.Black;
            this.lblSonucEkle.Location = new System.Drawing.Point(245, 490);
            this.lblSonucEkle.Name = "lblSonucEkle";
            this.lblSonucEkle.Size = new System.Drawing.Size(60, 22);
            this.lblSonucEkle.TabIndex = 15;
            this.lblSonucEkle.Text = "label3";
            // 
            // btnTemizle2
            // 
            this.btnTemizle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTemizle2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle2.FlatAppearance.BorderSize = 2;
            this.btnTemizle2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTemizle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle2.ForeColor = System.Drawing.Color.White;
            this.btnTemizle2.Location = new System.Drawing.Point(31, 247);
            this.btnTemizle2.Name = "btnTemizle2";
            this.btnTemizle2.Size = new System.Drawing.Size(185, 40);
            this.btnTemizle2.TabIndex = 17;
            this.btnTemizle2.Text = "Temizle";
            this.btnTemizle2.UseVisualStyleBackColor = false;
            this.btnTemizle2.Click += new System.EventHandler(this.btnTemizle2_Click);
            // 
            // btnKaldir
            // 
            this.btnKaldir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKaldir.FlatAppearance.BorderSize = 2;
            this.btnKaldir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKaldir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaldir.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaldir.ForeColor = System.Drawing.Color.Black;
            this.btnKaldir.Location = new System.Drawing.Point(31, 201);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(185, 40);
            this.btnKaldir.TabIndex = 16;
            this.btnKaldir.Text = "Kaldır";
            this.btnKaldir.UseVisualStyleBackColor = true;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click);
            // 
            // lblSonucKaldir
            // 
            this.lblSonucKaldir.AutoSize = true;
            this.lblSonucKaldir.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucKaldir.ForeColor = System.Drawing.Color.Black;
            this.lblSonucKaldir.Location = new System.Drawing.Point(15, 129);
            this.lblSonucKaldir.Name = "lblSonucKaldir";
            this.lblSonucKaldir.Size = new System.Drawing.Size(60, 22);
            this.lblSonucKaldir.TabIndex = 24;
            this.lblSonucKaldir.Text = "label3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ürün No:";
            // 
            // tbxUrunNoKaldir
            // 
            this.tbxUrunNoKaldir.BorderColor = System.Drawing.Color.Black;
            this.tbxUrunNoKaldir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunNoKaldir.DefaultText = "";
            this.tbxUrunNoKaldir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunNoKaldir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunNoKaldir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunNoKaldir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunNoKaldir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunNoKaldir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunNoKaldir.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunNoKaldir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunNoKaldir.Location = new System.Drawing.Point(18, 45);
            this.tbxUrunNoKaldir.Name = "tbxUrunNoKaldir";
            this.tbxUrunNoKaldir.PasswordChar = '\0';
            this.tbxUrunNoKaldir.PlaceholderText = "";
            this.tbxUrunNoKaldir.SelectedText = "";
            this.tbxUrunNoKaldir.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunNoKaldir.TabIndex = 18;
            this.tbxUrunNoKaldir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunNoKaldir_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Masa No:";
            // 
            // tbxMasaNo
            // 
            this.tbxMasaNo.BorderColor = System.Drawing.Color.Black;
            this.tbxMasaNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMasaNo.DefaultText = "";
            this.tbxMasaNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMasaNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMasaNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMasaNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMasaNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMasaNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxMasaNo.ForeColor = System.Drawing.Color.Black;
            this.tbxMasaNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMasaNo.Location = new System.Drawing.Point(158, 162);
            this.tbxMasaNo.MaxLength = 10000;
            this.tbxMasaNo.Name = "tbxMasaNo";
            this.tbxMasaNo.PasswordChar = '\0';
            this.tbxMasaNo.PlaceholderText = "";
            this.tbxMasaNo.SelectedText = "";
            this.tbxMasaNo.Size = new System.Drawing.Size(169, 20);
            this.tbxMasaNo.TabIndex = 25;
            this.tbxMasaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMasaNo_KeyPress);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.tbxUrunNoKaldir);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.btnTemizle2);
            this.guna2GroupBox1.Controls.Add(this.btnKaldir);
            this.guna2GroupBox1.Controls.Add(this.lblSonucKaldir);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Location = new System.Drawing.Point(656, 324);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(247, 296);
            this.guna2GroupBox1.TabIndex = 28;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // nupAdet
            // 
            this.nupAdet.BackColor = System.Drawing.SystemColors.Control;
            this.nupAdet.BorderColor = System.Drawing.Color.Black;
            this.nupAdet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupAdet.FillColor = System.Drawing.Color.WhiteSmoke;
            this.nupAdet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nupAdet.Location = new System.Drawing.Point(381, 356);
            this.nupAdet.Name = "nupAdet";
            this.nupAdet.Size = new System.Drawing.Size(170, 23);
            this.nupAdet.TabIndex = 33;
            this.nupAdet.UpDownButtonFillColor = System.Drawing.Color.Transparent;
            this.nupAdet.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.nupAdet.ValueChanged += new System.EventHandler(this.nupAdet_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(375, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Adet:";
            // 
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.BackgroundColor = System.Drawing.Color.White;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(575, 110);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.Size = new System.Drawing.Size(421, 203);
            this.dgwListe.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Toplam Fiyat:";
            // 
            // tbxToplamFiyat
            // 
            this.tbxToplamFiyat.BorderColor = System.Drawing.Color.Black;
            this.tbxToplamFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxToplamFiyat.DefaultText = "";
            this.tbxToplamFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxToplamFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxToplamFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxToplamFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxToplamFiyat.Enabled = false;
            this.tbxToplamFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxToplamFiyat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxToplamFiyat.ForeColor = System.Drawing.Color.Black;
            this.tbxToplamFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxToplamFiyat.Location = new System.Drawing.Point(159, 356);
            this.tbxToplamFiyat.Name = "tbxToplamFiyat";
            this.tbxToplamFiyat.PasswordChar = '\0';
            this.tbxToplamFiyat.PlaceholderText = "";
            this.tbxToplamFiyat.SelectedText = "";
            this.tbxToplamFiyat.Size = new System.Drawing.Size(169, 20);
            this.tbxToplamFiyat.TabIndex = 37;
            // 
            // FrmUrunEkleUrunKaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 630);
            this.Controls.Add(this.tbxToplamFiyat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.nupAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxMasaNo);
            this.Controls.Add(this.lblSonucEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpTarihEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxUrunFiyatiEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxUrunAdiEkle);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunEkleUrunKaldir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.FrmUrunEkleUrunKaldir_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Button btnAltaKatla;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblSaat;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunAdiEkle;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunFiyatiEkle;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTarihEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblSonucEkle;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunNoKaldir;
        public System.Windows.Forms.Label lblSonucKaldir;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox tbxMasaNo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox tbxToplamFiyat;
    }
}