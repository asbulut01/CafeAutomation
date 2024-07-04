using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimitCafe.Forms;
using SimitCafe.ProductManagement;
using SimitCafe.UserControls;

namespace SimitCafe
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private FrmSimitCafeIcon frmSimitCafeIcon = new FrmSimitCafeIcon();
        private FrmMenu frmMenu = new FrmMenu();
        private FrmMenuIki frmMenuIki = new FrmMenuIki();
        private FrmUrunAyarlari frmUrunIslemleri = new FrmUrunAyarlari();
        private FrmMasaNumaralari frmMasanNumaralari = new FrmMasaNumaralari();
        private FrmHesapOde frmHesapOde = new FrmHesapOde();

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            panelMid.Controls.Add(frmSimitCafeIcon);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconStatus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMid.Controls.Clear();
            panelMid.Controls.Add(frmMenu);
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            panelMid.Controls.Clear();
            panelMid.Controls.Add(frmSimitCafeIcon);
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            frmUrunIslemleri.Show();
            this.Hide();
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

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
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

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            panelMid.Controls.Clear();

            panelMid.Controls.Add(frmHesapOde);
        }

        private void btnMasaNumaraları_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            frmMasanNumaralari.Show();
            this.Hide();
        }

        private void btnMenuIslemleri_Click(object sender, EventArgs e)
        {
            ConnectDB.connection.Close();

            frmUrunIslemleri.Show();
            this.Hide();
        }
    }
}
