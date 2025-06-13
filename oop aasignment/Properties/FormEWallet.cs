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



namespace SedapmakanCustomer.Forms
{
    public partial class FormEWallet : Form
    {
        private Form dashboard;  // ✅ Store dashboard reference
        public FormEWallet(Form callingForm)  // ✅ Accept dashboard in constructor
        {
            InitializeComponent();
            dashboard = callingForm;
            lblBalance.Text = $"RM {Session.WalletBalance:F2}";
            pnlTopUp.Visible = false;
            lblStatus.Text = "";
        }

        private void picgoback4_Click(object sender, EventArgs e)
        {
            this.Close();         // Close wallet form
            dashboard.Show();     // Show dashboard again
        }

        private void FormEWallet_Load(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            decimal balance = cust.GetWalletBalance(Session.UserId);
            dgvHistory.DataSource = cust.GetTransactionHistory(Session.UserId);
            Session.WalletBalance = balance;  // update session

            lblBalance.Text = $"RM {balance:F2}";
            pnlTopUp.Visible = false;
            lblStatus.Text = "";
            cmbMethod.Items.AddRange(new[] { "Credit/Debit Card", "Online Banking", "Touch'n Go", "Grab Pay" });
            cmbMethod.SelectedIndex = -1;

            SetupTransactionHistoryGrid();
        }

        private void SetupTransactionHistoryGrid()
        {
            dgvHistory.Columns.Clear(); // Clear existing columns (if any)

            dgvHistory.AutoGenerateColumns = false; // Prevent auto-generation

            // Column 1: Date
            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.Name = "Date";
            colDate.HeaderText = "Date";
            colDate.DataPropertyName = "Date";
            colDate.Width = 120;
            dgvHistory.Columns.Add(colDate);

            // Column 2: Amount
            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.Name = "Amount";
            colAmount.HeaderText = "Amount (RM)";
            colAmount.DataPropertyName = "Amount";
            colAmount.Width = 100;
            dgvHistory.Columns.Add(colAmount);

            // Column 3: Method
            DataGridViewTextBoxColumn colMethod = new DataGridViewTextBoxColumn();
            colMethod.Name = "Method";
            colMethod.HeaderText = "Payment Method";
            colMethod.DataPropertyName = "Method";
            colMethod.Width = 120;
            dgvHistory.Columns.Add(colMethod);

            // Column 4: Status
            DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "Status";
            colStatus.HeaderText = "Status";
            colStatus.DataPropertyName = "Status";
            colStatus.Width = 80;
            dgvHistory.Columns.Add(colStatus);

            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            pnlTopUp.Visible = true;

            // ✅ Clear message and color
            lblTopUpMessage.Text = "";
            lblTopUpMessage.ForeColor = SystemColors.ControlText; // Resets to default label color

            // ✅ Hide status label if needed
            lblStatus.Text = "";
            lblStatus.ForeColor = SystemColors.ControlText;

            // ✅ Clear input fields
            txtTopUpAmount.Clear();
            txtTopUpPassword.Clear();
            cmbMethod.SelectedIndex = -1;
        }



        private void btnCancelTopUp_Click(object sender, EventArgs e)
        {
            pnlTopUp.Visible = false;
        }

        private async void btnConfirmTopUp_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTopUpAmount.Text, out decimal amount) || amount <= 0)
            {
                lblTopUpMessage.Text = "Enter a valid amount.";
                lblTopUpMessage.ForeColor = Color.Red;
                return;
            }

            if (cmbMethod.SelectedIndex == -1)
            {
                lblTopUpMessage.Text = "Please select a payment method.";
                lblTopUpMessage.ForeColor = Color.Red;
                return;
            }

            if (txtTopUpPassword.Text != Session.UserPassword)
            {
                lblTopUpMessage.Text = "Incorrect password.";
                lblTopUpMessage.ForeColor = Color.Red;
                return;
            }

            // 🕐 Show "Processing" dialog
            Form processingForm = new Form()
            {
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ControlBox = false,
                Width = 250,
                Height = 100,
                Text = "Please wait..."
            };

            Label lbl = new Label()
            {
                Text = "Processing top-up...",
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            processingForm.Controls.Add(lbl);

            // Show dialog in non-blocking way
            Task showDialogTask = Task.Run(() => processingForm.ShowDialog());

            // Simulate processing delay (at least 1 sec)
            await Task.Delay(1000);

            // 🟢 Run top-up logic
            Customer cust = new Customer();
            string result = cust.TopUpEWallet(Session.UserId, amount, cmbMethod.SelectedItem.ToString());

            processingForm.Invoke((MethodInvoker)(() => processingForm.Close()));            // Close processing dialog safely

            // ✅ Handle result
            if (result == "Top-up successful!")
            {
                decimal newBalance = cust.GetWalletBalance(Session.UserId);
                Session.WalletBalance = newBalance;

                lblBalance.Text = $"RM {newBalance:F2}";
                lblStatus.Text = "Top-up successful!";
                lblStatus.ForeColor = Color.Green;

                lblTopUpMessage.Text = result;
                lblTopUpMessage.ForeColor = Color.Green;

                dgvHistory.DataSource = null;
                dgvHistory.DataSource = cust.GetTransactionHistory(Session.UserId);

                MessageBox.Show("Top-up completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblTopUpMessage.Text = result;
                lblTopUpMessage.ForeColor = Color.Red;
                MessageBox.Show("Top-up failed: " + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pnlTopUp.Visible = false;
        }



        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtTopUpPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        
    }
}
