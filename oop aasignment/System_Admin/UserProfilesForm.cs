using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace oop_aasignment
{
    public partial class UserProfilesForm : Form
    {
        private int AdminID = 1;
        private int ManagerID = 2;
        
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
            formAdminProfile pageAdminProfile = new formAdminProfile(AdminID);
            pageAdminProfile.FormClosed += (s, args) => this.Show();
            pageAdminProfile.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfile PageProfileManager = new UpdateProfile(ManagerID);
            PageProfileManager.FormClosed += (s, args) => this.Show();
            PageProfileManager.Show();

        }
    }
}
