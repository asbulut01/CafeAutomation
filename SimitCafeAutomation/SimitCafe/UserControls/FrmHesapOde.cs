using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimitCafe.ProductManagement;
using System.Data.OleDb;

namespace SimitCafe.UserControls
{
    public partial class FrmHesapOde : UserControl
    {
        public FrmHesapOde()
        {
            InitializeComponent();
        }

        private void btnKrediOnayla_Click(object sender, EventArgs e)
        {
            KrediIleOde();
        }

        private void KrediIleOde()
        {
            if (tbxMasaNo.Text != "" && tbxOdenecekKredi.Text != "" && tbxVerilenKredi.Text != "")
            {
                double odenecek = Convert.ToDouble(tbxOdenecekKredi.Text);
                double verilen = Convert.ToDouble(tbxVerilenKredi.Text);

                double sonuc = verilen - odenecek;

                if (verilen >= odenecek)
                {
                    lblSonuc.ForeColor = Color.Green;
                    lblSonuc.Visible = true;
                    lblSonuc.Text =  "Ödeme Başarıyla Yapıldı :)";
                    tbxKalan.Text = $"{sonuc} ₺";

                    ProductFunctions.HesabiOde(odenecek);

                    tbxOdenecekKredi.Text = "";
                    tbxMasaNo.Text = "";
                    tbxVerilenKredi.Text = "";
                }
                else
                {
                    lblSonuc.ForeColor = Color.DarkRed;
                    lblSonuc.Visible = true;
                    lblSonuc.Text = "Yetersiz Limit.";

                    tbxVerilenKredi.Text = "";
                }
            }
            else if (tbxMasaNo.Text == "" || tbxOdenecekKredi.Text == "" || tbxVerilenKredi.Text == "")
            {
                lblSonuc.Visible = true;
                lblSonuc.ForeColor = Color.Red;

                lblSonuc.Text = "Bu Alanları Boş Bırakmayın";

                tbxMasaNo.Text = "";
            }
        }

        private void btnKrediTemizle_Click(object sender, EventArgs e)
        {
            tbxOdenecekKredi.Text = "";
            tbxMasaNo.Text = "";
            tbxVerilenKredi.Text = "";
            lblSonuc.Text = "";
            lblSonuc.Visible = false;
        }

        private void btnNakitTemizle_Click(object sender, EventArgs e)
        {
            tbxOdenecekNakit.Text = "";
            tbxParaUstu.Text = "";
            tbxParaUstu.Text = "";
            lblSonuc2.Text = "";
            lblSonuc2.Visible = false;
        }

        private void FrmHesapOde_Load(object sender, EventArgs e)
        {
            ConnectDB.connection.Open();

            tbxVerilenKredi.Enabled = false;
            tbxVerilenNakit.Enabled = false;
        }

        private void tbxMasaNo_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxMasaNo.Text == "")
            {
                tbxOdenecekKredi.Text = "";
                tbxVerilenKredi.Enabled = false;
            }
            else
            {
                int masaNo = Convert.ToInt32(tbxMasaNo.Text);
                ProductFunctions.MasaNoyaGoreGetir(masaNo, tbxOdenecekKredi, tbxVerilenKredi);
            }
        }

        private void btnNakitOnayla_Click(object sender, EventArgs e)
        {
            if (tbxMasaNo2.Text != "" && tbxOdenecekNakit.Text != "" && tbxVerilenNakit.Text != "")
            {
                double odenecek = Convert.ToDouble(tbxOdenecekNakit.Text);
                double verilen = Convert.ToDouble(tbxVerilenNakit.Text);

                double sonuc = verilen - odenecek;

                if (verilen >= odenecek)
                {
                    lblSonuc2.ForeColor = Color.Green;
                    lblSonuc2.Visible = true;
                    lblSonuc2.Text = "Ödeme Başarıyla Yapıldı :)";
                    tbxParaUstu.Text = $"{sonuc} ₺";

                    ProductFunctions.HesabiOde(odenecek);

                    tbxOdenecekNakit.Text = "";
                    tbxMasaNo2.Text = "";
                    tbxVerilenNakit.Text = "";
                }
                else
                {
                    lblSonuc2.ForeColor = Color.DarkRed;
                    lblSonuc2.Visible = true;
                    lblSonuc2.Text = "Yetersiz Limit.";

                    tbxVerilenNakit.Text = "";
                }
            }
            else if (tbxMasaNo2.Text == "" || tbxOdenecekNakit.Text == "" || tbxVerilenNakit.Text == "")
            {
                lblSonuc2.Visible = true;
                lblSonuc2.ForeColor = Color.Red;

                lblSonuc2.Text = "Bu Alanları Boş Bırakmayın";

                tbxMasaNo2.Text = "";
            }
        }

        private void tbxMasaNo2_TextChanged(object sender, EventArgs e)
        {
            if (tbxMasaNo2.Text == "")
            {
                tbxOdenecekNakit.Text = "";
                tbxVerilenNakit.Enabled = false;
            }
            else
            {
                int masaNo = Convert.ToInt32(tbxMasaNo2.Text);
                ProductFunctions.MasaNoyaGoreGetir(masaNo, tbxOdenecekNakit, tbxVerilenNakit);
            }
        }

        private void tbxMasaNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxMasaNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbxOdenecekKredi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void tbxVerilenKredi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void tbxOdenecekNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void tbxVerilenNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void btnParaUstuAl_Click(object sender, EventArgs e)
        {
            tbxParaUstu.Text = "";
        }
    }
}
