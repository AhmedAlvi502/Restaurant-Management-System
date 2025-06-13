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
        Customer cust = new Customer();

        // (if you store Session.Email from login)


        public FormFeedback(Form callingForm)
        {
            InitializeComponent();
            dashboard = callingForm;
        }

        private void picgoback5_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }

        private void FormFeedback_Load(object sender, EventArgs e)
        {
            txtName.Text = Session.CustomerName;
            txtEmail.Text = Session.CustomerEmail;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtFeedback.Text = "Type your feedback here...";
            txtFeedback.ForeColor = Color.Gray;

            cmbType.Items.AddRange(new[] { "Complaint", "Suggestion", "Praise", "Other" });
            cmbType.SelectedIndex = 0;

            lblStatus.Text = "";
            dgvPreviousFeedback.AutoGenerateColumns = true;

            pnlPrevious.Visible = false;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
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
            string msg = cust.SubmitFeedback(Session.UserId, content);

            MessageBox.Show(msg, "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblStatus.Text = "Thanks for your feedback!";
            lblStatus.ForeColor = Color.Green;

            // Reset UI
            txtFeedback.Text = "Type your feedback here...";
            txtFeedback.ForeColor = Color.Gray;
            cmbType.SelectedIndex = 0;

            LoadPreviousFeedbacks();  // refresh history grid
        }




        private void txtFeedback_Enter(object sender, EventArgs e)
        {
            if (txtFeedback.Text == "Type your feedback here...")
            {
                txtFeedback.Text = "";
                txtFeedback.ForeColor = Color.Black;
            }
        }

        private void txtFeedback_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                txtFeedback.Text = "Type your feedback here...";
                txtFeedback.ForeColor = Color.Gray;
            }
        }

        private void btnViewFeedbacks_Click(object sender, EventArgs e)
        {
            pnlPrevious.Visible = !pnlPrevious.Visible;
            if (pnlPrevious.Visible)
                LoadPreviousFeedbacks();
        }
        private void LoadPreviousFeedbacks()
        {
            Customer cust = new Customer();
            DataTable dt = cust.GetPreviousFeedbacks(Session.UserId);

            dgvPreviousFeedback.DataSource = null;
            dgvPreviousFeedback.DataSource = dt;
        }

    }
}
