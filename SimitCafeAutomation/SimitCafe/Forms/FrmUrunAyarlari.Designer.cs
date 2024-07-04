namespace SimitCafe
{
    partial class FrmUrunAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunAyarlari));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnAltaKatla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnYeniUrunEskiUrun = new Guna.UI2.WinForms.Guna2Button();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenuEkleMenuKaldir = new Guna.UI2.WinForms.Guna2Button();
            this.btnMenuGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.btnGeriDon);
            this.panelTop.Controls.Add(this.btnAltaKatla);
            this.panelTop.Controls.Add(this.btnKapat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(502, 32);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
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
            this.btnGeriDon.Size = new System.Drawing.Size(27, 32);
            this.btnGeriDon.TabIndex = 108;
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
            this.btnAltaKatla.Location = new System.Drawing.Point(446, 0);
            this.btnAltaKatla.Name = "btnAltaKatla";
            this.btnAltaKatla.Size = new System.Drawing.Size(28, 32);
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
            this.btnKapat.Location = new System.Drawing.Point(474, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 32);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Animated = true;
            this.btnUrunGuncelle.BorderThickness = 1;
            this.btnUrunGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUrunGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUrunGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUrunGuncelle.FillColor = System.Drawing.Color.Transparent;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUrunGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(7, 60);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(180, 45);
            this.btnUrunGuncelle.TabIndex = 3;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnYeniUrunEskiUrun
            // 
            this.btnYeniUrunEskiUrun.Animated = true;
            this.btnYeniUrunEskiUrun.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniUrunEskiUrun.BorderThickness = 1;
            this.btnYeniUrunEskiUrun.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYeniUrunEskiUrun.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYeniUrunEskiUrun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYeniUrunEskiUrun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYeniUrunEskiUrun.FillColor = System.Drawing.Color.Transparent;
            this.btnYeniUrunEskiUrun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeniUrunEskiUrun.ForeColor = System.Drawing.Color.White;
            this.btnYeniUrunEskiUrun.Location = new System.Drawing.Point(7, 10);
            this.btnYeniUrunEskiUrun.Name = "btnYeniUrunEskiUrun";
            this.btnYeniUrunEskiUrun.Size = new System.Drawing.Size(180, 45);
            this.btnYeniUrunEskiUrun.TabIndex = 7;
            this.btnYeniUrunEskiUrun.Text = "Yeni Ürün / Ürün Kaldır";
            this.btnYeniUrunEskiUrun.Click += new System.EventHandler(this.btnYeniUrunEskiUrun_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(69)))), ((int)(((byte)(68)))));
            this.panelLeft.Controls.Add(this.btnMenuEkleMenuKaldir);
            this.panelLeft.Controls.Add(this.btnMenuGuncelle);
            this.panelLeft.Controls.Add(this.btnYeniUrunEskiUrun);
            this.panelLeft.Controls.Add(this.btnUrunGuncelle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 32);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(194, 285);
            this.panelLeft.TabIndex = 2;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            this.panelLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseMove);
            this.panelLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseUp);
            // 
            // btnMenuEkleMenuKaldir
            // 
            this.btnMenuEkleMenuKaldir.Animated = true;
            this.btnMenuEkleMenuKaldir.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuEkleMenuKaldir.BorderThickness = 1;
            this.btnMenuEkleMenuKaldir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuEkleMenuKaldir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuEkleMenuKaldir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenuEkleMenuKaldir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenuEkleMenuKaldir.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuEkleMenuKaldir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenuEkleMenuKaldir.ForeColor = System.Drawing.Color.White;
            this.btnMenuEkleMenuKaldir.Location = new System.Drawing.Point(7, 110);
            this.btnMenuEkleMenuKaldir.Name = "btnMenuEkleMenuKaldir";
            this.btnMenuEkleMenuKaldir.Size = new System.Drawing.Size(180, 45);
            this.btnMenuEkleMenuKaldir.TabIndex = 12;
            this.btnMenuEkleMenuKaldir.Text = "Yeni Menü / Menü Kaldır";
            this.btnMenuEkleMenuKaldir.Click += new System.EventHandler(this.btnMenuEkleMenuKaldir_Click);
            // 
            // btnMenuGuncelle
            // 
            this.btnMenuGuncelle.Animated = true;
            this.btnMenuGuncelle.BorderThickness = 1;
            this.btnMenuGuncelle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuGuncelle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenuGuncelle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenuGuncelle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenuGuncelle.FillColor = System.Drawing.Color.Transparent;
            this.btnMenuGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMenuGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnMenuGuncelle.Location = new System.Drawing.Point(7, 160);
            this.btnMenuGuncelle.Name = "btnMenuGuncelle";
            this.btnMenuGuncelle.Size = new System.Drawing.Size(180, 45);
            this.btnMenuGuncelle.TabIndex = 11;
            this.btnMenuGuncelle.Text = "Menü Güncelle";
            this.btnMenuGuncelle.Click += new System.EventHandler(this.btnMenuGuncelle_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(243, 96);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(201, 158);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FrmUrunAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 317);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUrunAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ayarları";
            this.panelTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnAltaKatla;
        private System.Windows.Forms.Button btnKapat;
        private Guna.UI2.WinForms.Guna2Button btnUrunGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnYeniUrunEskiUrun;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        public Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnMenuEkleMenuKaldir;
        private Guna.UI2.WinForms.Guna2Button btnMenuGuncelle;
    }
}