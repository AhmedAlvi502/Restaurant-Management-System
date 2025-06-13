using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace oop_aasignment
{
    public partial class ManageMenuForm : Form
    {
        private int chefId;
        private string chefCategory;
        private Chef chef = new Chef(); // Create instance of Chef class to access backend logic

        // Constructor: called when the form is opened
        public ManageMenuForm(int loggedInChefId)
        {
            InitializeComponent();

            // Fill the availability dropdown options
            cmbAvailability.Items.Clear();
            cmbAvailability.Items.Add("Available");
            cmbAvailability.Items.Add("Not Available");

            // Add key press validations
            txtName.KeyPress += txtName_TextChanged;
            txtPrice.KeyPress += txtPrice_TextChanged;

            // Get the current chef ID and category
            chefId = loggedInChefId;
            chefCategory = chef.GetCategoryByChefId(chefId);
            LockCategoryDropdown();   // Lock the category selection
            LoadMenuItems();          // Load items into table when form loads
            dgvMenuItems.CellClick += dgvMenuItems_CellClick;
            dgvMenuItems.DataBindingComplete += (s, e) => dgvMenuItems.ClearSelection();
        }


        // Lock the food category dropdown so the chef can only manage their own category
        private void LockCategoryDropdown()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add(chefCategory);
            cmbCategory.SelectedIndex = 0;
            cmbCategory.Enabled = false;
        }

        // Load menu items from the database into the DataGridView
        private void LoadMenuItems()
        {
            DataTable dt = chef.GetMenuItems(chefId, chefCategory);
            dgvMenuItems.DataSource = dt;

            dgvMenuItems.ClearSelection();
        }

        // Add a new menu item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string availability = cmbAvailability.SelectedItem?.ToString();

            //  Check for duplicates in DataGridView (case-insensitive)
            foreach (DataGridViewRow row in dgvMenuItems.Rows)
            {
                if (row.Cells["item_name"].Value != null &&
                    row.Cells["item_name"].Value.ToString().Trim().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This item name already exists. Please use a different name.");
                    return;
                }
            }

            // Proceed with add if no duplicates found
            string result = chef.AddMenuItem(name, chefCategory, price, availability, chefId);
            MessageBox.Show(result);

            if (result == "Item added!")
            {
                LoadMenuItems();
            }
        }


        // Edit the selected menu item
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            string newName = txtName.Text.Trim();

            int itemId = Convert.ToInt32(dgvMenuItems.CurrentRow.Cells["menu_id"].Value);

            // Use newName for name update
            string name = newName;

            string price = string.IsNullOrWhiteSpace(txtPrice.Text)
                ? dgvMenuItems.CurrentRow.Cells["price"].Value.ToString()
                : txtPrice.Text;

            string availability = cmbAvailability.SelectedItem != null
                ? cmbAvailability.SelectedItem.ToString()
                : (Convert.ToBoolean(dgvMenuItems.CurrentRow.Cells["availability"].Value) ? "Available" : "Not Available");

            //  Check for duplicate name (excluding current row)
            foreach (DataGridViewRow row in dgvMenuItems.Rows)
            {
                if (row.Index == dgvMenuItems.CurrentRow.Index)
                    continue;

                if (row.Cells["item_name"].Value != null &&
                    row.Cells["item_name"].Value.ToString().Trim().Equals(newName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This item name already exists. Please choose a different name.");
                    return;
                }
            }

            string result = chef.UpdateMenuItem(itemId, name, chefCategory, price, availability);
            MessageBox.Show(result);

            if (result == "Item updated successfully.")
            {
                LoadMenuItems();
                ClearFields();
            }
        }


        // Delete the selected menu item
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            int itemId = Convert.ToInt32(dgvMenuItems.CurrentRow.Cells["menu_id"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            string result = chef.DeleteMenuItem(itemId);
            if (result.StartsWith("Error:"))
            {
                MessageBox.Show(result, "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(result);
                LoadMenuItems();
                ClearFields();
            }
        }


        // Clear the form input fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Method to reset form input fields
        private void ClearFields()
        {
            txtName.Clear();
            txtPrice.Clear();
            cmbAvailability.SelectedIndex = -1;
        }

        // Fill form fields when a row in the table is clicked
        private void dgvMenuItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMenuItems.Rows[e.RowIndex] != null)
            {
                DataGridViewRow selectedRow = dgvMenuItems.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["Item_Name"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                cmbCategory.SelectedItem = selectedRow.Cells["Category"].Value.ToString();

                object availabilityValue = selectedRow.Cells["Availability"].Value;
                if (availabilityValue != DBNull.Value && availabilityValue != null)
                {
                    bool isAvailable = Convert.ToBoolean(availabilityValue);
                    cmbAvailability.SelectedItem = isAvailable ? "Available" : "Not Available";
                }
                else
                {
                    cmbAvailability.SelectedIndex = -1;
                }
            }
        }

        // Close this form and return to the dashboard
        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Unused event handlers (can be removed or kept empty if needed)
        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        // These are placeholder event handlers
        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void txtPrice_TextChanged(object sender, EventArgs e) { }

        // Only allow letters and spaces in the Item Name field
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only letters are allowed in the Item Name.");
            }
        }

        // Only allow numeric input and one decimal point in the Price field
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsControl(ch) && !char.IsDigit(ch) && ch != '.')
            {
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed in the Price.");
            }

            if (ch == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
