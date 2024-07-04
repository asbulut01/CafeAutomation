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
    public partial class FrmUrunEkleUrunKaldir : Form
    {
        public FrmUrunEkleUrunKaldir()
        {
            InitializeComponent();
        }

        private void FrmUrunEkleUrunKaldir_Load(object sender, EventArgs e)
        {
            ConnectDB.connection.Open();
            Getir();

            nupAdet.Value = 1;

            lblSaat.Text = DateTime.Now.ToShortTimeString();
            lblTarih.Text = DateTime.Now.ToShortDateString();

            lblSonucEkle.Visible = false;
            lblSonucKaldir.Visible = false;

            dtpTarihEkle.Text = DateTime.Now.ToLongDateString();
        }

        private void Getir()
        {
            dgwListe.DataSource = ProductFunctions.UrunListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAltaKatla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
            tbxUrunAdiEkle.Text = "";
            tbxUrunFiyatiEkle.Text = "";
            dtpTarihEkle.Text = "";
            lblSonucEkle.Text = "";
            lblSonucEkle.Visible = false;
            tbxMasaNo.Text = "";
            nupAdet.Value = 1;
            tbxToplamFiyat.Text = "";
        }

        private void btnTemizle2_Click(object sender, EventArgs e)
        {
            tbxUrunNoKaldir.Text = "";
            lblSonucKaldir.Visible = false;
            lblSonucKaldir.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int urunAdet = Convert.ToInt32(nupAdet.Value);
                int masaNo = Convert.ToInt32(tbxMasaNo.Text);
                string urunAdi = tbxUrunAdiEkle.Text;
                double urunFiyati = Convert.ToDouble(tbxUrunFiyatiEkle.Text);
                DateTime urunTarih = dtpTarihEkle.Value.Date;
                double toplamFiyat = urunAdet * urunFiyati;

                if (tbxUrunAdiEkle.Text != "" && tbxUrunFiyatiEkle.Text != "")
                {
                    ProductFunctions.UrunEkle(urunAdet, masaNo, urunAdi, urunFiyati, urunTarih, toplamFiyat);
                    tbxToplamFiyat.Text = toplamFiyat + " ₺";

                    lblSonucEkle.Visible = true;
                    lblSonucEkle.ForeColor = Color.Green;

                    lblSonucEkle.Text = "Ürün Başarıyla Eklendi :)";

                    Getir();

                    tbxUrunAdiEkle.Text = "";
                    tbxUrunFiyatiEkle.Text = "";
                    dtpTarihEkle.Text = DateTime.Now.ToLongDateString();
                    nupAdet.Value = 1;
                }
                else if (tbxUrunAdiEkle.Text == "" || tbxUrunFiyatiEkle.Text == "")
                {
                    MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                    tbxUrunAdiEkle.Text = "";
                    tbxUrunFiyatiEkle.Text = "";
                    dtpTarihEkle.Text = DateTime.Now.ToLongDateString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                tbxUrunAdiEkle.Text = "";
                tbxUrunFiyatiEkle.Text = "";
                tbxToplamFiyat.Text = "";
                dtpTarihEkle.Text = DateTime.Now.ToLongDateString();
            }
        }

        private void ToplamFiyat()
        {
            double urunFiyati = Convert.ToDouble(tbxUrunFiyatiEkle.Text);
            int urunAdet = Convert.ToInt32(nupAdet.Value);

            double toplamFiyat = ProductFunctions.ToplamFiyat(urunFiyati, urunAdet);
            tbxToplamFiyat.Text = $"{toplamFiyat} TL";
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            string urunAdi = tbxUrunNoKaldir.Text;

            if (tbxUrunNoKaldir.Text != "")
            {
                ProductFunctions.UrunKaldir(urunAdi, lblSonucKaldir);

                Getir();
                tbxUrunNoKaldir.Text = "";
            }
            else if (tbxUrunNoKaldir.Text == "")
            {
                MessageBox.Show("Bu Alanları Doldurmak Zorunludur!", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                tbxUrunNoKaldir.Text = "";
            }
        }

        private bool Mov;
        private Point point;

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }

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

        private void nupAdet_ValueChanged(object sender, EventArgs e)
        {
            if (nupAdet.Value < 1)
            {
                nupAdet.Value = 1;
            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            FrmMenuEkleMenuKaldir frmMenuEkleMenuKaldir = new FrmMenuEkleMenuKaldir();
            frmMenuEkleMenuKaldir.Show();

            this.Hide();
        }

        private void tbxMasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxUrunAdiEkle_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxUrunFiyatiEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void tbxUrunNoKaldir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
