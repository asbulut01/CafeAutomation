namespace SimitCafe.Forms
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPencereyiKucult = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSifremiGöster = new System.Windows.Forms.CheckBox();
            this.btnTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.btnPencereyiKucult);
            this.panelTop.Controls.Add(this.btnKapat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(389, 31);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // btnPencereyiKucult
            // 
            this.btnPencereyiKucult.BackColor = System.Drawing.Color.Transparent;
            this.btnPencereyiKucult.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPencereyiKucult.FlatAppearance.BorderSize = 0;
            this.btnPencereyiKucult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPencereyiKucult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPencereyiKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencereyiKucult.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPencereyiKucult.ForeColor = System.Drawing.Color.White;
            this.btnPencereyiKucult.Location = new System.Drawing.Point(341, 0);
            this.btnPencereyiKucult.Name = "btnPencereyiKucult";
            this.btnPencereyiKucult.Size = new System.Drawing.Size(24, 31);
            this.btnPencereyiKucult.TabIndex = 12;
            this.btnPencereyiKucult.Text = "– ";
            this.btnPencereyiKucult.UseVisualStyleBackColor = false;
            this.btnPencereyiKucult.Click += new System.EventHandler(this.btnPencereyiKucult_Click);
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
            this.btnKapat.Location = new System.Drawing.Point(365, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(24, 31);
            this.btnKapat.TabIndex = 11;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.cbxSifremiGöster);
            this.guna2GroupBox1.Controls.Add(this.btnTemizle);
            this.guna2GroupBox1.Controls.Add(this.btnGirisYap);
            this.guna2GroupBox1.Controls.Add(this.panel2);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Controls.Add(this.tbxSifre);
            this.guna2GroupBox1.Controls.Add(this.tbxKullaniciAdi);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(43, 54);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(300, 566);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2GroupBox1_MouseDown);
            this.guna2GroupBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2GroupBox1_MouseMove);
            this.guna2GroupBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2GroupBox1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giriş";
            // 
            // cbxSifremiGöster
            // 
            this.cbxSifremiGöster.AutoSize = true;
            this.cbxSifremiGöster.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSifremiGöster.ForeColor = System.Drawing.Color.White;
            this.cbxSifremiGöster.Location = new System.Drawing.Point(83, 421);
            this.cbxSifremiGöster.Name = "cbxSifremiGöster";
            this.cbxSifremiGöster.Size = new System.Drawing.Size(118, 21);
            this.cbxSifremiGöster.TabIndex = 9;
            this.cbxSifremiGöster.Text = "Şifremi Göster";
            this.cbxSifremiGöster.UseVisualStyleBackColor = true;
            this.cbxSifremiGöster.CheckedChanged += new System.EventHandler(this.cbxSifremiGöster_CheckedChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BorderColor = System.Drawing.Color.White;
            this.btnTemizle.BorderThickness = 1;
            this.btnTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTemizle.FillColor = System.Drawing.Color.Transparent;
            this.btnTemizle.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnTemizle.Location = new System.Drawing.Point(55, 499);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.Size = new System.Drawing.Size(180, 45);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BorderColor = System.Drawing.Color.White;
            this.btnGirisYap.BorderThickness = 1;
            this.btnGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGirisYap.FillColor = System.Drawing.Color.Transparent;
            this.btnGirisYap.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.White;
            this.btnGirisYap.HoverState.FillColor = System.Drawing.Color.Gray;
            this.btnGirisYap.Location = new System.Drawing.Point(55, 448);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGirisYap.Size = new System.Drawing.Size(180, 45);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(37, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(36, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 4;
            // 
            // tbxSifre
            // 
            this.tbxSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            this.tbxSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSifre.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSifre.ForeColor = System.Drawing.Color.White;
            this.tbxSifre.Location = new System.Drawing.Point(36, 318);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(238, 16);
            this.tbxSifre.TabIndex = 3;
            this.tbxSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSifre_KeyPress);
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            this.tbxKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxKullaniciAdi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(36, 196);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(238, 16);
            this.tbxKullaniciAdi.TabIndex = 2;
            this.tbxKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxKullaniciAdi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(389, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmAdminGiris_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAdminGiris_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAdminGiris_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAdminGiris_MouseUp);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTemizle;
        private Guna.UI2.WinForms.Guna2Button btnGirisYap;
        private System.Windows.Forms.Button btnPencereyiKucult;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxSifremiGöster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}