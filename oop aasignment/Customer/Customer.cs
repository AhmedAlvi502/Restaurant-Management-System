using SedapmakanCustomer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

/// <summary>
/// Manages customer profile, orders, feedback, wallet, and interactions with SQL Server.
/// Keeps business logic out of Forms.
/// </summary>
public class Customer
{   // SQL Server connection string to the database
    private readonly string connectionString = @"Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";

    // 👤 Get customer profile
    public DataTable GetProfile(int customerId) // Retrieves the customer profile by ID.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT full_name, email, phone_number, password FROM users WHERE user_id = @id AND user_role = 'customer'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", customerId);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    // ✏️ Update customer profile
    public string UpdateProfile(int userId, string name, string email, string phone, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"
                UPDATE users 
                SET full_name = @name, 
                    email = @Email, 
                    phone_number = @Phone, 
                    password = @Password
                WHERE user_id = @id", conn);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@id", userId);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0 ? "Profile updated successfully." : "Update failed.";
        }
    }
    public string UpdateSecurityInfo(int userId, string question, string answer) // Updates the customer's secret question and answer for account recovery.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"UPDATE users 
                         SET secret_question = @q, secret_answer = @a 
                         WHERE user_id = @id AND user_role = 'customer'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@q", question);
            cmd.Parameters.AddWithValue("@a", answer);
            cmd.Parameters.AddWithValue("@id", userId);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0 ? "Security info updated." : "Failed to update security info.";
        }
    }


    // 🛒 Place order
    public string PlaceOrder(int userId, List<CartItem> cart)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction txn = conn.BeginTransaction();

            try
            {
                // 1. Insert into Orders with correct column name: total_amount
                string insertOrder = "INSERT INTO Orders (user_id, total_amount, status, order_time) OUTPUT INSERTED.order_id VALUES (@userId, @total, 'In progress', GETDATE())";



                SqlCommand cmdOrder = new SqlCommand(insertOrder, conn, txn);
                cmdOrder.Parameters.AddWithValue("@userId", userId);
                cmdOrder.Parameters.AddWithValue("@total", cart.Sum(x => x.Price));
                int orderId = (int)cmdOrder.ExecuteScalar();

                // 2. Insert each item into order_items
                foreach (CartItem item in cart)
                {
                    string insertItem = @"
                    INSERT INTO order_items (order_id, menu_id, quantity)
                    VALUES (@orderId, @menuId, @qty)";

                    SqlCommand cmdItem = new SqlCommand(insertItem, conn, txn);
                    cmdItem.Parameters.AddWithValue("@orderId", orderId);
                    cmdItem.Parameters.AddWithValue("@menuId", item.MenuId);
                    cmdItem.Parameters.AddWithValue("@qty", 1); // Adjust as needed
                    cmdItem.ExecuteNonQuery();
                }

                txn.Commit();
                return "Order placed!";
            }
            catch (Exception ex)
            {
                txn.Rollback();
                return "Failed to place order: " + ex.Message;
            }
        }
    }




    // 📋 Load orders
    public DataTable GetOrders(int userId) // Retrieves all orders placed by a specific customer.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
            SELECT 
                o.order_id, 
                mi.Item_Name, 
                mi.price, 
                o.status, 
                ISNULL(r.status, 'N/A') AS refund_status
            FROM orders o
            JOIN order_items oi ON o.order_id = oi.order_id
            JOIN menu_items mi ON oi.menu_id = mi.menu_id
            LEFT JOIN refund_requests r ON o.order_id = r.order_id
            WHERE o.user_id = @userId
            ORDER BY o.order_time DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }




    // 🍽️ Load menu
    public DataTable GetAllMenuItems() // Retrieves all available menu items.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT menu_id, Item_Name, category, price, availability FROM menu_items";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    // 📁 Get unique menu categories from database
    public List<string> GetDistinctCategories()
    {
        List<string> categories = new List<string>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT DISTINCT category FROM menu_items WHERE category IS NOT NULL";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categories.Add(reader.GetString(0));
            }
        }

        return categories;
    }


    // ❌ Cancel order
    public string CancelOrder(int orderId)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE orders SET status = 'Cancelled' WHERE order_id = @id AND status = 'Pending'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0 ? "Order cancelled." : "Only pending orders can be cancelled.";
        }
    }

    // 🔁 Request refund
    public string RequestRefund(int orderId, string reason)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
            INSERT INTO refund_requests (order_id, customer_id, reason, status, requested_at)
            VALUES (@orderId, @custId, @reason, 'Pending', GETDATE())";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            cmd.Parameters.AddWithValue("@custId", Session.UserId);  // Assuming you're using Session.UserId
            cmd.Parameters.AddWithValue("@reason", reason);

            conn.Open();
            cmd.ExecuteNonQuery();
            return "Refund requested.";
        }
    }




    // 💬 Submit feedback
    public string SubmitFeedback(int userId, string message)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO feedback (user_id, message, submitted_at, status) 
                         VALUES (@id, @message, GETDATE(), 'New')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.Parameters.AddWithValue("@message", message);

            conn.Open();
            cmd.ExecuteNonQuery();
            return "Feedback submitted!";
        }
    }


    public DataTable GetPreviousFeedbacks(int userId) // Gets all feedback previously submitted by the customer.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"SELECT message AS Feedback, submitted_at AS Date 
                         FROM feedback WHERE user_id = @id ORDER BY submitted_at DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }


    // 💰 Top up e-wallet
    public string TopUpEWallet(int userId, decimal amount, string method)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlTransaction txn = conn.BeginTransaction();

            try
            {
                // ✅ Get wallet_id for user
                string getWalletIdQuery = "SELECT wallet_id FROM e_wallets WHERE user_id = @id";
                SqlCommand getWalletCmd = new SqlCommand(getWalletIdQuery, conn, txn);
                getWalletCmd.Parameters.AddWithValue("@id", userId);
                object result = getWalletCmd.ExecuteScalar();

                if (result == null)
                {
                    txn.Rollback();
                    return "Wallet not found.";
                }

                int walletId = Convert.ToInt32(result);

                // ✅ Update balance
                string updateBalance = "UPDATE e_wallets SET balance = balance + @amount WHERE user_id = @id";
                SqlCommand cmd1 = new SqlCommand(updateBalance, conn, txn);
                cmd1.Parameters.AddWithValue("@amount", amount);
                cmd1.Parameters.AddWithValue("@id", userId);
                cmd1.ExecuteNonQuery();

                // ✅ Insert transaction with correct columns
                string insertTxn = @"
                INSERT INTO e_wallet_transactions (wallet_id, amount, type, timestamp)
                VALUES (@walletId, @amount, @type, GETDATE())";
                SqlCommand cmd2 = new SqlCommand(insertTxn, conn, txn);
                cmd2.Parameters.AddWithValue("@walletId", walletId);
                cmd2.Parameters.AddWithValue("@amount", amount);
                cmd2.Parameters.AddWithValue("@type", method);  // "type" matches your DB column

                cmd2.ExecuteNonQuery();

                txn.Commit();
                return "Top-up successful!";
            }
            catch (Exception ex)
            {
                txn.Rollback();
                return "Top-up failed: " + ex.Message;
            }
        }
    }


    public decimal GetWalletBalance(int userId) // Retrieves the wallet balance for a customer.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT balance FROM e_wallets WHERE user_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", userId);
            conn.Open();
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDecimal(result) : 0m;
        }
    }

    public DataTable GetTransactionHistory(int userId) // Gets the customer's wallet transaction history.
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"
        SELECT 
            t.timestamp AS Date,
            t.amount AS Amount,
            t.type AS Method,
            'Success' AS Status
        FROM e_wallet_transactions t
        JOIN e_wallets w ON t.wallet_id = w.wallet_id
        WHERE w.user_id = @id
        ORDER BY t.timestamp DESC";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", userId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    // Deducts funds from the customer's wallet if sufficient balance is available.
    public string DeductWalletBalance(int userId, decimal amount)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE e_wallets SET balance = balance - @amount WHERE user_id = @id AND balance >= @amount";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@id", userId);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            return rows > 0 ? "Wallet deducted." : "Failed to deduct wallet balance.";
        }
    }



    // 🔒 Get customer ID for login
    public int GetCustomerId(string email, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT user_id FROM users WHERE email = @mail AND password = @pass AND user_role = 'customer'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@mail", email);
            cmd.Parameters.AddWithValue("@pass", password);
            conn.Open();
            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : -1;
        }
    }
}
