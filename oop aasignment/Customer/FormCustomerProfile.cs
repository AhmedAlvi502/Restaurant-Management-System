using SedapmakanCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oop_aasignment
{
    public partial class FormCustomerProfile : Form
    {
        // ✅ Step 1: Store reference to the dashboard
        private Form dashboard;

        // ✅ Step 2: Constructor accepts the calling form
        public FormCustomerProfile(Form callingForm)
        {
            InitializeComponent();
            dashboard = callingForm;
        }


        Customer cust = new Customer();
        private void FormCustomerProfile_Load(object sender, EventArgs e)
        {
            DataTable dt = cust.GetProfile(Session.UserId);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["full_name"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhone.Text = dt.Rows[0]["phone_number"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
            }

            SetEditable(false);
            txtPassword.UseSystemPasswordChar = true;
        }
        private void LoadCustomerData()
        {
            DataTable dt = cust.GetProfile(Session.UserId);
            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["full_name"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtPhone.Text = dt.Rows[0]["phone_number"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();
            }
        }


        private void SetEditable(bool isEditable)
        {
            txtName.ReadOnly = !isEditable;
            txtEmail.ReadOnly = !isEditable;
            txtPhone.ReadOnly = !isEditable;
            txtPassword.ReadOnly = !isEditable;

            btnSave.Visible = isEditable;
            btnCancel.Visible = isEditable;
            btnEdit.Visible = !isEditable;
        }

        // ✅ Step 3: Go Back PictureBox click event
        private void picgoback1_Click(object sender, EventArgs e)
        {
            this.Close();        // Close profile form
            dashboard.Show();    // Show dashboard again
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditable(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
            SetEditable(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = cust.UpdateProfile(Session.UserId, txtName.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), txtPassword.Text);
            lblStatus.Text = msg;
            lblStatus.ForeColor = Color.Green;
            SetEditable(false);

            DialogResult result = MessageBox.Show("Are you sure you want to save changes?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lblStatus.Text = "Profile updated!";
                lblStatus.ForeColor = Color.Green;
                lblStatus.Visible = true; // ✅ Show label
                SetEditable(false);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void btnEditSecurity_Click(object sender, EventArgs e)
        {
            pnlSecurity.Visible = true;
            pnlMain.Visible = false;
            btnEditSecurity.Visible = false; // ✅ Hide the button while editing
        }


        private void btnCancelSecurity_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveSecurity_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtConfirmPassword.Text;
            string actualPassword = txtPassword.Text;

            if (enteredPassword != actualPassword)
            {
                MessageBox.Show("Incorrect password. Access denied.");
                return;
            }

            string question = txtSecretQuestion.Text.Trim();
            string answer = txtSecretAnswer.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please fill in both the question and the answer.");
                return;
            }

            // Simulate saving security info 
            string msg = cust.UpdateSecurityInfo(Session.UserId, question, answer);
            MessageBox.Show(msg);
            txtSecretQuestion.Clear();
            txtSecretAnswer.Clear();
            txtConfirmPassword.Clear();
            pnlSecurity.Visible = false;
            pnlMain.Visible = true;
            btnEditSecurity.Visible = true;
        }


        private void btnCancelSecurity_Click(object sender, EventArgs e)
        {
            txtSecretQuestion.Clear();
            txtSecretAnswer.Clear();
            txtConfirmPassword.Clear();
            pnlSecurity.Visible = false;
            pnlMain.Visible = true;
            btnEditSecurity.Visible = true; // ✅ Show again
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, control characters (e.g. Backspace), and space
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }



        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
