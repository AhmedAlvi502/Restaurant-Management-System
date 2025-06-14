using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    public partial class formSalesView : Form
    {
        private readonly string myconn = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";
        private SystemAdmin Admin = new SystemAdmin();
        public formSalesView()
        {
            InitializeComponent();
            
            
        }
          
        private void GetSalesData()
        {
            DataTable Dt = Admin.LoadSalesView();
            salesDataGridView.DataSource = Dt;
        }
        private void ClearFields()
        {
            // Clear text and reset background for Month ComboBox
            cmbMonth.Text = string.Empty;
            cmbMonth.BackColor = SystemColors.Window;
            cmbMonth.SelectedIndex = -1;

            // Clear text and reset background for Year ComboBox
            cmbYear.Text = string.Empty;
            cmbYear.BackColor = SystemColors.Window;
            cmbYear.SelectedIndex = -1; 

            // Clear text and reset background for Category ComboBox
            cmbCategory.Text = string.Empty;
            cmbCategory.BackColor = SystemColors.Window;
            cmbCategory.SelectedIndex = -1; 

            // Clear text and reset background for Chef ComboBox
            cmbChef.Text = string.Empty;
            cmbChef.BackColor = SystemColors.Window;
            cmbChef.SelectedIndex = -1;
        }

        private void formSalesView_Load(object sender, EventArgs e)
        {
            GetSalesData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();

        }


        private void btnGenReport_Click(object sender, EventArgs e)
        {

            string connectionString = myconn;

            DataTable reportData = Admin.GenerateSalesReport(
                cmbCategory,
                cmbChef,
                cmbMonth,
                cmbYear,
                connectionString
            );

            salesDataGridView.DataSource = reportData;
        }
        
    }
}
