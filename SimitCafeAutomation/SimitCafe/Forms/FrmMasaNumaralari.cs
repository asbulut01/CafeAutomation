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
    public partial class FrmMasaNumaralari : Form
    {
        public FrmMasaNumaralari()
        {
            InitializeComponent();
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

            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
            frmAnaMenu.Show();

            this.Hide();
        }

        private void Getir()
        {
            dgwListe.DataSource = ProductFunctions.UrunListele();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            int masaNo = Convert.ToInt32(tbxMasaNo.Text);
            ProductFunctions.MasaNoKaldir(masaNo, lblSonuc);

            Getir();

            tbxMasaNo.Text = "";
        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "1";
        }

        private void btnMasa2_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "2";
        }

        private void btnMasa3_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "3";
        }

        private void btnMasa4_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "4";
        }

        private void btnMasa5_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "5";
        }

        private void btnMasa6_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "6";
        }

        private void btnMasa7_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "7";
        }

        private void btnMasa8_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "8";
        }

        private void btnMasa9_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "9";
        }

        private void btnMasa10_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "10";
        }

        private void btnMasa11_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "11";
        }

        private void btnMasa12_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "12";
        }

        private void btnMasa13_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "13";
        }

        private void btnMasa14_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "14";
        }

        private void btnMasa15_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "15";
        }

        private void btnMasa16_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "16";
        }

        private void btnMasa17_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "17";
        }

        private void btnMasa18_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "18";
        }

        private void btnMasa19_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "19";
        }

        private void btnMasa20_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "20";
        }

        private void btnMasa21_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "21";
        }

        private void btnMasa22_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "22";
        }

        private void btnMasa23_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "23";
        }

        private void btnMasa24_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "24";
        }

        private void btnMasa25_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "25";
        }

        private void btnMasa26_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "26";
        }

        private void btnMasa27_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "27";
        }

        private void btnMasa28_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "28";
        }

        private void btnMasa29_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "29";
        }

        private void btnMasa30_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "30";
        }

        private void btnMasa31_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "31";
        }

        private void btnMasa32_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "32";
        }

        private void btnMasa33_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "33";
        }

        private void btnMasa34_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "34";
        }

        private void btnMasa35_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "35";
        }

        private void btnMasa36_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "36";
        }

        private void btnMasa37_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "37";
        }

        private void btnMasa38_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "38";
        }

        private void btnMasa39_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "39";
        }

        private void btnMasa40_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "40";
        }

        private void btnMasa41_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "41";
        }

        private void btnMasa42_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "42";
        }

        private void btnMasa43_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "43";
        }

        private void btnMasa44_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "44";
        }

        private void btnMasa45_Click(object sender, EventArgs e)
        {
            tbxMasaNo.Text = "45";
        }

        private bool Mov;
        private Point point;

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
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

        private void FrmMasaNumaralari_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.connection.Open();
                Getir();

                List<Button> buttons = new List<Button>() { btnMasa1, btnMasa2, btnMasa3, btnMasa4, btnMasa5, btnMasa6, btnMasa7, btnMasa8,
                btnMasa9, btnMasa10, btnMasa11, btnMasa12, btnMasa13, btnMasa14, btnMasa15,btnMasa16,btnMasa17,btnMasa18,btnMasa19,btnMasa20,btnMasa21,btnMasa22,btnMasa23,btnMasa24,
                btnMasa25,btnMasa26,btnMasa27,btnMasa28,btnMasa29,btnMasa30, btnMasa31,btnMasa32,btnMasa33,btnMasa34,btnMasa35,btnMasa36,btnMasa37,btnMasa38,btnMasa39,btnMasa40,btnMasa41,btnMasa42
                ,btnMasa43,btnMasa44,btnMasa45};

                ProductFunctions.MasaDoluMu(buttons);

                label2.Text = DateTime.Now.ToShortTimeString();
                label1.Text = DateTime.Now.ToShortDateString();

                lblSonuc.Visible = false;
            }
            catch (Exception)
            {
                throw;
            }    
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            lblSonuc.Visible = false;

            tbxMasaNo.Text = "";
        }
    }
}
