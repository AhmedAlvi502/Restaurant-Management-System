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
    public partial class RefundHandler: Form
        
    {
        private int userId;
        Manager manager = new Manager();
        public RefundHandler(int id)
        {
            InitializeComponent();
            dgvRefunds.AutoGenerateColumns = true;
            userId = id;

            LoadRefunds();
        }
        //this method is called when the approve button is clicked
        // it checks if a refund request is selected, and if so, it processes the refund as approved
        private void btnApprove_Click(object sender, EventArgs e)
        {

            if(dgvRefunds.SelectedRows.Count == 0)
    {
                MessageBox.Show("Please select a refund request.");
                return;
            }

            int refundId = Convert.ToInt32(dgvRefunds.SelectedRows[0].Cells["refund_id"].Value);
            int managerId = 1; // Hardcoded

            try
            {
                manager.ProcessRefund(refundId, "Approved", managerId);
                MessageBox.Show("Refund approved!");
                LoadRefunds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        // this method loads the refunds from the database and binds them to the DataGridView
        private void LoadRefunds()
        {
            DataTable dt = manager.GetPendingRefunds();

            dgvRefunds.DataSource = dt;
            dgvRefunds.Columns["reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            if (dgvRefunds.Rows.Count > 0)
            {
                dgvRefunds.Rows[0].Selected = true;
            }
        }
        // this method is called when the form loads, it initializes the DataGridView and loads the refunds
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRefunds();
        }
        // this method is called when the reject button is clicked
        // it checks if a refund request is selected, and if so, it processes the refund as rejected
        private void btnRejct_Click(object sender, EventArgs e)
        {

            if (dgvRefunds.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request.");
                return;
            }

            int refundId = Convert.ToInt32(dgvRefunds.SelectedRows[0].Cells["refund_id"].Value);
            int managerId = userId; // Use the logged-in manager's ID

            try
            {
                manager.ProcessRefund(refundId, "Rejected", managerId);
                MessageBox.Show("Refund rejected!");
                LoadRefunds();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // this method is called when the Go Back button is clicked
        // it opens the ManagerDashboard form and closes the current form
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            ManagerDashboard dashboard = new ManagerDashboard(userId);
            dashboard.Show();
            this.Close();
        }
    }
}
