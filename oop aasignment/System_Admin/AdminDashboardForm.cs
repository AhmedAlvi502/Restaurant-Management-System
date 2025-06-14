using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_aasignment.;

namespace oop_aasignment
{
    public partial class formAdminDashboard : Form
    {
        int AdminId;
        Chef Admin = new Chef();
        public formAdminDashboard(int Id)
        {
            InitializeComponent();
            AdminId = Id; // ✅ store the ID passed from login
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            Form pageUserProfile = new SystemAdmin.formUserProfiles();
            pageUserProfile.ShowDialog();
        }

        private void formAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Show();
            loginForm.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            formSalesView pageSalesView = new formSalesView();
            pageSalesView.ShowDialog();
        }
    }
}
