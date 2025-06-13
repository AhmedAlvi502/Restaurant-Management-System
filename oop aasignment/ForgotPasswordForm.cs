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
    public partial class ForgotPasswordForm: Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();


            // Attach validation for both fields
            txtNewpass.TextChanged += ValidateLoginInputs;
            txtConfirmpass.TextChanged += ValidateLoginInputs;
            txtSecret.TextChanged += ValidateLoginInputs;
            txtEmail.TextChanged += ValidateLoginInputs;

        }
        
 
        private void ValidateLoginInputs(object sender, EventArgs e)
        {
            btnSumbit.Enabled = !string.IsNullOrWhiteSpace(txtNewpass.Text) &&
                               !string.IsNullOrWhiteSpace(txtConfirmpass.Text);         
            btnNext2.Enabled = !string.IsNullOrWhiteSpace(txtSecret.Text);
            btnNext1.Enabled = !string.IsNullOrWhiteSpace(txtEmail.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void lblEmailNotFound_Click(object sender, EventArgs e)
        { 

        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            {
 
                string email = txtEmail.Text.Trim();
                // Check if email matches the specific email
                if (email != "smed25653@gmail.com")
                {
                    lblEmailNotFound.Text = "Email not found.";
                    return;
                }

                // Clear message if email is valid
                lblEmailNotFound.Text = "";

                // Hide Step 1, show Step 2
                panelStep1.Visible = false;
                panelStep2.Visible = true;
                panelStep3.Visible = false;

                // Set btnStep1 to gray, btnStep2 to blue
                btnStep1.BackColor = System.Drawing.Color.Gray;
                btnStep2.BackColor = System.Drawing.Color.Blue;
                btnStep3.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void lblSecretAnswerFault_Click(object sender, EventArgs e)
        {

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {

           
            string secretAnswer = txtSecret.Text.Trim();

            // Check if secret answer matches "Marry Ting"
            if (secretAnswer != "Mary Ting")
            {
                lblSecretAnswerFault.Text = "Incorrect answer.";
                return;
            }

            // Clear message if answer is correct
            lblSecretAnswerFault.Text = "";

            // Move to Step 3
            panelStep1.Visible = false;
            panelStep2.Visible = false;
            panelStep3.Visible = true;

            // Highlight Step 3
            btnStep1.BackColor = System.Drawing.Color.Gray;
            btnStep2.BackColor = System.Drawing.Color.Gray;
            btnStep3.BackColor = System.Drawing.Color.Blue;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            // Go back to Step 1
            panelStep1.Visible = true;
            panelStep2.Visible = false;
            panelStep3.Visible = false;

            // Highlight Step 1
            btnStep1.BackColor = System.Drawing.Color.Blue;
            btnStep2.BackColor = System.Drawing.Color.Gray;
            btnStep3.BackColor = System.Drawing.Color.Gray;
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            // Go back to Step 2
            panelStep1.Visible = false;
            panelStep2.Visible = true;
            panelStep3.Visible = false;

            // Highlight Step 2
            btnStep1.BackColor = System.Drawing.Color.Gray;
            btnStep2.BackColor = System.Drawing.Color.Blue;
            btnStep3.BackColor = System.Drawing.Color.Gray;
        }

        private void lblNotMatching_Click(object sender, EventArgs e)
        {

        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {

            // Check if either password is empty
            string newPassword = txtNewpass.Text.Trim();
            string confirmPassword = txtConfirmpass.Text.Trim();
            if (txtNewpass.Text == txtConfirmpass.Text)
            {
                MessageBox.Show("Password changed successfully!");
            }
            if (txtNewpass.Text != txtConfirmpass.Text)
            {
                lblNotMatching.Text = "❌ Passwords don’t match.";
                lblNotMatching.Visible = true;
                return;
            }
            // Reset the form
            panelStep1.Visible = true;
            panelStep2.Visible = false;
            panelStep3.Visible = false;

            btnStep1.BackColor = System.Drawing.Color.Blue;
            btnStep2.BackColor = System.Drawing.Color.Gray;
            btnStep3.BackColor = System.Drawing.Color.Gray;

            txtEmail.Text = "";
            txtSecret.Text = "";
            txtNewpass.Text = "";
            txtConfirmpass.Text = "";
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close(); // Close ForgotPasswordForm
        }

        private void panelStep3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPss_Click(object sender, EventArgs e)
        {
            if (txtNewpass.PasswordChar == '\0')
            {
                butnCashPass.BringToFront();
                txtNewpass.PasswordChar = '*';
            }
        }

        private void butnCashPass_Click(object sender, EventArgs e)
        {
            if (txtNewpass.PasswordChar == '*')
            {
                btnShowPss.BringToFront();
                txtNewpass.PasswordChar = '\0';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtConfirmpass.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '*')
            {
                button4.BringToFront();
                txtConfirmpass.PasswordChar = '\0';
            }
        }
    }
}
