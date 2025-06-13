using SedapmakanCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class FormOrderManagement: Form
    {
        private Form dashboard;

        public FormOrderManagement(Form callingForm)
        {
            InitializeComponent();
            dashboard = callingForm;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            dgvOrders.CellClick += dgvOrders_CellClick;
        }

        private void SetupOrderGridButtons()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.AutoGenerateColumns = false;

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "order_id",
                HeaderText = "Order ID",
                DataPropertyName = "order_id"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Item_Name",
                HeaderText = "Item",
                DataPropertyName = "Item_Name"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "price",
                HeaderText = "Price (RM)",
                DataPropertyName = "price"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "status",
                HeaderText = "Status",
                DataPropertyName = "status"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "refund_status",
                HeaderText = "Refund Status",
                DataPropertyName = "refund_status"
            });

            dgvOrders.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Cancel",
                HeaderText = "",
                Text = "Cancel",
                UseColumnTextForButtonValue = true
            });

            dgvOrders.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Refund",
                HeaderText = "",
                Text = "Request Refund",
                UseColumnTextForButtonValue = true,
                Width = 120
            });
        }

        private void FormOrderManagement_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("-- Select Status --");
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("In Progress");
            cmbStatusFilter.SelectedIndex = 0;

            SetupOrderGridButtons();  // ✅ Setup grid columns
            DisplayOrders();          // ✅ Show real data
        }

        private void picgoback3_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard.Show();
        }

        private void DisplayOrders()
        {
            Customer cust = new Customer();
            DataTable orders = cust.GetOrders(Session.UserId);

            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString();

            if (selectedStatus != "All" && selectedStatus != "-- Select Status --")
            {
                orders.DefaultView.RowFilter = $"status = '{selectedStatus}'";
            }

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders;
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOrders(); // re-load based on selected status
        }

        private void btnGoToMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current OrderManagement form
            FormMenuBrowse menuForm = new FormMenuBrowse(this); // Pass this form as reference
            menuForm.Show();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string column = dgvOrders.Columns[e.ColumnIndex].Name;
            int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["order_id"].Value);

            string refundStatus = dgvOrders.Rows[e.RowIndex].Cells["refund_status"].Value?.ToString();
            Customer cust = new Customer();
            string message = "";

            if (column == "Cancel")
            {
                message = cust.CancelOrder(orderId);
            }
            else if (column == "Refund")
            {
                // ❗ Check if refund already requested
                if (!string.IsNullOrWhiteSpace(refundStatus) && refundStatus != "N/A")
                {
                    MessageBox.Show("Refund has already been requested for this order.", "Already Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Prompt user for refund reason
                string reason = Microsoft.VisualBasic.Interaction.InputBox(
                    "Please enter a reason for your refund request:",
                    "Refund Reason",
                    "e.g., Item was incorrect or not delivered");

                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("Refund request cancelled. Reason is required.", "Refund Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                message = cust.RequestRefund(orderId, reason);
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }

            DisplayOrders(); // ✅ Refresh the list to update refund_status
        }
    }
}
