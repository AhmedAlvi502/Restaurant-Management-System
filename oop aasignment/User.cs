using oop_aasignment;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public class User
{
    // Get the connection string from App.config (SadapMakanDB connection)
    private string connectionString = "Data Source=localhost;Initial Catalog=SadapMakanDB;Integrated Security=True;";

        //ConfigurationManager.ConnectionStrings["SadapMakanDB"].ConnectionString;

    // User's full name (e.g., John Doe)
    public string FullName { get; set; }

    // User's email address (used for login)
    public string Email { get; set; }

    // User's contact number
    public string PhoneNumber { get; set; }

    // User's password
    public string Password { get; set; }

    // Security question (for password recovery)
    public string SecretQuestion { get; set; }

    // Answer to the security question
    public string SecretAnswer { get; set; }

    // User role (e.g., "chef", "customer", etc.)
    public string UserRole { get; set; }
    /// <summary>
    /// Logs a user in by checking their email and password in the database.
    /// Returns the user's ID and role if found; otherwise, returns -1 and null.
    /// </summary>
    public (int userId, string role) Login(string email, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT user_id, user_role FROM users WHERE email = @Email AND password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // If the user exists, return their ID and role
            if (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string role = reader.GetString(1);
                return (userId, role);
            }

            // User not found
            return (-1, null);
        }
    }

    /// <summary>
    /// Registers a new user by inserting their data into the database.
    /// Returns true if the registration was successful.
    /// </summary>
    public bool Register(User user)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO users (full_name, email, password, phone_number, secret_question, secret_answer, user_role)
                             VALUES (@FullName, @Email, @Password, @PhoneNumber, @SecretQuestion, @SecretAnswer, @UserRole)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FullName", user.FullName);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@SecretQuestion", user.SecretQuestion);
            cmd.Parameters.AddWithValue("@SecretAnswer", user.SecretAnswer);
            cmd.Parameters.AddWithValue("@UserRole", user.UserRole);

            conn.Open();

            // If one or more rows are inserted, return true
            return cmd.ExecuteNonQuery() > 0;
        }
    }
    /// <summary>
    /// Updates the user's profile information.
    /// Allows partial updates (only fields that are filled will be updated).
    /// </summary>
    
    public string UpdateProfile(int userId, string name, string email, string phone, string password)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"
            UPDATE users 
            SET full_name = @name, 
                email = @Email, 
                phone_number = @Phone, 
                password = @Password
            WHERE user_id = @id";

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@id", userId);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0 ? "Profile updated successfully." : "Update failed.";
        }
    }
}
