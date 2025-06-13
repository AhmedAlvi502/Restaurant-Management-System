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
    public partial class TopUp : Form
    {
        private int userId;
        private Manager manager = new Manager();

        public TopUp(int id)
        {
            InitializeComponent();
            LoadCustomers_TopUp();
            userId = id;
            
            
            

        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Please enter a valid top-up amount.");
                return;
            }

            try
            {
                int selectedUserId = Convert.ToInt32(cbCustomer.SelectedValue);
                decimal amount = numAmount.Value;

                manager.TopUp(selectedUserId, amount);

                MessageBox.Show("Top-up successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during top-up: " + ex.Message);
            }

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
        private void LoadCustomers_TopUp()
        {

            cbCustomer.DataSource = manager.GetCustomer_TOPUP();
            cbCustomer.DisplayMember = "full_name";
            cbCustomer.ValueMember = "user_id";

        }

        private void cbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCustomer.SelectedValue != null && int.TryParse(cbCustomer.SelectedValue.ToString(), out int selectedId))
            {
                try
                {
                    decimal balance = manager.GetCustomerBalance(selectedId);
                    lblBalance.Text = $"Current Balance: RM{balance:F2}";

                    if (balance < 10)
                    {
                        lblBalance.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblBalance.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    lblBalance.Text = "Balance: Error";
                    lblBalance.ForeColor = Color.Red;
                    MessageBox.Show("Failed to load balance: " + ex.Message);
                }
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            
            ManagerDashboard dashboard = new ManagerDashboard(userId);  
            dashboard.Show();
            this.Close();
        }
    }
}
