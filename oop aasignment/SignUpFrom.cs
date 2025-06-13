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
    public partial class SignUpFrom : Form
    {
        public SignUpFrom()
        {
            InitializeComponent();
            LoadSecretQuestions();

            btnSignUp.Enabled = false; // Disable sign-up button initially
            txtFullName.TextChanged += ValidateSignUpInputs;
            txtEmail.TextChanged += ValidateSignUpInputs;
            txtPhoneNumber.TextChanged += ValidateSignUpInputs;
            txtPassword.TextChanged += ValidateSignUpInputs;
            txtConfirmPass.TextChanged += ValidateSignUpInputs;
            txtSecretAnswer.TextChanged += ValidateSignUpInputs;
            cmbSecretQuestion.SelectedIndexChanged += ValidateSignUpInputs;
        }
        private void LoadSecretQuestions()
        {
            // Clear old items to avoid duplicates
            cmbSecretQuestion.Items.Clear();

            // Add a default prompt (not selectable if desired)
            cmbSecretQuestion.Items.Add("— Select a question —");

            // Add secret questions
            cmbSecretQuestion.Items.Add("What is your best pet's name?");
            cmbSecretQuestion.Items.Add("What is the name of your first school?");
            cmbSecretQuestion.Items.Add("What is your place of birth?");
            cmbSecretQuestion.Items.Add("What is your favorite movie?");
            cmbSecretQuestion.Items.Add("Favorite teacher's name?");
            cmbSecretQuestion.Items.Add("What is your favorite food?");
            cmbSecretQuestion.Items.Add("What is your favorite color?");

            // Optional: Set to the prompt by default
            cmbSecretQuestion.SelectedIndex = 0;

            // Prevent typing custom questions
            cmbSecretQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ValidateSignUpInputs(object sender, EventArgs e)
        {
            // Enable sign-up button only when all fields are filled
            btnSignUp.Enabled = !string.IsNullOrWhiteSpace(txtFullName.Text) &&
                                !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                                !string.IsNullOrWhiteSpace(txtPhoneNumber.Text)&&
                                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                                !string.IsNullOrWhiteSpace(txtConfirmPass.Text) &&
                                !string.IsNullOrWhiteSpace(txtSecretAnswer.Text) &&
                                cmbSecretQuestion.SelectedIndex > 0; //not default 
        }
        private void SignUpFrom_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {

            this.Close(); // Close SignUpForm
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

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

        private void btnClearforSignUp_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
            txtPhoneNumber.Clear();
            cmbSecretQuestion.SelectedIndex = -1; // Clear the selected item
            btnSignUp.Enabled = false; // Disable sign-up button
            txtSecretAnswer.Clear();
            txtFullName.Focus(); // Set focus back to the first field
        }

        private void lblPasswordMatch_Click(object sender, EventArgs e)
        {

        }

        private void panelSecretQuestion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSecretAnswer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbSecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSecretAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            {

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
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

            User user = new User();
            if (user.Register(newUser))
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.Close(); // or redirect to login form
            }
            else
            {
                MessageBox.Show("Registration failed. Try again.");
            }
        }


    }
}



