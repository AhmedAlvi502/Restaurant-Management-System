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
    public partial class UserProfilesForm : Form
    {
        public UserProfilesForm()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSystemAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdminProfile pageAdminProfile = new formAdminProfile();
            pageAdminProfile.FormClosed += (s, args) => this.Show();
            pageAdminProfile.Show();
        }
    }
}
