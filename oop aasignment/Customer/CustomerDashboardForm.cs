using SedapmakanCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class CustomerDashboardForm : Form
    {
        public int CustomerID;


        public CustomerDashboardForm(int id)
        {
            InitializeComponent();
            CustomerID = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomerProfile profileForm = new FormCustomerProfile(this);
            profileForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard
            FormMenuBrowse menuForm = new FormMenuBrowse(this);
            menuForm.Show(); // Show menu form
        }



        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderManagement orderForm = new FormOrderManagement(this);
            orderForm.Show();
        }

        private void picEwallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEWallet walletForm = new FormEWallet(this);
            walletForm.Show();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard
            FormMenuBrowse menuForm = new FormMenuBrowse(this);
            menuForm.Show(); // Show menu form
        }

        private void picOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderManagement orderForm = new FormOrderManagement(this);
            orderForm.Show();
        }

        private void PicFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFeedback feedbackForm = new FormFeedback(this);
            feedbackForm.Show();
        }

        private void lblEwallet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEWallet walletForm = new FormEWallet(this);
            walletForm.Show();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFeedback feedbackForm = new FormFeedback(this);
            feedbackForm.Show();
        }

        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            picMenu.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
            picMenu.BorderStyle = BorderStyle.None;
        }

        private void picOrders_MouseEnter(object sender, EventArgs e)
        {
            picOrders.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picOrders_MouseLeave(object sender, EventArgs e)
        {
            picOrders.BorderStyle = BorderStyle.None;
        }

        private void picEwallet_MouseEnter(object sender, EventArgs e)
        {
            picEwallet.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picEwallet_MouseLeave(object sender, EventArgs e)
        {
            picEwallet.BorderStyle = BorderStyle.None;
        }
        private void PicFeedback_MouseEnter(object sender, EventArgs e)
        {
            PicFeedback.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PicFeedback_MouseLeave(object sender, EventArgs e)
        {
            PicFeedback.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomerProfile profileForm = new FormCustomerProfile(this);
            profileForm.Show();
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            // Create Customer class instance
            Customer cust = new Customer();
            DataTable dt = cust.GetProfile(Session.UserId);
            

            if (dt.Rows.Count > 0)
            {
                string name = dt.Rows[0]["full_name"].ToString();
                lblWelcome.Text = $"Welcome, {name}!";
            }
            else
            {
                lblWelcome.Text = "Welcome!";
            }
        }

    }
}
