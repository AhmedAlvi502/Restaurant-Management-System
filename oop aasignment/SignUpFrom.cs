using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class SignUpFrom : Form
    {
        public SignUpFrom()
        {
            InitializeComponent();
            LoadSecretQuestions();

            txtFullName.KeyPress += txtFullName_KeyPress;
            txtPhoneNumber.KeyPress += txtPhoneNumber_KeyPress;
        }

        private void LoadSecretQuestions()
        {
            cmbSecretQuestion.Items.Clear();
            cmbSecretQuestion.Items.Add("— Select a question —");
            cmbSecretQuestion.Items.Add("What is your best pet's name?");
            cmbSecretQuestion.Items.Add("What is the name of your first school?");
            cmbSecretQuestion.Items.Add("What is your place of birth?");
            cmbSecretQuestion.Items.Add("What is your favorite movie?");
            cmbSecretQuestion.Items.Add("Favorite teacher's name?");
            cmbSecretQuestion.Items.Add("What is your favorite food?");
            cmbSecretQuestion.Items.Add("What is your favorite color?");
            cmbSecretQuestion.SelectedIndex = 0;
            cmbSecretQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool ValidateInputs()
        {
            string errors = "";

            // FULL NAME
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || !Regex.IsMatch(txtFullName.Text.Trim(), @"^[a-zA-Z\s]+$"))
                errors += "- Full name must contain only letters and spaces.\n";

            // EMAIL
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@mail\.com$";
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, emailPattern))
            {
                errors += "- Email must end with '@mail.com'.\n";
            }
            else if (EmailExists(email))
            {
                errors += "- This email is already registered.\n";
            }

            // PHONE NUMBER
            if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), @"^\d{8,}$"))
                errors += "- Phone number must be at least 8 digits.\n";

            // PASSWORD
            string password = txtPassword.Text;
            if (password.Length < 8 || !Regex.IsMatch(password, @"\d"))
                errors += "- Password must be at least 8 characters and include at least one digit.\n";

            // CONFIRM PASSWORD
            if (txtConfirmPass.Text != password)
                errors += "- Passwords do not match.\n";

            // SECRET QUESTION
            if (cmbSecretQuestion.SelectedIndex <= 0)
                errors += "- Please select a secret question.\n";

            // SECRET ANSWER
            if (string.IsNullOrWhiteSpace(txtSecretAnswer.Text))
                errors += "- Secret answer is required.\n";

            // SHOW ERRORS
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show("Please fix the following issues:\n\n" + errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool EmailExists(string email)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text != txtPassword.Text)
            {
                lblPasswordMatch.Text = "❌ Passwords do not match.";
                lblPasswordMatch.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPasswordMatch.Text = "✅ Passwords match.";
                lblPasswordMatch.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void btnClearforSignUp_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            txtSecretAnswer.Clear();
            cmbSecretQuestion.SelectedIndex = 0;
            lblPasswordMatch.Text = "";
            txtFullName.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            User newUser = new User
            {
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Password = txtPassword.Text,
                SecretQuestion = cmbSecretQuestion.SelectedItem?.ToString(),
                SecretAnswer = txtSecretAnswer.Text.Trim(),
                UserRole = "customer"
            };

            if (new User().Register(newUser))
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Try again.");
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPss_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                butnCashPass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void butnCashPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPss.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '*')
            {
                button2.BringToFront();
                txtConfirmPass.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == '\0')
            {
                button1.BringToFront();
                txtConfirmPass.PasswordChar = '*';
            }
        }
    }
}

