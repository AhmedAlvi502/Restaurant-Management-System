using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class formAdminProfile : Form
    {
        private int AdminId = 1;
        private bool isPasswordVisible = false;
        SystemAdmin admin = new SystemAdmin();
        User user = new User();
        public formAdminProfile(int AdminId)
        {
            InitializeComponent();
            this.AdminId = AdminId; // ID is passed to ensure to update the right profile
            LoadProfile(); // called method
        }
        private void LoadProfile()
        {
            DataTable dt = admin.GetAdminProfile(AdminId);
            if (dt.Rows.Count > 0)
            {
                txtAdminName.Text = dt.Rows[0]["full_name"].ToString().Trim();
                txtAdminEmail.Text = dt.Rows[0]["email"].ToString().Trim();
                txtAdminPhone.Text = dt.Rows[0]["phone_number"].ToString().Trim();
                txtConfirmPass.Text = dt.Rows[0]["password"].ToString().Trim();
                txtAdminPassword.Text = dt.Rows[0]["Password"].ToString();
            }
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

        private void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            string name = txtAdminName.Text.Trim();
            string email = txtAdminEmail.Text.Trim();
            string phone = txtAdminPhone.Text.Trim();
            string password = txtAdminPassword.Text.Trim();

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

            if (!Regex.IsMatch(txtAdminPhone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone Number must contain only numbers.");
                return;
            }

            // ✅ Phone
            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 8 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number (minimum 8 digits ).");
                return;
            }

            // ✅ Password
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return;
            }
            // Check password confirmation
            if (password != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }



            try
            {
                string result = user.UpdateProfile(AdminId, name, email, phone, password);
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

        private void btnShowPas_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtAdminPassword.UseSystemPasswordChar = false;
                btnShowPas.Text = "🙈";
            }
            else
            {
                txtAdminPassword.UseSystemPasswordChar = true;
                btnShowPas.Text = "👁️";
            }
        }

        private void btnShoConPas_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtConfirmPass.UseSystemPasswordChar = false;
                btnShowConPas.Text = "🙈";
            }
            else
            {
                txtConfirmPass.UseSystemPasswordChar = true;
                btnShowConPas.Text = "👁️";
            }
        }

    }
}
