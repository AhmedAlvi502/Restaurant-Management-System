using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class formViewEWallet : Form

    {
        SystemAdmin Admin = new SystemAdmin();
        public formViewEWallet()
        {
            InitializeComponent();
        }

        private void lblEWalletViewer_Click(object sender, EventArgs e)
        {

        }

        private void btnExitViewer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEWalletReport_Click(object sender, EventArgs e)

        {   
            dgvEWallet.DataSource = Admin.GenerateEWalletReport(cmbWalletID, cmbMonth, cmbYear);
        }

        private void formViewEWallet_Load(object sender, EventArgs e)
        {
            dgvEWallet.DataSource = Admin.LoadSalesView();
        }
    }
}
