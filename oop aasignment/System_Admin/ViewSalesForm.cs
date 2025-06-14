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
            GetSalesData();
            
        }
          
        private void GetSalesData()
        {
            DataTable Dt = Admin.LoadSalesView();
            salesDataGridView.DataSource = Dt;
        }
        private void ClearFields()
        {
            cmbMonth.Text = string.Empty;
            cmbMonth.BackColor = SystemColors.Window;

            cmbYear.Text = string.Empty;
            cmbYear.BackColor = SystemColors.Window;

            cmbCategory.Text = string.Empty;
            cmbCategory.BackColor = SystemColors.Window;

            cmbChef.Text = string.Empty;
            cmbChef.BackColor = SystemColors.Window;
        }

        private void formSalesView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sedapMakanSales.Sales' table. You can move, or remove it, as needed.
            //this.salesTableAdapter.Fill(this.sedapMakanSales.Sales);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            //this.salesTableAdapter.OrderByChef(this.sedapMakanSales.Sales);
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            //String itemCategory = cmbCategory.SelectedItem.ToString();
            //String chef = cmbChef.SelectedItem.ToString();
            //int month = (int)cmbMonth.SelectedItem;
            //int year = (int)cmbYear.SelectedItem;

            //DataTable dt = Admin.SortSalesView(itemCategory, chef, month, year);
            //salesDataGridView.DataSource = dt;

            string connectionString = myconn; // Replace with your actual connection string

            DataTable reportData = Admin.GenerateSalesReport(
                cmbCategory,
                cmbChef,
                cmbMonth,
                cmbYear,
                connectionString
            );

            // Assuming you have a DataGridView named salesDataGridView
            salesDataGridView.DataSource = reportData;
        }
        
    }
}
