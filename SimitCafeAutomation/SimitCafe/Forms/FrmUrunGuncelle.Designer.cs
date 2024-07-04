namespace SimitCafe.Forms
{
    partial class FrmUrunGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunGuncelle));
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnAltaKatla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblGuncelleMetin = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYeniUrunFiyati = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxYeniUrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrunNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTemizleMenu = new System.Windows.Forms.Button();
            this.btnMenuGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMenuAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMenuNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxMenuFiyati = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMenuSonuc = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panelLeft.Controls.Add(this.lblTarih);
            this.panelLeft.Controls.Add(this.lblSaat);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 29);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(125, 627);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            this.panelLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseUp);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(20, 596);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(50, 16);
            this.lblTarih.TabIndex = 10;
            this.lblTarih.Text = "label3";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(37, 577);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(50, 16);
            this.lblSaat.TabIndex = 9;
            this.lblSaat.Text = "label3";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.panelTop.Controls.Add(this.btnGeriDon);
            this.panelTop.Controls.Add(this.btnAltaKatla);
            this.panelTop.Controls.Add(this.btnKapat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1184, 29);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
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
            this.btnGeriDon.TabIndex = 92;
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
            this.btnAltaKatla.Location = new System.Drawing.Point(1128, 0);
            this.btnAltaKatla.Name = "btnAltaKatla";
            this.btnAltaKatla.Size = new System.Drawing.Size(28, 29);
            this.btnAltaKatla.TabIndex = 91;
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
            this.btnKapat.Location = new System.Drawing.Point(1156, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 29);
            this.btnKapat.TabIndex = 90;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblGuncelleMetin
            // 
            this.lblGuncelleMetin.AutoSize = true;
            this.lblGuncelleMetin.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuncelleMetin.Location = new System.Drawing.Point(158, 49);
            this.lblGuncelleMetin.Name = "lblGuncelleMetin";
            this.lblGuncelleMetin.Size = new System.Drawing.Size(239, 37);
            this.lblGuncelleMetin.TabIndex = 5;
            this.lblGuncelleMetin.Text = "Ürünleri Güncelle";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Black;
            this.guna2Panel4.Location = new System.Drawing.Point(421, 29);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1, 628);
            this.guna2Panel4.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ürün Fiyatı (Yeni):";
            // 
            // tbxYeniUrunFiyati
            // 
            this.tbxYeniUrunFiyati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxYeniUrunFiyati.DefaultText = "";
            this.tbxYeniUrunFiyati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxYeniUrunFiyati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxYeniUrunFiyati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxYeniUrunFiyati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxYeniUrunFiyati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxYeniUrunFiyati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxYeniUrunFiyati.ForeColor = System.Drawing.Color.Black;
            this.tbxYeniUrunFiyati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxYeniUrunFiyati.Location = new System.Drawing.Point(39, 263);
            this.tbxYeniUrunFiyati.Name = "tbxYeniUrunFiyati";
            this.tbxYeniUrunFiyati.PasswordChar = '\0';
            this.tbxYeniUrunFiyati.PlaceholderText = "";
            this.tbxYeniUrunFiyati.SelectedText = "";
            this.tbxYeniUrunFiyati.Size = new System.Drawing.Size(169, 20);
            this.tbxYeniUrunFiyati.TabIndex = 28;
            this.tbxYeniUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxYeniUrunFiyati_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ürün Adı (Yeni):";
            // 
            // tbxYeniUrunAdi
            // 
            this.tbxYeniUrunAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxYeniUrunAdi.DefaultText = "";
            this.tbxYeniUrunAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxYeniUrunAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxYeniUrunAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxYeniUrunAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxYeniUrunAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxYeniUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxYeniUrunAdi.ForeColor = System.Drawing.Color.Black;
            this.tbxYeniUrunAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxYeniUrunAdi.Location = new System.Drawing.Point(39, 171);
            this.tbxYeniUrunAdi.Name = "tbxYeniUrunAdi";
            this.tbxYeniUrunAdi.PasswordChar = '\0';
            this.tbxYeniUrunAdi.PlaceholderText = "";
            this.tbxYeniUrunAdi.SelectedText = "";
            this.tbxYeniUrunAdi.Size = new System.Drawing.Size(169, 20);
            this.tbxYeniUrunAdi.TabIndex = 26;
            this.tbxYeniUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxYeniUrunAdi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ürün No:";
            // 
            // tbxUrunNo
            // 
            this.tbxUrunNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunNo.DefaultText = "";
            this.tbxUrunNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunNo.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunNo.Location = new System.Drawing.Point(39, 85);
            this.tbxUrunNo.Name = "tbxUrunNo";
            this.tbxUrunNo.PasswordChar = '\0';
            this.tbxUrunNo.PlaceholderText = "";
            this.tbxUrunNo.SelectedText = "";
            this.tbxUrunNo.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunNo.TabIndex = 31;
            this.tbxUrunNo.TextChanged += new System.EventHandler(this.tbxUrunNo_TextChanged);
            this.tbxUrunNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunNo_KeyPress);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.tbxYeniUrunAdi);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.tbxUrunNo);
            this.guna2GroupBox1.Controls.Add(this.tbxYeniUrunFiyati);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Location = new System.Drawing.Point(151, 116);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(250, 353);
            this.guna2GroupBox1.TabIndex = 38;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.BackgroundColor = System.Drawing.Color.White;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(458, 49);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.Size = new System.Drawing.Size(714, 203);
            this.dgwListe.TabIndex = 37;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuncelle.FlatAppearance.BorderSize = 2;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(191, 560);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(185, 40);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle.FlatAppearance.BorderSize = 2;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(190, 605);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(185, 40);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(139, 494);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(69, 28);
            this.lblSonuc.TabIndex = 30;
            this.lblSonuc.Text = "Sonuç";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(421, 266);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(763, 1);
            this.guna2Panel1.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(808, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "Menüyü Güncelle";
            // 
            // dgwMenu
            // 
            this.dgwMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(709, 333);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.Size = new System.Drawing.Size(467, 232);
            this.dgwMenu.TabIndex = 41;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnTemizleMenu);
            this.guna2GroupBox2.Controls.Add(this.btnMenuGuncelle);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.tbxMenuAdi);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.tbxMenuNo);
            this.guna2GroupBox2.Controls.Add(this.tbxMenuFiyati);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Location = new System.Drawing.Point(449, 277);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(250, 379);
            this.guna2GroupBox2.TabIndex = 42;
            this.guna2GroupBox2.Text = "guna2GroupBox2";
            // 
            // btnTemizleMenu
            // 
            this.btnTemizleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnTemizleMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTemizleMenu.FlatAppearance.BorderSize = 2;
            this.btnTemizleMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizleMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTemizleMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizleMenu.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizleMenu.ForeColor = System.Drawing.Color.White;
            this.btnTemizleMenu.Location = new System.Drawing.Point(24, 328);
            this.btnTemizleMenu.Name = "btnTemizleMenu";
            this.btnTemizleMenu.Size = new System.Drawing.Size(185, 40);
            this.btnTemizleMenu.TabIndex = 34;
            this.btnTemizleMenu.Text = "Temizle";
            this.btnTemizleMenu.UseVisualStyleBackColor = false;
            this.btnTemizleMenu.Click += new System.EventHandler(this.btnTemizleMenu_Click);
            // 
            // btnMenuGuncelle
            // 
            this.btnMenuGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMenuGuncelle.FlatAppearance.BorderSize = 2;
            this.btnMenuGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMenuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGuncelle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnMenuGuncelle.Location = new System.Drawing.Point(25, 283);
            this.btnMenuGuncelle.Name = "btnMenuGuncelle";
            this.btnMenuGuncelle.Size = new System.Drawing.Size(185, 40);
            this.btnMenuGuncelle.TabIndex = 33;
            this.btnMenuGuncelle.Text = "Güncelle";
            this.btnMenuGuncelle.UseVisualStyleBackColor = true;
            this.btnMenuGuncelle.Click += new System.EventHandler(this.btnMenuGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ürün Fiyatı (Yeni):";
            // 
            // tbxMenuAdi
            // 
            this.tbxMenuAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMenuAdi.DefaultText = "";
            this.tbxMenuAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMenuAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMenuAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxMenuAdi.ForeColor = System.Drawing.Color.Black;
            this.tbxMenuAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuAdi.Location = new System.Drawing.Point(36, 135);
            this.tbxMenuAdi.Name = "tbxMenuAdi";
            this.tbxMenuAdi.PasswordChar = '\0';
            this.tbxMenuAdi.PlaceholderText = "";
            this.tbxMenuAdi.SelectedText = "";
            this.tbxMenuAdi.Size = new System.Drawing.Size(169, 20);
            this.tbxMenuAdi.TabIndex = 26;
            this.tbxMenuAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMenuAdi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ürün No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ürün Adı (Yeni):";
            // 
            // tbxMenuNo
            // 
            this.tbxMenuNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMenuNo.DefaultText = "";
            this.tbxMenuNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMenuNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMenuNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxMenuNo.ForeColor = System.Drawing.Color.Black;
            this.tbxMenuNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuNo.Location = new System.Drawing.Point(36, 49);
            this.tbxMenuNo.Name = "tbxMenuNo";
            this.tbxMenuNo.PasswordChar = '\0';
            this.tbxMenuNo.PlaceholderText = "";
            this.tbxMenuNo.SelectedText = "";
            this.tbxMenuNo.Size = new System.Drawing.Size(169, 20);
            this.tbxMenuNo.TabIndex = 31;
            this.tbxMenuNo.TextChanged += new System.EventHandler(this.tbxMenuNo_TextChanged);
            this.tbxMenuNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMenuNo_KeyPress);
            // 
            // tbxMenuFiyati
            // 
            this.tbxMenuFiyati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMenuFiyati.DefaultText = "";
            this.tbxMenuFiyati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxMenuFiyati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxMenuFiyati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuFiyati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxMenuFiyati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuFiyati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxMenuFiyati.ForeColor = System.Drawing.Color.Black;
            this.tbxMenuFiyati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxMenuFiyati.Location = new System.Drawing.Point(36, 227);
            this.tbxMenuFiyati.Name = "tbxMenuFiyati";
            this.tbxMenuFiyati.PasswordChar = '\0';
            this.tbxMenuFiyati.PlaceholderText = "";
            this.tbxMenuFiyati.SelectedText = "";
            this.tbxMenuFiyati.Size = new System.Drawing.Size(169, 20);
            this.tbxMenuFiyati.TabIndex = 28;
            this.tbxMenuFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMenuFiyati_KeyPress);
            // 
            // lblMenuSonuc
            // 
            this.lblMenuSonuc.AutoSize = true;
            this.lblMenuSonuc.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblMenuSonuc.Location = new System.Drawing.Point(716, 600);
            this.lblMenuSonuc.Name = "lblMenuSonuc";
            this.lblMenuSonuc.Size = new System.Drawing.Size(69, 28);
            this.lblMenuSonuc.TabIndex = 35;
            this.lblMenuSonuc.Text = "Sonuç";
            // 
            // FrmUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 656);
            this.Controls.Add(this.lblMenuSonuc);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.dgwMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblGuncelleMetin);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncelleme İşlemi";
            this.Load += new System.EventHandler(this.FrmUrunGuncelle_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnAltaKatla;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblGuncelleMetin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbxYeniUrunFiyati;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbxYeniUrunAdi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunNo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblSonuc;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwMenu;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbxMenuAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbxMenuNo;
        private Guna.UI2.WinForms.Guna2TextBox tbxMenuFiyati;
        private System.Windows.Forms.Button btnTemizleMenu;
        private System.Windows.Forms.Button btnMenuGuncelle;
        private System.Windows.Forms.Label lblMenuSonuc;
    }
}