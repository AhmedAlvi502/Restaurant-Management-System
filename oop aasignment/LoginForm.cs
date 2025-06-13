using System.Windows.Forms;
using System;
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
    public partial class LoginForm : Form
    { 

        public LoginForm()
        {
            InitializeComponent();


            ComboLanguage.Items.Clear();
            ComboLanguage.Items.Add("English");
            ComboLanguage.Items.Add("Malay");
            ComboLanguage.SelectedIndex = 0; // Show "English" when the form opens
                                             // Disable Login button initially
            btnLogin.Enabled = false;

            // Attach validation for both fields
            txtEmail.TextChanged += ValidateLoginInputs;
            txtPassword.TextChanged += ValidateLoginInputs;
        }
        private void ValidateLoginInputs(object sender, EventArgs e)
        {
            // Enable login button only when both fields are filled
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                               !string.IsNullOrWhiteSpace(txtPassword.Text);
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = ComboLanguage.SelectedItem.ToString();

            if (selectedLanguage == "Malay")
            {
                // Malay translations
                lblTitle.Text = "Selamat Datang ke SedapMakan Restaurant";
                lnkSignUP.Text = "DAFTAR";
                lblEmail.Text = "Emel:";
                lblPassword.Text = "🔒 Kata Laluan:";
                lnkForgotPass.Text = "LUPA KATA LALUAN?";
                lnkNeedHelp.Text = "PERLU BANTUAN?";
                btnLogin.Text = "Log Masuk";
                btnClear.Text = "Kosongkan";
                btnExit.Text = "Keluar";
                lblDontHaveAccount.Text = "Tiada akaun?";

            }
            else
            {
                // English (default)
                lblTitle.Text = "Welcome to SedapMakan Restaurant";
                lnkSignUP.Text = "SIGN UP";
                lblEmail.Text = "Email:";
                lblPassword.Text = "🔒 Password:";
                lnkForgotPass.Text = "FORGOT PASSWORD?";
                lnkNeedHelp.Text = "NEED HELP?";
                btnLogin.Text = "Login";
                btnClear.Text = "Clear";
                btnExit.Text = "EXIT";
                lblDontHaveAccount.Text = "Don't have an account?";

            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void lnkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide Loginfrom
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm(); // Open forgotPasswordForm
            forgotPasswordForm.FormClosed += (s, args) => this.Show(); // Show LoginForm again when forgotpasswordform is closed
            forgotPasswordForm.Show();
        }

        private void btnNeedHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide LoginForm
            HelpForm helpForm = new HelpForm(); // Open HelpForm
            helpForm.FormClosed += (s, args) => this.Show(); // Show LoginForm again when HelpForm is closed
            helpForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkSignUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide LoginForm
            SignUpFrom signUpForm = new SignUpFrom(); // Open SignUpForm
            signUpForm.FormClosed += (s, args) => this.Show(); // Show LoginForm again when SignUpForm is closed
            signUpForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShowPss.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                butnCashPass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            try
            {
                User user = new User();
                var (userId, role) = user.Login(email, password);

                if (userId > 0)
                {
                    // Navigate based on user role
                    switch (role.ToLower())
                    {
                        case "system admin":
                            formAdminDashboard adminForm = new formAdminDashboard(userId);
                            adminForm.Show();
                            break;

                        case "manager":
                            ManagerDashboard managerForm = new ManagerDashboard(userId);
                            managerForm.Show();
                            break;

                        case "chef":
                            ChefDashboardForm chefForm = new ChefDashboardForm(userId);
                            chefForm.Show();
                            break;

                        case "customer":
                            CustomerDashboardForm customerForm = new CustomerDashboardForm(userId);
                            customerForm.Show();
                            break;

                        default:
                            MessageBox.Show("Unknown role. Access denied.");
                            return;
                    }

                    this.Hide(); // Hide login form after successful login
                }
                else
                {
                    MessageBox.Show("Invalid login credentials.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }


    }
}




    
