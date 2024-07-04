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
    public partial class FrmMenu : UserControl
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        FrmMenuIki frmMenuIki = new FrmMenuIki();

        private void btnDigerSayfa_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(frmMenuIki);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
