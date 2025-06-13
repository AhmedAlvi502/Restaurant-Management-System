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
    public partial class ViewFeedBack: Form
    {
        private int userId;
        Manager manager = new Manager();
        public ViewFeedBack(int id)
        {
            InitializeComponent();
            userId = id;
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LoadFeedbacks();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFeedbacks();
        }
        private void LoadFeedbacks()
        {
            dgvviewFB.DataSource = manager.GetAllFeedbacks();

            dgvviewFB.Columns["message"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvviewFB.Columns["submitted_at"].DefaultCellStyle.Format = "g";
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagerDashboard(userId).Show();
        }
    }
}
