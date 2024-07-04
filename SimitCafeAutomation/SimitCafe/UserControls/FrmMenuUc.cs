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
    public partial class FrmMenuUc : UserControl
    {
        public FrmMenuUc()
        {
            InitializeComponent();
        }

        FrmMenuIki frmMenuIki = new FrmMenuIki();

        private void FrmMenuUc_Load(object sender, EventArgs e)
        {
            label4.Text = "3/3";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(frmMenuIki);
        }
    }
}
