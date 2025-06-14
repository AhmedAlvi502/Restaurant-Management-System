using System;
using System.Data;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class ViewOrdersForm : Form
    {
        Chef chef = new Chef();
        private readonly int chefId;
        private readonly string chefCategory;

        public ViewOrdersForm(int loggedInChefId)
        {
            InitializeComponent();
            chefId = loggedInChefId;
            chefCategory = chef.GetCategoryByChefId(chefId); // Get category based on login
        }

        /// <summary>
        /// Loads only the orders that include items for this chef's category.
        /// </summary>
        private void LoadOrders()
        {
            dgvOrders.DataSource = chef.GetOrdersByCategory(chefCategory); // Filtered by chef category
            dgvOrders.ClearSelection();
            cmbStatus.SelectedIndex = -1;
            dgvOrders.CellClick += dgvOrders_CellClick;

        }



        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        /// <summary>
        /// Updates the status of the selected order (e.g., Completed).
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.CurrentRow.Cells["order_id"].Value);
            string newStatus = cmbStatus.Text;

            string result = chef.UpdateOrderStatus(orderId, newStatus);
            MessageBox.Show(result);

            if (result == "Order status updated.")
            {
                LoadOrders();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrders.Rows[e.RowIndex] != null)
            {
                DataGridViewRow selectedRow = dgvOrders.Rows[e.RowIndex];

                object statusValue = selectedRow.Cells["status"].Value;
                if (statusValue != null)
                {
                    cmbStatus.SelectedItem = statusValue.ToString();
                }
                else
                {
                    cmbStatus.SelectedIndex = -1;
                }
            }
        }

    }
}