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
    public partial class FormMenuBrowse: Form
    {
        private Form dashboard;

        private List<CartItem> cart = new List<CartItem>();

        public FormMenuBrowse(Form callingForm)
        {
            InitializeComponent();
            dashboard = callingForm;
        }

        private void FormMenuBrowse_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Search food...";
            txtSearch.ForeColor = Color.Gray;
            LoadCategories();
            dgvMenu.DataSource = null; // show nothing initially
            lblWalletBalance.Text = $"Wallet: RM {Session.WalletBalance:F2}";
        }
        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("-- Select Category --");
            cmbCategory.Items.Add("All");

            Customer cust = new Customer();
            List<string> dbCategories = cust.GetDistinctCategories();

            foreach (var cat in dbCategories)
            {
                cmbCategory.Items.Add(cat);
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void LoadMenuItems()
        {
            Customer cust = new Customer();
            DataTable allItems = cust.GetAllMenuItems(); // ✅ Get raw data
            DataView view = allItems.DefaultView;

            string category = cmbCategory.SelectedItem?.ToString();
            string search = txtSearch.Text.Trim().ToLower();

            if (search == "search food...") search = "";

            string filter = "";

            // 🗂️ Filter by category
            if (category == "-- Select Category --")
            {
                dgvMenu.DataSource = null;
                return;
            }
            else if (category != "All")
            {
                filter += $"category = '{category}'";
            }

            // 🔍 Filter by search text
            if (!string.IsNullOrWhiteSpace(search))
            {
                if (!string.IsNullOrWhiteSpace(filter))
                    filter += " AND ";

                filter += $"Item_Name LIKE '{search}%'";
            }

            view.RowFilter = filter;
            dgvMenu.DataSource = view;
            if (dgvMenu.Columns.Contains("menu_id"))
            {
                dgvMenu.Columns["menu_id"].Visible = false;
            }


            // ✅ Add readable availability column if not added yet
            if (!dgvMenu.Columns.Contains("AvailabilityText"))
            {
                dgvMenu.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "AvailabilityText",
                    HeaderText = "Availability",
                    ReadOnly = true
                });
            }

            // ✅ Populate AvailabilityText column
            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                var val = row.Cells["availability"].Value;
                if (val != null && val != DBNull.Value)
                {
                    bool isAvailable = Convert.ToBoolean(val);
                    row.Cells["AvailabilityText"].Value = isAvailable ? "Available" : "Unavailable";
                }
            }

            // ✅ Hide raw boolean column for cleaner UI
            if (dgvMenu.Columns.Contains("availability"))
            {
                dgvMenu.Columns["availability"].Visible = false;
            }
        }




        private void picgoback2_Click(object sender, EventArgs e)
        {
            this.Close();        // Close this form
            dashboard.Show();    // Show dashboard
        }


        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search food...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search food...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadMenuItems();  // ✅ now loads from MySQL!
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if it's the "Add" button column and not the header
            if (dgvMenu.Columns[e.ColumnIndex].Name == "Add" && e.RowIndex >= 0)
            {
                int menuId = Convert.ToInt32(dgvMenu.Rows[e.RowIndex].Cells["menu_id"].Value);
                string itemName = dgvMenu.Rows[e.RowIndex].Cells["Item_Name"].Value.ToString();
                string category = dgvMenu.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvMenu.Rows[e.RowIndex].Cells["Price"].Value);
                bool isAvailable = Convert.ToBoolean(dgvMenu.Rows[e.RowIndex].Cells["Availability"].Value);

                if (!isAvailable)
                {
                    MessageBox.Show("Sorry, this item is currently unavailable.");
                    return;
                }

                CartItem item = new CartItem
                {
                    MenuId = menuId, // ✅ Must include this for order to work
                    ItemName = itemName,
                    Category = category,
                    Price = price
                };

                cart.Add(item);
                MessageBox.Show($"{itemName} added to cart.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Update total immediately after adding
                decimal total = cart.Sum(x => x.Price);
                lblCartTotal.Text = $"Total: RM {total:F2}";
                lblCartTotal.Visible = true;
            }
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            decimal total = cart.Sum(x => x.Price);

            if (total > Session.WalletBalance)
            {
                MessageBox.Show($"Insufficient balance. Your wallet has only RM {Session.WalletBalance:F2}.", "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Place order in database
            Customer cust = new Customer();
            string result = cust.PlaceOrder(Session.UserId, cart);

            if (result != "Order placed!")
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Deduct wallet in database
            string walletResult = cust.DeductWalletBalance(Session.UserId, total);
            if (walletResult != "Wallet deducted.")
            {
                MessageBox.Show(walletResult, "Wallet Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Update session and label
            Session.WalletBalance -= total;
            lblWalletBalance.Text = $"Wallet: RM {Session.WalletBalance:F2}";

            // ✅ Success message
            MessageBox.Show($"Order placed successfully!\nRM {total:F2} has been deducted from your wallet.", "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ Reset UI
            cart.Clear();
            pnlCart.Visible = false;
            dgvMenu.Visible = true;
            btnViewCart.Visible = true;
            cmbCategory.Visible = true;
            txtSearch.Visible = true;
            btnFilter.Visible = true;
            dgvCart.Visible = false;
            btnPlaceOrder.Visible = false;

            lblCartTotal.Text = "Total: RM 0.00";
            lblCartTotal.Visible = true;
        }


        private void btnViewCart_Click(object sender, EventArgs e)
        {
            pnlCart.Visible = true;

            if (cart.Count == 0)
            {
                lblCartTotal.Text = "Your cart is empty.";
                lblCartTotal.Visible = true;
                dgvCart.Visible = false;
                btnPlaceOrder.Visible = false;
            }
            else
            {
                dgvCart.DataSource = null;
                dgvCart.DataSource = cart;

                // ✅ Add "Remove" button column only if not already added
                if (!dgvCart.Columns.Contains("Remove"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "";
                    btn.Name = "Remove";
                    btn.Text = "Remove";
                    btn.UseColumnTextForButtonValue = true;
                    dgvCart.Columns.Add(btn);
                }

                // ✅ Hide menu ID from customer view
                if (dgvCart.Columns.Contains("MenuId"))
                {
                    dgvCart.Columns["MenuId"].Visible = false;
                }

                dgvCart.Visible = true;

                decimal total = cart.Sum(x => x.Price);
                lblCartTotal.Text = $"Total: RM {total:F2}";
                lblCartTotal.Visible = true;
                btnPlaceOrder.Visible = true;
            }

            // Hide menu controls
            dgvMenu.Visible = true;
            btnViewCart.Visible = false;
            cmbCategory.Visible = false;
            txtSearch.Visible = false;
            btnFilter.Visible = false;
        }



        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            pnlCart.Visible = false;

            // Show back all
            dgvMenu.Visible = true;
            btnViewCart.Visible = true;
            cmbCategory.Visible = true;
            txtSearch.Visible = true;
            btnFilter.Visible = true;
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "Remove")
            {
                try
                {
                    string itemName = dgvCart.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
                    CartItem itemToRemove = cart.FirstOrDefault(x => x.ItemName == itemName);

                    if (itemToRemove != null)
                    {
                        cart.Remove(itemToRemove);

                        dgvCart.DataSource = null;
                        dgvCart.DataSource = cart;

                        decimal total = cart.Sum(x => x.Price);
                        lblCartTotal.Text = $"Total: RM {total:F2}";

                        // Optional: hide menu_id again
                        if (dgvCart.Columns.Contains("MenuId"))
                            dgvCart.Columns["MenuId"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while removing item: " + ex.Message);
                }
            }
        }
    }
}
