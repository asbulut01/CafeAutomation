namespace SimitCafe.Forms
{
    partial class FrmMenuEkleMenuKaldir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEkleMenuKaldir));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnAltaKatla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbxUrunNoKaldir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTemizle2 = new System.Windows.Forms.Button();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.lblSonucKaldir = new System.Windows.Forms.Label();
            this.lblSonucEkle = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUrunFiyati = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUrunAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(1006, 29);
            this.panelTop.TabIndex = 1;
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
            this.btnAltaKatla.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
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
            this.panelLeft.TabIndex = 2;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            this.panelLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseUp);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(20, 571);
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
            this.lblSaat.Location = new System.Drawing.Point(38, 552);
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
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.BackgroundColor = System.Drawing.Color.White;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(573, 116);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.Size = new System.Drawing.Size(421, 203);
            this.dgwListe.TabIndex = 53;
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
            this.guna2GroupBox1.Location = new System.Drawing.Point(654, 330);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(247, 296);
            this.guna2GroupBox1.TabIndex = 50;
            this.guna2GroupBox1.Text = "guna2GroupBox1";
            // 
            // tbxUrunNoKaldir
            // 
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
            this.btnTemizle2.Location = new System.Drawing.Point(31, 240);
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
            this.btnKaldir.Location = new System.Drawing.Point(31, 194);
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
            // lblSonucEkle
            // 
            this.lblSonucEkle.AutoSize = true;
            this.lblSonucEkle.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucEkle.ForeColor = System.Drawing.Color.Black;
            this.lblSonucEkle.Location = new System.Drawing.Point(223, 489);
            this.lblSonucEkle.Name = "lblSonucEkle";
            this.lblSonucEkle.Size = new System.Drawing.Size(60, 22);
            this.lblSonucEkle.TabIndex = 47;
            this.lblSonucEkle.Text = "label3";
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
            this.btnTemizle.Location = new System.Drawing.Point(236, 571);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(185, 40);
            this.btnTemizle.TabIndex = 46;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.FlatAppearance.BorderSize = 2;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(236, 525);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(185, 40);
            this.btnEkle.TabIndex = 45;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Black;
            this.guna2Panel5.Location = new System.Drawing.Point(125, 108);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(885, 1);
            this.guna2Panel5.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Menü Kaldır";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Menü Ekle";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(561, 35);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1, 630);
            this.guna2Panel3.TabIndex = 35;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.tbxUrunFiyati);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.tbxUrunAdi);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(182, 141);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(300, 275);
            this.guna2GroupBox2.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // tbxUrunFiyati
            // 
            this.tbxUrunFiyati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunFiyati.DefaultText = "";
            this.tbxUrunFiyati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunFiyati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunFiyati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunFiyati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunFiyati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunFiyati.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunFiyati.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunFiyati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunFiyati.Location = new System.Drawing.Point(66, 179);
            this.tbxUrunFiyati.Name = "tbxUrunFiyati";
            this.tbxUrunFiyati.PasswordChar = '\0';
            this.tbxUrunFiyati.PlaceholderText = "";
            this.tbxUrunFiyati.SelectedText = "";
            this.tbxUrunFiyati.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunFiyati.TabIndex = 52;
            this.tbxUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunFiyati_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ürün Adı:";
            // 
            // tbxUrunAdi
            // 
            this.tbxUrunAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxUrunAdi.DefaultText = "";
            this.tbxUrunAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxUrunAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxUrunAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxUrunAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbxUrunAdi.ForeColor = System.Drawing.Color.Black;
            this.tbxUrunAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxUrunAdi.Location = new System.Drawing.Point(66, 89);
            this.tbxUrunAdi.Name = "tbxUrunAdi";
            this.tbxUrunAdi.PasswordChar = '\0';
            this.tbxUrunAdi.PlaceholderText = "";
            this.tbxUrunAdi.SelectedText = "";
            this.tbxUrunAdi.Size = new System.Drawing.Size(169, 20);
            this.tbxUrunAdi.TabIndex = 50;
            this.tbxUrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUrunAdi_KeyPress);
            // 
            // FrmMenuEkleMenuKaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 630);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.lblSonucEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuEkleMenuKaldir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü İşlemleri";
            this.Load += new System.EventHandler(this.FrmMenuEkleMenuKaldir_Load);
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnAltaKatla;
        private System.Windows.Forms.Button btnKapat;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.DataGridView dgwListe;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunNoKaldir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTemizle2;
        private System.Windows.Forms.Button btnKaldir;
        public System.Windows.Forms.Label lblSonucKaldir;
        private System.Windows.Forms.Label lblSonucEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunFiyati;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbxUrunAdi;
    }
}