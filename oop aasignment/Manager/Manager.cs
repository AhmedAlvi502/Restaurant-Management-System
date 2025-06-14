using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oop_aasignment
{
    class Manager
    {

        private string connectionString = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";

        // Form : ManagerDashboard
        // GetManagerName        //logic for database
        public string GetManagerName(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT full_name FROM users WHERE user_id = @id AND user_role = 'manager'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteScalar()?.ToString() ?? "Manager";
            }
        }


        // Form : TopUp
        //TOPUP_Form LoadCustomers_TopUp,
        //logic for database 
        public void TopUp(int userId, decimal amount)
        {
            string connStr = ConfigurationManager.ConnectionStrings["SadapMakanDB"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Step 1: Get the wallet ID
                int walletId = -1;
                using (SqlCommand getWalletCmd = new SqlCommand("SELECT wallet_id FROM e_wallets WHERE user_id = @userId", conn))
                {
                    getWalletCmd.Parameters.AddWithValue("@userId", userId);
                    object result = getWalletCmd.ExecuteScalar();

                    if (result == null)
                        throw new Exception("Wallet not found.");

                    walletId = Convert.ToInt32(result);
                }

                // Step 2: Update the balance
                using (SqlCommand updateBalanceCmd = new SqlCommand("UPDATE e_wallets SET balance = balance + @amount WHERE wallet_id = @walletId", conn))
                {
                    updateBalanceCmd.Parameters.AddWithValue("@amount", amount);
                    updateBalanceCmd.Parameters.AddWithValue("@walletId", walletId);
                    updateBalanceCmd.ExecuteNonQuery();
                }

                // Step 3: Insert into transaction table
                using (SqlCommand insertTransactionCmd = new SqlCommand("INSERT INTO e_wallet_transactions (wallet_id, type, amount, timestamp) VALUES (@walletId, 'top-up', @amount, @timestamp)", conn))
                {
                    insertTransactionCmd.Parameters.AddWithValue("@walletId", walletId);
                    insertTransactionCmd.Parameters.AddWithValue("@amount", amount);
                    insertTransactionCmd.Parameters.AddWithValue("@timestamp", DateTime.Now);
                    insertTransactionCmd.ExecuteNonQuery();
                }
            }
        }

        public decimal GetCustomerBalance(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT balance FROM e_wallets WHERE user_id = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }


        public DataTable GetCustomer_TOPUP()
{
        using (SqlConnection conn = new SqlConnection(connectionString))
    {
        string query = "SELECT user_id, full_name FROM users WHERE user_role = 'customer'";
        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        return dt;
    }
}





        //Form : ViewFeedbacks
        //View Feedbacks        //logic for database
        public DataTable GetAllFeedbacks()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT feedback_id, user_id, message, submitted_at, status
            FROM Feedback
            ORDER BY submitted_at DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }



        //Form : RespondFeedbacks
        //Respond to Feedbacks        //logic for database
        public void RespondToFeedback(int feedbackId, string response, int managerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"
                UPDATE Feedback
                SET response = @response,
                    status = 'Responded',
                    manager_id = @managerId
                WHERE feedback_id = @feedbackId";

                    cmd.Parameters.AddWithValue("@response", response);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    cmd.Parameters.AddWithValue("@feedbackId", feedbackId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows == 0)
                    {
                        throw new Exception("Feedback not found or already responded.");
                    }
                }
            }
        }
        public DataTable GetNewFeedbacks()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT feedback_id, message FROM Feedback WHERE status = 'New'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        //Form : UserProfile
        //GetUserProfile        //logic for database
        public DataTable GetUserProfile(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT full_name, email, phone_number, password FROM users WHERE user_id = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        // UpdateUserProfile        //logic for database
        






        //Form : ProcessRefunds
        //Process Refund Requests        //logic for database
        public void ProcessRefund(int refundId, string status, int managerId)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(@"
            UPDATE refund_requests 
            SET status = @status, manager_id = @managerId 
            WHERE refund_id = @refundId", conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@managerId", managerId);
                    cmd.Parameters.AddWithValue("@refundId", refundId);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        throw new Exception("Refund not found or already processed.");
                    }
                }
            }
        }
        ////GetPendingRefunds        //logic for database
        public DataTable GetPendingRefunds()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                  SELECT 
                       refund_id, 
                        order_id, 
                        reason, 
                        status
                 FROM refund_requests
                 WHERE status = 'Pending'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
        
    }



}






