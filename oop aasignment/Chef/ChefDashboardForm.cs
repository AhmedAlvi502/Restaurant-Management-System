using System;
using System.Data;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class ChefDashboardForm : Form
    {
        int chefId;
        Chef chef = new Chef(); // Create an instance of the Chef class


        // Constructor that receives the logged-in chef's ID
        public ChefDashboardForm(int id)
        {
            InitializeComponent();
            chefId = id; // Save the chef's ID for use in other forms or methods
        }

        // When the dashboard form loads, display a welcome message with the chef's name
        private void ChefDashboardForm_Load(object sender, EventArgs e)
        {
            DataTable dt = chef.GetChefProfile(chefId);
            if (dt.Rows.Count > 0)
            {
                lblWelcome.Text = "Welcome, Chef " + dt.Rows[0]["Name"].ToString();
            }
        }

        // Open the "Manage Menu" form and hide the dashboard temporarily
        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide this dashboard
            ManageMenuForm manageMenuForm = new ManageMenuForm(chefId); // Pass chef ID to the ManageMenuForm
            manageMenuForm.FormClosed += (s, args) => this.Show(); // Show dashboard again after closing
            manageMenuForm.Show();
        }

        // Open the "Update Profile" form
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateProfileForm updateProfileForm = new UpdateProfileForm(chefId); // Pass chef ID
            updateProfileForm.FormClosed += (s, args) => this.Show();
            updateProfileForm.Show();
        }

        // Open the "View Orders" form
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm(chefId); // You may want to pass chefId if needed
            viewOrdersForm.FormClosed += (s, args) => this.Show();
            viewOrdersForm.Show();
        }

        // Log out and return to the login screen
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(); // Show the login form
            loginForm.FormClosed += (s, args) => this.Show(); // Optional: show dashboard again if needed
            loginForm.Show();
        }
    }
}
