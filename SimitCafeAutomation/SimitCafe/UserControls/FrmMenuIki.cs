using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimitCafe.UserControls
{
    public partial class FrmMenuIki : UserControl
    {
        public FrmMenuIki()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Controls.Clear();
            this.Controls.Add(frmMenu);
        }

        private void FrmMenuIki_Load(object sender, EventArgs e)
        {
            label4.Text = "2/3";
        }

        private void btnDigerSayfa_Click(object sender, EventArgs e)
        {
            FrmMenuUc frmMenuUc = new FrmMenuUc();

            this.Controls.Clear();
            this.Controls.Add(frmMenuUc);
        }
    }
}
