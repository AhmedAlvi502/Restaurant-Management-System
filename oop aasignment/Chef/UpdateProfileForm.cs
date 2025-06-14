using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class UpdateProfileForm : Form
    {
        User user = new User();  // Logic class to handle user operations
        Chef chef = new Chef();  // Logic class to handle backend operations
        int chefId;              // Logged-in chef's ID

        // Constructor: receives chefId from dashboard
        public UpdateProfileForm(int loggedInchefId)
        {
            InitializeComponent();
            chefId = loggedInchefId;
            txtEmail.ReadOnly = true; // Email should not be editable
        }

        // Load the chef's profile data into the form fields
        private void LoadProfile()
        {
            DataTable dt = chef.GetChefProfile(chefId);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtPassword.Text = dt.Rows[0]["Password"].ToString();
                txtConfirmPass.Text = dt.Rows[0]["Password"].ToString();
            }
        }

        // When the form loads, auto-fill the chef's profile data
        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        // Update button: validate inputs and save changes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate full name: only letters and spaces
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Full Name must contain only letters.");
                return;
            }

            // Validate phone number: digits only
            if (!Regex.IsMatch(txtPhone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone Number must contain only numbers.");
                return;
            }

            // Validate password: at least 8 characters, includes at least one digit
            string password = txtPassword.Text;
            if (password.Length < 8 || !Regex.IsMatch(password, @"\d"))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one digit.");
                return;
            }

            // Check password confirmation
            if (password != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 8)
            {
                MessageBox.Show("Please enter a valid phone number (minimum 8 digits).");
                return;
            }


            string result = user.UpdateProfile(
              chefId,
              txtName.Text,
              txtEmail.Text,
              txtPhone.Text,
              txtPassword.Text
              );

            MessageBox.Show(result);

            if (result == "Profile updated successfully.")
            {
                LoadProfile(); // Reload updated info
            }
        }

        // Clear all input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        // Go back to dashboard
        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Toggle password visibility
        private void btnShowPss_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                butnCashPass.BringToFront();
                txtPassword.PasswordChar = '\0'; // Show password
            }
        }

        private void butnCashPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPss.BringToFront();
                txtPassword.PasswordChar = '*'; // Hide password
            }
        }

        // Toggle confirm password visibility
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '*')
            {
                button1.BringToFront();
                txtConfirmPass.PasswordChar = '\0'; // Show confirm password
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtConfirmPass.PasswordChar = '*'; // Hide confirm password
            }
        }

        // Optional: can remove if unused
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
    }
}

