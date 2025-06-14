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
        public int CustomerID; // Stores the logged-in customer's ID


        public CustomerDashboardForm(int id) // Constructor that accepts the customer ID and stores it.
        {
            InitializeComponent();
            CustomerID = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Opens the Customer Profile form when profile picture is clicked.
        {
            this.Hide();
            FormCustomerProfile profileForm = new FormCustomerProfile(this);
            profileForm.Show();
        }

        private void label1_Click(object sender, EventArgs e) // Opens the Menu form when the Menu label is clicked.
        {
            this.Hide(); // Hide the dashboard
            FormMenuBrowse menuForm = new FormMenuBrowse(this);
            menuForm.Show(); // Show menu form
        }



        private void label1_Click_1(object sender, EventArgs e) // Opens the Order Management form when the Orders label is clicked.
        {
            this.Hide();
            FormOrderManagement orderForm = new FormOrderManagement(this);
            orderForm.Show();
        }

        private void picEwallet_Click(object sender, EventArgs e) // Opens the E-Wallet form when its picture is clicked.
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

        private void picOrders_Click(object sender, EventArgs e) // Opens the Order Management form when Orders image is clicked.
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

        private void lblFeedback_Click(object sender, EventArgs e) // Opens the Feedback form when the Feedback label is clicked.
        {
            this.Hide();
            FormFeedback feedbackForm = new FormFeedback(this);
            feedbackForm.Show();
        }
        // UI effect: Add 3D border on hover for Menu
        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            picMenu.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picMenu_MouseLeave(object sender, EventArgs e)
        {
            picMenu.BorderStyle = BorderStyle.None;
        }

        private void picOrders_MouseEnter(object sender, EventArgs e) // UI effect: Add 3D border on hover for Orders
        {
            picOrders.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picOrders_MouseLeave(object sender, EventArgs e)
        {
            picOrders.BorderStyle = BorderStyle.None;
        }
        // UI effect: Add 3D border on hover for E-Wallet
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
        // UI effect: Add 3D border on hover for Profile
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

        private void CustomerDashboardForm_Load(object sender, EventArgs e) // Loads customer profile info when dashboard opens and displays welcome message.
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

        private void btnLogout_Click(object sender, EventArgs e) // Handles logout logic: confirm, clear session, return to login form.
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Optional: Clear session data
                Session.UserId = 0;
                Session.CustomerName = null;
                Session.CustomerEmail = null;
                Session.UserPassword = null;

                // Show login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close the dashboard
                this.Close();
            }
        }

    }
}
