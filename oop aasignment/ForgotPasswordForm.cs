using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class ForgotPasswordForm : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";
        private string currentEmail;
        private string correctSecretAnswer;

        public ForgotPasswordForm()
        {
            InitializeComponent();

            txtNewpass.TextChanged += ValidateInputs;
            txtConfirmpass.TextChanged += ValidateInputs;
            txtSecret.TextChanged += ValidateInputs;
            txtEmail.TextChanged += ValidateInputs;
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            btnSumbit.Enabled = !string.IsNullOrWhiteSpace(txtNewpass.Text) &&
                                !string.IsNullOrWhiteSpace(txtConfirmpass.Text);
            btnNext2.Enabled = !string.IsNullOrWhiteSpace(txtSecret.Text);
            btnNext1.Enabled = !string.IsNullOrWhiteSpace(txtEmail.Text);
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT secret_answer FROM users WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    currentEmail = email;
                    correctSecretAnswer = reader["secret_answer"].ToString();

                    lblEmailNotFound.Text = "";
                    panelStep1.Visible = false;
                    panelStep2.Visible = true;
                    panelStep3.Visible = false;

                    btnStep1.BackColor = Color.Gray;
                    btnStep2.BackColor = Color.Blue;
                    btnStep3.BackColor = Color.Gray;
                }
                else
                {
                    lblEmailNotFound.Text = "Email not found.";
                }
            }
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            string answer = txtSecret.Text.Trim();

            if (!string.Equals(answer, correctSecretAnswer, StringComparison.OrdinalIgnoreCase))
            {
                lblSecretAnswerFault.Text = "Incorrect answer.";
                return;
            }

            lblSecretAnswerFault.Text = "";

            panelStep1.Visible = false;
            panelStep2.Visible = false;
            panelStep3.Visible = true;

            btnStep1.BackColor = Color.Gray;
            btnStep2.BackColor = Color.Gray;
            btnStep3.BackColor = Color.Blue;
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewpass.Text.Trim();
            string confirmPassword = txtConfirmpass.Text.Trim();

            // Validate password strength
            if (newPassword.Length < 8 || !Regex.IsMatch(newPassword, @"\d"))
            {
                MessageBox.Show("Password must be at least 8 characters and include at least one digit.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Match check
            if (newPassword != confirmPassword)
            {
                lblNotMatching.Text = "❌ Passwords don’t match.";
                lblNotMatching.Visible = true;
                return;
            }

            lblNotMatching.Visible = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE users SET password = @Password WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Email", currentEmail);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed successfully!");

                    txtEmail.Clear();
                    txtSecret.Clear();
                    txtNewpass.Clear();
                    txtConfirmpass.Clear();

                    panelStep1.Visible = true;
                    panelStep2.Visible = false;
                    panelStep3.Visible = false;

                    btnStep1.BackColor = Color.Blue;
                    btnStep2.BackColor = Color.Gray;
                    btnStep3.BackColor = Color.Gray;

                    this.Close(); // Optional
                }
                else
                {
                    MessageBox.Show("Error updating password. Try again.");
                }
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            panelStep1.Visible = true;
            panelStep2.Visible = false;
            panelStep3.Visible = false;

            btnStep1.BackColor = Color.Blue;
            btnStep2.BackColor = Color.Gray;
            btnStep3.BackColor = Color.Gray;
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            panelStep1.Visible = false;
            panelStep2.Visible = true;
            panelStep3.Visible = false;

            btnStep1.BackColor = Color.Gray;
            btnStep2.BackColor = Color.Blue;
            btnStep3.BackColor = Color.Gray;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
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

        // Optional empty event handlers
        private void ForgotPasswordForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblEmailNotFound_Click(object sender, EventArgs e) { }
        private void lblSecretAnswerFault_Click(object sender, EventArgs e) { }
        private void lblNotMatching_Click(object sender, EventArgs e) { }
        private void panelStep3_Paint(object sender, PaintEventArgs e) { }
    }
}

