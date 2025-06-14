using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace oop_aasignment
{
    public class SystemAdmin : User
    {
        private readonly string myconn = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";

        public DataTable LoadSalesView()
        {
            DataTable dt = new DataTable();
            string query = "Select * from Sales";
            using (SqlConnection dbcon = new SqlConnection(myconn))
            {
                using (SqlCommand cmd = new SqlCommand(query, dbcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }


        public DataTable GenerateSalesReport(
        ComboBox cmbCategory,
        ComboBox cmbChef,
        ComboBox cmbMonth,
        ComboBox cmbYear,
        string myconn)
        {
            DataTable dt = new DataTable();
            StringBuilder queryBuilder = new StringBuilder();

            queryBuilder.Append(@"SELECT sales_id, item_name, item_category, item_price, quantity, gross_sales, chef_name, sale_date
                              FROM Sales");

            // --- Safely retrieve selected values from ComboBoxes ---
            // For Category and Chef
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            string selectedChef = cmbChef.SelectedItem?.ToString();


            // For Month and Year (assuming they contain integer objects like 5, 2025)
            // Use null-conditional operator for SelectedItem, then cast to nullable int (int?)
            int? selectedMonth = cmbMonth.SelectedItem as int?;
            int? selectedYear = cmbYear.SelectedItem as int?;

            // --- Build the WHERE clause dynamically ---
            bool firstCondition = true; // Helper to add "AND" correctly

            Action<string> AddWhereCondition = (condition) =>
            {
                if (firstCondition)
                {
                    queryBuilder.Append(" WHERE ");
                    firstCondition = false;
                }
                else
                {
                    queryBuilder.Append(" AND ");
                }
                queryBuilder.Append(condition);
            };

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                AddWhereCondition("item_category = @Category");
            }

            if (!string.IsNullOrEmpty(selectedChef))
            {
                AddWhereCondition("chef_name = @Chef");
            }

            if (selectedMonth.HasValue) // Check if a month was selected
            {
                AddWhereCondition("MONTH(sale_date) = @Month");
            }

            if (selectedYear.HasValue) // Check if a year was selected
            {
                AddWhereCondition("YEAR(sale_date) = @Year");
            }



            string finalQuery = queryBuilder.ToString();

            // --- Execute the query with dynamic parameters ---
            using (SqlConnection dbcon = new SqlConnection(myconn))
            {
                using (SqlCommand cmd = new SqlCommand(finalQuery, dbcon))
                {
                    // Add parameters ONLY if they are part of the query
                    if (!string.IsNullOrEmpty(selectedCategory))
                    {
                        cmd.Parameters.AddWithValue("@Category", selectedCategory);
                    }

                    if (!string.IsNullOrEmpty(selectedChef))
                    {
                        cmd.Parameters.AddWithValue("@Chef", selectedChef);
                    }

                    if (selectedMonth.HasValue)
                    {
                        cmd.Parameters.Add("@Month", SqlDbType.Int).Value = selectedMonth.Value;
                    }

                    if (selectedYear.HasValue)
                    {
                        cmd.Parameters.Add("@Year", SqlDbType.Int).Value = selectedYear.Value;
                    }

                    try
                    {
                        dbcon.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Log the exception details for debugging
                        Console.WriteLine("SQL Error: " + ex.Message);
                        // Optionally, show a user-friendly error message
                        MessageBox.Show("A database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("General Error: " + ex.Message);
                        MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }

        //Form : UserProfile
        //GetUserProfile        //logic for database
        public DataTable GetAdminProfile(int userId)
        {
            using (SqlConnection myDB = new SqlConnection(myconn))
            {
                string query = "SELECT full_name, email, phone_number, password FROM users WHERE user_id = @userId";
                SqlCommand cmd = new SqlCommand(query, myDB);
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}