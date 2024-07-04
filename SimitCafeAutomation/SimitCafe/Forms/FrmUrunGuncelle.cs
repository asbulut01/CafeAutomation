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
    public partial class FrmUrunGuncelle : Form
    {
        public FrmUrunGuncelle()
        {
            InitializeComponent();
        }

        private void FrmUrunGuncelle_Load(object sender, EventArgs e)
        {
            ConnectDB.connection.Open();
            Getir();

            lblSaat.Text = DateTime.Now.ToShortTimeString();
            lblTarih.Text = DateTime.Now.ToShortDateString();

            lblSonuc.Visible = false;
            lblMenuSonuc.Visible = false;

            tbxYeniUrunAdi.Enabled = false;
            tbxYeniUrunFiyati.Enabled = false;

            tbxMenuAdi.Enabled = false;
            tbxMenuFiyati.Enabled = false;
        }

        private void Getir()
        {
            dgwListe.DataSource = ProductFunctions.UrunListele();
            dgwMenu.DataSource = ProductFunctions.MenuyuListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Programı tamamen kapat.
        }

        private void btnAltaKatla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Formun Pencere boyutunu küçültülmüşe ayarla.
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            FrmUrunAyarlari frmUrunAyarlari = new FrmUrunAyarlari();

            frmUrunAyarlari.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            lblSonuc.Visible = false;
            tbxUrunNo.Text = "";
        }

        private bool Mov;
        private Point point;

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

        private void panelLeft_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxYeniUrunAdi.Text != "" && tbxYeniUrunFiyati.Text != "")
                {
                    string urunNo = tbxUrunNo.Text;
                    string yeniUrunAdi = tbxYeniUrunAdi.Text;
                    double yeniUrunFiyati = Convert.ToDouble(tbxYeniUrunFiyati.Text);

                    ProductFunctions.UrunGuncelle(urunNo, yeniUrunAdi, yeniUrunFiyati, lblSonuc);
                    Getir();

                    Temizle();
                }
                else
                {
                    MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    Temizle();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Temizle()
        {
            tbxYeniUrunAdi.Text = "";
            tbxYeniUrunFiyati.Text = "";
            tbxUrunNo.Text = "";
        }

        private void tbxUrunNo_TextChanged(object sender, EventArgs e)
        {
            if (tbxUrunNo.Text.Length > 0)
            {
                tbxYeniUrunAdi.Enabled = true;
                tbxYeniUrunFiyati.Enabled = true;
            }
            else if (tbxUrunNo.Text == "")
            {
                tbxYeniUrunAdi.Enabled = false;
                tbxYeniUrunFiyati.Enabled = false;

                tbxYeniUrunAdi.Text = "";
                tbxYeniUrunFiyati.Text = "";
            }
        }

        private void btnMenuGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxMenuAdi.Text != "" && tbxMenuFiyati.Text != "")
                {
                    string urunNo = tbxMenuNo.Text;
                    string urunFiyat = tbxMenuFiyati.Text;
                    string urunAdi = tbxMenuAdi.Text;

                    ProductFunctions.MenuGuncelle(urunNo, urunAdi, urunFiyat, lblMenuSonuc);
                    Getir();

                    TemizleMenu();
                }
                else
                {
                    MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    TemizleMenu();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                TemizleMenu();
            }
        }

        private void btnTemizleMenu_Click(object sender, EventArgs e)
        {
            Temizle();
            lblMenuSonuc.Text = "";
            tbxMenuNo.Text = "";
            TemizleMenu();
        }

        private void TemizleMenu()
        {
            tbxMenuAdi.Text = "";
            tbxMenuFiyati.Text = "";
            tbxMenuNo.Text = "";
        }

        private void tbxMenuNo_TextChanged(object sender, EventArgs e)
        {
            if (tbxMenuNo.Text.Length > 0)
            {
                tbxMenuAdi.Enabled = true;
                tbxMenuFiyati.Enabled = true;
            }
            else if (tbxMenuNo.Text == "")
            {
                tbxMenuAdi.Enabled = false;
                tbxMenuFiyati.Enabled = false;

                tbxMenuAdi.Text = "";
                tbxMenuFiyati.Text = "";
            }
        }

        private void tbxYeniUrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);

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

        private void tbxYeniUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void tbxUrunNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxMenuNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxMenuAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

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

        private void tbxMenuFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }
    }
}
