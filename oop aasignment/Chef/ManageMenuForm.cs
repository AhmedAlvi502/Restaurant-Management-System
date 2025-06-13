using System;
using System.Data;
using System.Windows.Forms;

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
        }

        // Add a new menu item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string price = txtPrice.Text;
            string availability = cmbAvailability.SelectedItem?.ToString();

            string result = chef.AddMenuItem(name, chefCategory, price, availability, chefId);
            MessageBox.Show(result);

            if (result == "Item added!")
            {
                LoadMenuItems();
                ClearFields();
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

            int itemId = Convert.ToInt32(dgvMenuItems.CurrentRow.Cells["menu_id"].Value);

            // Use existing value if the field is left blank
            string name = string.IsNullOrWhiteSpace(txtName.Text)
                ? dgvMenuItems.CurrentRow.Cells["Item_Name"].Value.ToString()
                : txtName.Text;

            string price = string.IsNullOrWhiteSpace(txtPrice.Text)
                ? dgvMenuItems.CurrentRow.Cells["Price"].Value.ToString()
                : txtPrice.Text;

            string availability = cmbAvailability.SelectedItem != null
                ? cmbAvailability.SelectedItem.ToString()
                : (Convert.ToBoolean(dgvMenuItems.CurrentRow.Cells["Availability"].Value) ? "Available" : "Not Available");

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
            string result = chef.DeleteMenuItem(itemId);

            MessageBox.Show(result);
            LoadMenuItems();
            ClearFields();
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
            if (dgvMenuItems.CurrentRow != null)
            {
                txtName.Text = dgvMenuItems.CurrentRow.Cells["Item_Name"].Value.ToString();
                txtPrice.Text = dgvMenuItems.CurrentRow.Cells["Price"].Value.ToString();
                cmbCategory.SelectedItem = dgvMenuItems.CurrentRow.Cells["Category"].Value.ToString();

                object availabilityValue = dgvMenuItems.CurrentRow.Cells["Availability"].Value;
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

