using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment.System_Admin
{
    public partial class formManageUsers : Form
    {
        public formManageUsers()
        {
            InitializeComponent();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            formAddUser pageAddManager = new formAddUser("manager");
            pageAddManager.FormClosed += (s, args) => this.Show();
            pageAddManager.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            formAddUser pageAddAdmin = new formAddUser("system admin");
            pageAddAdmin.FormClosed += (s, args) => this.Show();
            pageAddAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAddUser pageAddChef = new formAddUser("chef");
            pageAddChef.FormClosed += (s, args) => this.Show();
            pageAddChef.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            formAddUser pageAddCustomer = new formAddUser("customer");
            pageAddCustomer.FormClosed += (s, args) => this.Show();
            pageAddCustomer.Show();
        }
    }
}
