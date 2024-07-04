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
using SimitCafe.UserControls;

namespace SimitCafe
{
    public partial class FrmUrunAyarlari : Form
    {
        public FrmUrunAyarlari()
        {
            InitializeComponent();
        }

        private FrmUrunEkleUrunKaldir frmUrunEkleUrunKaldir = new FrmUrunEkleUrunKaldir();
        private FrmUrunGuncelle frmUrunGuncelle = new FrmUrunGuncelle();
        private FrmMenuEkleMenuKaldir frmMenuEkleMenuKaldir = new FrmMenuEkleMenuKaldir();

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
            FrmAnaMenu frmAnaMenu = new FrmAnaMenu();

            frmAnaMenu.Show();
            this.Close();
        }

        private void btnYeniUrunEskiUrun_Click(object sender, EventArgs e)
        {
            frmUrunEkleUrunKaldir.Show();
            this.Close();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            frmUrunGuncelle.Show();
            this.Close();
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

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            point = new Point(e.X, e.Y);
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point point2 = PointToScreen(e.Location);
                Location = new Point(point2.X - point.X, point2.Y - point.Y);
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuEkleMenuKaldir_Click(object sender, EventArgs e)
        {
            frmMenuEkleMenuKaldir.Show();
            this.Hide();
        }

        private void btnMenuGuncelle_Click(object sender, EventArgs e)
        {
            frmUrunGuncelle.Show();
            this.Hide();
        }
    }
}
