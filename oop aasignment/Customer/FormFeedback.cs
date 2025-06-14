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
    public partial class FormFeedback: Form
    {
        private Form dashboard;
        Customer cust = new Customer(); // Instance of Customer class for DB operations

        // (if you store Session.Email from login)


        public FormFeedback(Form callingForm)
        {
            InitializeComponent();
            dashboard = callingForm;
        }

        private void picgoback5_Click(object sender, EventArgs e) // Go Back icon click: closes this form and returns to dashboard.
        {
            this.Close();
            dashboard.Show();
        }

        private void FormFeedback_Load(object sender, EventArgs e) // On form load: sets up initial state and populates session data if missing.
        {
            // Fallback: if name/email not in session, fetch from DB
            if (string.IsNullOrWhiteSpace(Session.CustomerName) || string.IsNullOrWhiteSpace(Session.CustomerEmail))
            {
                DataTable dt = cust.GetProfile(Session.UserId);
                if (dt.Rows.Count > 0)
                {
                    Session.CustomerName = dt.Rows[0]["full_name"].ToString();
                    Session.CustomerEmail = dt.Rows[0]["email"].ToString();
                }
            }
            // Pre-fill name and email fields (read-only)
            txtName.Text = Session.CustomerName; 
            txtEmail.Text = Session.CustomerEmail;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtFeedback.Text = "Type your feedback here...";
            txtFeedback.ForeColor = Color.Gray;
            // Populate feedback types in combo box
            cmbType.Items.AddRange(new[] { "Complaint", "Suggestion", "Praise", "Other" });
            cmbType.SelectedIndex = 0;

            lblStatus.Text = "";
            dgvPreviousFeedback.AutoGenerateColumns = true; // Automatically map columns
            pnlPrevious.Visible = false;
        }



        private void btnSubmit_Click(object sender, EventArgs e) // Submits the feedback to the database after validating input.
        {
            string type = cmbType.SelectedItem.ToString(); 
            string content = txtFeedback.Text.Trim();

            if (string.IsNullOrWhiteSpace(content) || content == "Type your feedback here...")
            {
                lblStatus.Text = "Please enter feedback before submitting.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            Customer cust = new Customer();
            string msg = cust.SubmitFeedback(Session.UserId, content); // Submit feedback to DB

            MessageBox.Show(msg, "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatus.Text = "Thanks for your feedback!";
            lblStatus.ForeColor = Color.Green;

            // Reset UI
            txtFeedback.Text = "Type your feedback here...";
            txtFeedback.ForeColor = Color.Gray;
            cmbType.SelectedIndex = 0;

            LoadPreviousFeedbacks();  // refresh history grid
        }



        // Clears placeholder when user focuses on feedback textbox.
        private void txtFeedback_Enter(object sender, EventArgs e)
        {
            if (txtFeedback.Text == "Type your feedback here...")
            {
                txtFeedback.Text = "";
                txtFeedback.ForeColor = Color.Black;
            }
        }

        private void txtFeedback_Leave(object sender, EventArgs e) // Restores placeholder if textbox is left empty on blur.
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                txtFeedback.Text = "Type your feedback here...";
                txtFeedback.ForeColor = Color.Gray;
            }
        }

        private void btnViewFeedbacks_Click(object sender, EventArgs e) // Toggles visibility of the feedback history panel.
        {
            pnlPrevious.Visible = !pnlPrevious.Visible;
            if (pnlPrevious.Visible)
                LoadPreviousFeedbacks();
        }
        private void LoadPreviousFeedbacks() // Loads all previous feedback submissions into the grid.
        {
            Customer cust = new Customer();
            DataTable dt = cust.GetPreviousFeedbacks(Session.UserId);

            dgvPreviousFeedback.DataSource = null;
            dgvPreviousFeedback.DataSource = dt;
        }

    }
}
