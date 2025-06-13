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
    public partial class AdminProfileForm : Form
    {
        public AdminProfileForm()
        {
            InitializeComponent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminClear_Click(object sender, EventArgs e)
        {
            txtAdminPhone.Clear();
            txtAdminName.Clear();
            txtConfirmPass.Clear();
            txtAdminEmail.Clear();
            txtAdminPassword.Clear();
        }

        private void btnAdminBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
