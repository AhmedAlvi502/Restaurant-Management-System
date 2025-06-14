using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment.System_Admin
{
    public partial class formAddUser : Form
    {
        SystemAdmin Admin = new SystemAdmin();
        string role;
        public formAddUser(string Role)
        {
            InitializeComponent();
            role = Role;
        }

  
        private void btnExitViewer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate phone number: digits only
            if (!Regex.IsMatch(txtPhone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone Number must contain only numbers.");
                return;
            }

            // Validate password: at least 8 characters, includes at least one digit
            string password = txtPassword.Text;
            if (password.Length < 8 || !Regex.IsMatch(password, @"\d"))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one digit.");
                return;
            }

            // Check password confirmation
            if (password != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Length < 8)
            {
                MessageBox.Show("Please enter a valid phone number (minimum 8 digits).");
                return;
            }

            string result = Admin.AddUser(txtUserName.Text , 
                txtEmail.Text, 
                txtPhone.Text, 
                txtPassword.Text, 
                role);

            MessageBox.Show(result);

            if (result == "User Added successfully.")
            {
                MessageBox.Show("User Added Sucessfully");
            }

            else
            {
                MessageBox.Show("Error. Could not add User.");
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        
    }
}

