using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_aasignment
{
    
    public partial class ManagerDashboard: Form
    {
        private Manager manager = new Manager();
        private int userId = 2;
        public ManagerDashboard(int id)
        {
            InitializeComponent();
            userId = id;
            lblManagerName.Text = $"Welcome, {manager.GetManagerName(userId)}";

        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {

            RespondToFeedback form = new RespondToFeedback(userId);
            form.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
            LoginForm login = new LoginForm();
            login.Show();
            

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            TopUp topUpForm = new TopUp(userId);
            topUpForm.Show();
            this.Close();
        }

        private void btnRefunds_Click(object sender, EventArgs e)
        {
            RefundHandler refundForm = new RefundHandler(userId);
            refundForm.Show();
            this.Close();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            UpdateProfile updateForm = new UpdateProfile(userId);
            updateForm.Show();
            this.Close();


        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ViewFeedBack viewForm = new ViewFeedBack(userId);
            viewForm.Show();
            this.Close();
        }
    }
}
