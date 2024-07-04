using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimitCafe.ProductManagement;

namespace SimitCafe.Forms
{
    public partial class FrmMenuEkleMenuKaldir : Form
    {
        public FrmMenuEkleMenuKaldir()
        {
            InitializeComponent();
        }

        private void Getir()
        {
            dgwListe.DataSource = ProductFunctions.MenuyuListele();
        }

        private void FrmMenuEkleMenuKaldir_Load(object sender, EventArgs e)
        {
            ConnectDB.connection.Open();
            Getir();

            lblSonucEkle.Visible = false;
            lblSonucKaldir.Visible = false;

            lblSaat.Text = DateTime.Now.ToShortTimeString();
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            FrmUrunAyarlari frmUrunAyarlari = new FrmUrunAyarlari();

            frmUrunAyarlari.Show();
            this.Hide();

            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string urunAdi = tbxUrunAdi.Text;
                string urunFiyat = tbxUrunFiyati.Text;

                if (tbxUrunAdi.Text != "" && tbxUrunFiyati.Text != "")
                {
                    ProductFunctions.MenuEkle(urunAdi, urunFiyat, lblSonucEkle);

                    Getir();

                    tbxUrunAdi.Text = "";
                    tbxUrunFiyati.Text = "";
                }
                else
                {
                    MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                    tbxUrunAdi.Text = "";
                    tbxUrunFiyati.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                tbxUrunAdi.Text = "";
                tbxUrunFiyati.Text = "";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAltaKatla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tbxUrunFiyati.Text = "";
            tbxUrunAdi.Text = "";

            lblSonucEkle.Text = "";
            lblSonucEkle.Visible = false;
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            try
            {
                int urunNo = Convert.ToInt32(tbxUrunNoKaldir.Text);

                if (tbxUrunNoKaldir.Text != "")
                {
                    ProductFunctions.MenuKaldir(urunNo, lblSonucKaldir);
                    tbxUrunNoKaldir.Text = "";

                    Getir();
                }
                else if (tbxUrunNoKaldir.Text == "")
                {
                    MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                    tbxUrunNoKaldir.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                tbxUrunNoKaldir.Text = "";
            } 
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            lblSonucKaldir.Text = "";
            lblSonucKaldir.Visible = false;
            tbxUrunNoKaldir.Text = "";
        }

        private bool Mov;
        private Point point;

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void panelLeft_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void tbxUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //Sadece harf girişi yaptıracak komut.
                 && !char.IsSeparator(e.KeyChar); 


            if (e.KeyChar == '£' || e.KeyChar == '½' ||   //Özel Karakter girişini engelleme komutları
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

        private void tbxUrunNoKaldir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Sadece tam sayı girişi yaptıracak komut.
        }

        private void tbxUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '£' || e.KeyChar == '½' ||   //Özel Karakter girişini engelleme komutları
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
            } //Matematiksel işlem yapmayacağımız için harf girişini engellemedim.
        }
    }
}
