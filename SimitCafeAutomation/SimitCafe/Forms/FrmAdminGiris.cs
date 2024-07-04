using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimitCafe.Forms
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private bool Mov;
        private Point point;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPencereyiKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxKullaniciAdi.Text = "";
            tbxSifre.Text = "";
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            tbxSifre.PasswordChar = '●';

            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = tbxKullaniciAdi.Text;
            string sifre = tbxSifre.Text;

            if (kullaniciAdi != "" && sifre != "")
            {
                if (kullaniciAdi == "Admin" && sifre == "Admin1213" || kullaniciAdi == "admin" && sifre == "admin1213" || kullaniciAdi == "Admin" && sifre == "admin1213" || 
                    kullaniciAdi == "admin" && sifre == "Admin1213")
                {
                    FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
                    frmAnaMenu.Show();

                    this.Hide();
                }
                else if(kullaniciAdi != "Admin" && sifre != "Admin1213" || kullaniciAdi != "admin" && sifre != "admin1213")
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    tbxKullaniciAdi.Text = "";
                    tbxSifre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bu Alanları Boş Bırakmayın!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                tbxKullaniciAdi.Text = "";
                tbxSifre.Text = "";
            }

        }

        private void cbxSifremiGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSifremiGöster.Checked)
            {
                tbxSifre.PasswordChar = '\0';
            }
            else
            {
                tbxSifre.PasswordChar = '●';
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void FrmAdminGiris_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void FrmAdminGiris_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void FrmAdminGiris_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void guna2GroupBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void guna2GroupBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void guna2GroupBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void tbxKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }

        private void tbxSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||
               e.KeyChar == '€' || e.KeyChar == '₺' ||
               e.KeyChar == '¨' || e.KeyChar == 'æ' ||
               e.KeyChar == 'ß' || e.KeyChar == '´')
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 33 && (int)e.KeyChar <= 47)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 58 && (int)e.KeyChar <= 64)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 91 && (int)e.KeyChar <= 96)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar >= 123 && (int)e.KeyChar <= 127)
            {
                e.Handled = true;
            }
        }
    }
}
