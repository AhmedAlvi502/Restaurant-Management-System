using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

/// <summary>
/// The Chef class handles all database operations for chefs,
/// including managing menu items, orders, and chef profiles.
/// </summary>
public class Chef : User
{
    // Database connection string
    private readonly string connectionString = @"Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";

    // ============================
    // MENU ITEM METHODS
    // ============================

    /// <summary>
    /// Returns all menu items that belong to the given chef and category.
    /// </summary>
    public DataTable GetMenuItems(int chefId, string chefCategory)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM menu_items WHERE user_id = @userId AND category = @category";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@userId", chefId);
            da.SelectCommand.Parameters.AddWithValue("@category", chefCategory);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    /// <summary>
    /// Adds a new menu item after validating the input.
    /// </summary>
    public string AddMenuItem(string itemName, string category, string priceText, string availability, int chefId)
    {
        if (string.IsNullOrWhiteSpace(itemName) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(availability))
            return "Please fill all fields.";

        if (!decimal.TryParse(priceText, out decimal price))
            return "Invalid price format.";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO menu_items (Item_Name, category, price, availability, user_id) VALUES (@name, @category, @price, @availability, @user_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", itemName);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@availability", availability == "Available");
            cmd.Parameters.AddWithValue("@user_id", chefId);

            conn.Open();
            cmd.ExecuteNonQuery();
            return "Item added!";
        }
    }

    /// <summary>
    /// Updates an existing menu item by its ID.
    /// </summary>
    public string UpdateMenuItem(int itemId, string itemName, string category, string priceText, string availability)
    {
        if (string.IsNullOrWhiteSpace(itemName) || string.IsNullOrWhiteSpace(priceText))
            return "Please provide name and price.";

        if (!decimal.TryParse(priceText, out decimal price))
            return "Invalid price format.";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE menu_items SET Item_Name=@name, category=@category, price=@price, availability=@availability WHERE menu_id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", itemName);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@availability", availability == "Available");
            cmd.Parameters.AddWithValue("@id", itemId);

            conn.Open();
            cmd.ExecuteNonQuery();
            return "Item updated successfully.";
        }
    }

    /// <summary>
    /// Deletes a menu item based on its ID.
    /// </summary>
    public string DeleteMenuItem(int itemId)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First delete from order_items
                string deleteOrderItems = "DELETE FROM order_items WHERE menu_id = @itemId";
                using (SqlCommand cmd1 = new SqlCommand(deleteOrderItems, conn))
                {
                    cmd1.Parameters.AddWithValue("@itemId", itemId);
                    cmd1.ExecuteNonQuery();
                }

                // Then delete from menu_items
                string deleteMenuItem = "DELETE FROM menu_items WHERE menu_id = @itemId";
                using (SqlCommand cmd2 = new SqlCommand(deleteMenuItem, conn))
                {
                    cmd2.Parameters.AddWithValue("@itemId", itemId);
                    int rows = cmd2.ExecuteNonQuery();
                    return rows > 0 ? "Item is deleted!" : "Item not found.";
                }
            }
        }
        catch (Exception ex)
        {
            return "Error: " + ex.Message;
        }
    }

    // ============================
    // ORDER METHODS
    // ============================    

   
    /// <summary>
    /// Gets orders filtered by a specific category for the chef.
    /// Only shows items from that category.
    /// </summary>
    public DataTable GetOrdersByCategory(string category)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT 
                    o.order_id, 
                    o.order_time AS order_date, 
                    o.status, 
                    u.full_name AS CustomerName, 
                    mi.Item_Name
                FROM orders o
                JOIN order_items oi ON o.order_id = oi.order_id
                JOIN menu_items mi ON oi.menu_id = mi.menu_id
                JOIN users u ON o.user_id = u.user_id
                WHERE mi.category = @category
                ORDER BY o.order_time DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@category", category);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    /// <summary>
    /// Updates the status of an order.
    /// </summary>
    public string UpdateOrderStatus(int orderId, string newStatus)
    {
        if (string.IsNullOrEmpty(newStatus))
            return "Please select a status.";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "UPDATE orders SET status = @status WHERE order_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", newStatus);
            cmd.Parameters.AddWithValue("@id", orderId);
            con.Open();
            cmd.ExecuteNonQuery();
            return "Order status updated.";
        }
    }

    // ============================
    // CHEF PROFILE METHODS
    // ============================

    /// <summary>
    /// Gets the category for a chef based on their ID.
    /// </summary>
    public string GetCategoryByChefId(int id)
    {
        switch (id)
        {
            case 3: return "Italian";
            case 4: return "Mexican";
            case 5: return "Drinks";
            case 6: return "Local Malaysian";
            default: return "";
        }
    }
    

    /// <summary>
    /// Retrieves the chef's profile data for editing.
    /// </summary>
    public DataTable GetChefProfile(int chefId)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT full_name AS Name, email AS Email, phone_number AS Phone, password AS Password FROM users WHERE user_id = @id AND user_role = 'chef'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@id", chefId);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
