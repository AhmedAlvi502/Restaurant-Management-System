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
    public partial class RespondToFeedback: Form

    {
        private int userId;
        private Manager manager = new Manager();

        
        public RespondToFeedback(int id)
        {
            InitializeComponent();
            userId = id;
            LoadFeedbacks();
        }

         
        private void btnSubmitResponse_Click(object sender, EventArgs e)
        {


            if (cbFeedback.SelectedValue == null || string.IsNullOrWhiteSpace(txtResponse.Text))
            {
                MessageBox.Show("Please select a feedback and enter a response.");
                return;
            }

            string response = txtResponse.Text.Trim();
            int wordCount = response.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            if (wordCount > 500)
            {
                MessageBox.Show("Response must be 500 words or fewer.");
                return;
            }

            try
            {
                int feedbackId = Convert.ToInt32(cbFeedback.SelectedValue);
                int managerId = userId;

                manager.RespondToFeedback(feedbackId, response, managerId);
                MessageBox.Show("Response submitted successfully!");

                txtResponse.Clear();
                LoadFeedbacks(); // Reload the list to remove the responded one
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();
            cbFeedback.SelectedIndex = -1; // Clear the selected feedback

        }

        private void LoadFeedbacks()
        {
            try
            {


                DataTable dt = manager.GetNewFeedbacks();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No pending feedback available.");
                    cbFeedback.DataSource = null;

                    return;
                }

                
                cbFeedback.DataSource = dt;
                cbFeedback.DisplayMember = "message";
                cbFeedback.ValueMember = "feedback_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedbacks: " + ex.Message);
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
