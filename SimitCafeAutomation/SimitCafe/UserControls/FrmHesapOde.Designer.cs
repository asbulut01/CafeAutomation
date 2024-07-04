namespace SimitCafe.UserControls
{
    partial class FrmHesapOde
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbxKalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tbxVerilenKredi = new System.Windows.Forms.TextBox();
            this.tbxOdenecekKredi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMasaNo = new System.Windows.Forms.TextBox();
            this.btnKrediTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnKrediOnayla = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.tbxParaUstu = new System.Windows.Forms.TextBox();
            this.tbxVerilenNakit = new System.Windows.Forms.TextBox();
            this.tbxOdenecekNakit = new System.Windows.Forms.TextBox();
            this.tbxMasaNo2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNakitTemizle = new Guna.UI2.WinForms.Guna2Button();
            this.btnParaUstuAl = new Guna.UI2.WinForms.Guna2Button();
            this.btnNakitOnayla = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.tbxKalan);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.lblSonuc);
            this.groupBox.Controls.Add(this.tbxVerilenKredi);
            this.groupBox.Controls.Add(this.tbxOdenecekKredi);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.tbxMasaNo);
            this.groupBox.Controls.Add(this.btnKrediTemizle);
            this.groupBox.Controls.Add(this.btnKrediOnayla);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.CustomBorderColor = System.Drawing.Color.Transparent;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox.Location = new System.Drawing.Point(14, 102);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(274, 430);
            this.groupBox.TabIndex = 0;
            this.groupBox.Text = "guna2GroupBox1";
            // 
            // tbxKalan
            // 
            this.tbxKalan.Enabled = false;
            this.tbxKalan.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKalan.Location = new System.Drawing.Point(96, 182);
            this.tbxKalan.Name = "tbxKalan";
            this.tbxKalan.Size = new System.Drawing.Size(164, 23);
            this.tbxKalan.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(50, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kalan:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc.Location = new System.Drawing.Point(21, 260);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(64, 25);
            this.lblSonuc.TabIndex = 21;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.Visible = false;
            // 
            // tbxVerilenKredi
            // 
            this.tbxVerilenKredi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVerilenKredi.Location = new System.Drawing.Point(96, 140);
            this.tbxVerilenKredi.Name = "tbxVerilenKredi";
            this.tbxVerilenKredi.Size = new System.Drawing.Size(164, 23);
            this.tbxVerilenKredi.TabIndex = 20;
            this.tbxVerilenKredi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVerilenKredi_KeyPress);
            // 
            // tbxOdenecekKredi
            // 
            this.tbxOdenecekKredi.Enabled = false;
            this.tbxOdenecekKredi.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOdenecekKredi.Location = new System.Drawing.Point(96, 97);
            this.tbxOdenecekKredi.Name = "tbxOdenecekKredi";
            this.tbxOdenecekKredi.Size = new System.Drawing.Size(164, 23);
            this.tbxOdenecekKredi.TabIndex = 6;
            this.tbxOdenecekKredi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOdenecekKredi_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(33, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Masa No:";
            // 
            // tbxMasaNo
            // 
            this.tbxMasaNo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMasaNo.Location = new System.Drawing.Point(96, 52);
            this.tbxMasaNo.Name = "tbxMasaNo";
            this.tbxMasaNo.Size = new System.Drawing.Size(164, 23);
            this.tbxMasaNo.TabIndex = 5;
            this.tbxMasaNo.TextChanged += new System.EventHandler(this.tbxMasaNo_TextChanged_1);
            this.tbxMasaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMasaNo_KeyPress);
            // 
            // btnKrediTemizle
            // 
            this.btnKrediTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKrediTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKrediTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKrediTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKrediTemizle.FillColor = System.Drawing.Color.Black;
            this.btnKrediTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKrediTemizle.ForeColor = System.Drawing.Color.White;
            this.btnKrediTemizle.Location = new System.Drawing.Point(53, 382);
            this.btnKrediTemizle.Name = "btnKrediTemizle";
            this.btnKrediTemizle.Size = new System.Drawing.Size(180, 45);
            this.btnKrediTemizle.TabIndex = 17;
            this.btnKrediTemizle.Text = "Temizle";
            this.btnKrediTemizle.Click += new System.EventHandler(this.btnKrediTemizle_Click);
            // 
            // btnKrediOnayla
            // 
            this.btnKrediOnayla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKrediOnayla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKrediOnayla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKrediOnayla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKrediOnayla.FillColor = System.Drawing.Color.Black;
            this.btnKrediOnayla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKrediOnayla.ForeColor = System.Drawing.Color.White;
            this.btnKrediOnayla.Location = new System.Drawing.Point(53, 335);
            this.btnKrediOnayla.Name = "btnKrediOnayla";
            this.btnKrediOnayla.Size = new System.Drawing.Size(180, 45);
            this.btnKrediOnayla.TabIndex = 15;
            this.btnKrediOnayla.Text = "Onayla";
            this.btnKrediOnayla.Click += new System.EventHandler(this.btnKrediOnayla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ödenecek:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Verilen Para:";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.lblSonuc2);
            this.guna2GroupBox2.Controls.Add(this.tbxParaUstu);
            this.guna2GroupBox2.Controls.Add(this.tbxVerilenNakit);
            this.guna2GroupBox2.Controls.Add(this.tbxOdenecekNakit);
            this.guna2GroupBox2.Controls.Add(this.tbxMasaNo2);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.btnNakitTemizle);
            this.guna2GroupBox2.Controls.Add(this.btnParaUstuAl);
            this.guna2GroupBox2.Controls.Add(this.btnNakitOnayla);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Location = new System.Drawing.Point(294, 102);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(274, 430);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "guna2GroupBox2";
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc2.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc2.ForeColor = System.Drawing.Color.Black;
            this.lblSonuc2.Location = new System.Drawing.Point(19, 244);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(64, 25);
            this.lblSonuc2.TabIndex = 26;
            this.lblSonuc2.Text = "Sonuç";
            this.lblSonuc2.Visible = false;
            // 
            // tbxParaUstu
            // 
            this.tbxParaUstu.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxParaUstu.Location = new System.Drawing.Point(96, 188);
            this.tbxParaUstu.Name = "tbxParaUstu";
            this.tbxParaUstu.ReadOnly = true;
            this.tbxParaUstu.Size = new System.Drawing.Size(164, 23);
            this.tbxParaUstu.TabIndex = 25;
            // 
            // tbxVerilenNakit
            // 
            this.tbxVerilenNakit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVerilenNakit.Location = new System.Drawing.Point(96, 137);
            this.tbxVerilenNakit.Name = "tbxVerilenNakit";
            this.tbxVerilenNakit.Size = new System.Drawing.Size(164, 23);
            this.tbxVerilenNakit.TabIndex = 24;
            this.tbxVerilenNakit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVerilenNakit_KeyPress);
            // 
            // tbxOdenecekNakit
            // 
            this.tbxOdenecekNakit.Enabled = false;
            this.tbxOdenecekNakit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOdenecekNakit.Location = new System.Drawing.Point(96, 94);
            this.tbxOdenecekNakit.Name = "tbxOdenecekNakit";
            this.tbxOdenecekNakit.Size = new System.Drawing.Size(164, 23);
            this.tbxOdenecekNakit.TabIndex = 23;
            this.tbxOdenecekNakit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxOdenecekNakit_KeyPress);
            // 
            // tbxMasaNo2
            // 
            this.tbxMasaNo2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMasaNo2.Location = new System.Drawing.Point(96, 49);
            this.tbxMasaNo2.Name = "tbxMasaNo2";
            this.tbxMasaNo2.Size = new System.Drawing.Size(164, 23);
            this.tbxMasaNo2.TabIndex = 22;
            this.tbxMasaNo2.TextChanged += new System.EventHandler(this.tbxMasaNo2_TextChanged);
            this.tbxMasaNo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMasaNo2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(30, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Masa No:";
            // 
            // btnNakitTemizle
            // 
            this.btnNakitTemizle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNakitTemizle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNakitTemizle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNakitTemizle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNakitTemizle.FillColor = System.Drawing.Color.Black;
            this.btnNakitTemizle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNakitTemizle.ForeColor = System.Drawing.Color.White;
            this.btnNakitTemizle.Location = new System.Drawing.Point(54, 382);
            this.btnNakitTemizle.Name = "btnNakitTemizle";
            this.btnNakitTemizle.Size = new System.Drawing.Size(180, 45);
            this.btnNakitTemizle.TabIndex = 8;
            this.btnNakitTemizle.Text = "Temizle";
            this.btnNakitTemizle.Click += new System.EventHandler(this.btnNakitTemizle_Click);
            // 
            // btnParaUstuAl
            // 
            this.btnParaUstuAl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParaUstuAl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParaUstuAl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParaUstuAl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParaUstuAl.FillColor = System.Drawing.Color.Black;
            this.btnParaUstuAl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnParaUstuAl.ForeColor = System.Drawing.Color.White;
            this.btnParaUstuAl.Location = new System.Drawing.Point(54, 334);
            this.btnParaUstuAl.Name = "btnParaUstuAl";
            this.btnParaUstuAl.Size = new System.Drawing.Size(180, 45);
            this.btnParaUstuAl.TabIndex = 7;
            this.btnParaUstuAl.Text = "Para Üstünü Al";
            this.btnParaUstuAl.Click += new System.EventHandler(this.btnParaUstuAl_Click);
            // 
            // btnNakitOnayla
            // 
            this.btnNakitOnayla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNakitOnayla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNakitOnayla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNakitOnayla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNakitOnayla.FillColor = System.Drawing.Color.Black;
            this.btnNakitOnayla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNakitOnayla.ForeColor = System.Drawing.Color.White;
            this.btnNakitOnayla.Location = new System.Drawing.Point(54, 286);
            this.btnNakitOnayla.Name = "btnNakitOnayla";
            this.btnNakitOnayla.Size = new System.Drawing.Size(180, 45);
            this.btnNakitOnayla.TabIndex = 6;
            this.btnNakitOnayla.Text = "Onayla";
            this.btnNakitOnayla.Click += new System.EventHandler(this.btnNakitOnayla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Para Üstü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ödenecek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Verilen Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kredi Kartı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nakit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "/";
            // 
            // FrmHesapOde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.groupBox);
            this.Name = "FrmHesapOde";
            this.Size = new System.Drawing.Size(578, 535);
            this.Load += new System.EventHandler(this.FrmHesapOde_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnNakitTemizle;
        private Guna.UI2.WinForms.Guna2Button btnParaUstuAl;
        private Guna.UI2.WinForms.Guna2Button btnNakitOnayla;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnKrediTemizle;
        private Guna.UI2.WinForms.Guna2Button btnKrediOnayla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxMasaNo;
        private System.Windows.Forms.TextBox tbxOdenecekKredi;
        private System.Windows.Forms.TextBox tbxVerilenKredi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonuc2;
        private System.Windows.Forms.TextBox tbxParaUstu;
        private System.Windows.Forms.TextBox tbxVerilenNakit;
        private System.Windows.Forms.TextBox tbxOdenecekNakit;
        private System.Windows.Forms.TextBox tbxMasaNo2;
        private System.Windows.Forms.TextBox tbxKalan;
        private System.Windows.Forms.Label label11;
    }
}
