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
    public partial class UpdateProfile : Form
    {
        private bool isPasswordVisible = false;
        private int userId = 2;
        Manager manager = new Manager();
        User user = new User();

        public UpdateProfile(int userId)
        {
            InitializeComponent();
            this.userId = userId; // ID is passed to ensure to update the right profile
            LoadProfile(); // called method
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
               string.IsNullOrWhiteSpace(email) ||
               string.IsNullOrWhiteSpace(phone) ||
               string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name (letters only).");
                return;
            }

            // ✅ Email
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // ✅ Phone
            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 8 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number (digits only).");
                return;
            }

            // ✅ Password
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }

           

            try
            {
                string result = user.UpdateProfile(userId, name, email, phone, password);
                MessageBox.Show(result);

                if (result == "Profile updated successfully.")
                {
                    LoadProfile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tableLayout_Paint(object sender, PaintEventArgs e)
        {
        }

        // Removed duplicate 
        private void LoadProfile()
        {
            DataTable dt = manager.GetUserProfile(userId);
            if (dt.Rows.Count > 0)
            {
                txtFullName.Text = dt.Rows[0]["full_name"].ToString().Trim();
                txtEmail.Text = dt.Rows[0]["email"].ToString().Trim();
                txtPhone.Text = dt.Rows[0]["phone_number"].ToString().Trim();
                txtPassword.Text = dt.Rows[0]["password"].ToString().Trim();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            ManagerDashboard dash = new ManagerDashboard(userId);
            dash.Show();
            this.Close();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnTogglePassword.Text = "🙈";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnTogglePassword.Text = "👁️";
            }
        }

        
    }




}
