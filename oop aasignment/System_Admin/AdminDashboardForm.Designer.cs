namespace oop_aasignment
{
    partial class formAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnViewEWallet = new System.Windows.Forms.Button();
            this.lblAdminWelcome = new System.Windows.Forms.Label();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Black;
            this.btnManageUsers.Location = new System.Drawing.Point(253, 128);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(267, 62);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.Black;
            this.btnSalesReport.Location = new System.Drawing.Point(253, 217);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(267, 62);
            this.btnSalesReport.TabIndex = 2;
            this.btnSalesReport.Text = "View Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = false;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserProfile.ForeColor = System.Drawing.Color.Black;
            this.btnUserProfile.Location = new System.Drawing.Point(253, 389);
            this.btnUserProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(267, 62);
            this.btnUserProfile.TabIndex = 2;
            this.btnUserProfile.Text = "Update Any User Profile\r\n";
            this.btnUserProfile.UseVisualStyleBackColor = false;
            this.btnUserProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // btnViewEWallet
            // 
            this.btnViewEWallet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewEWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEWallet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEWallet.ForeColor = System.Drawing.Color.Black;
            this.btnViewEWallet.Location = new System.Drawing.Point(253, 303);
            this.btnViewEWallet.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewEWallet.Name = "btnViewEWallet";
            this.btnViewEWallet.Size = new System.Drawing.Size(267, 62);
            this.btnViewEWallet.TabIndex = 2;
            this.btnViewEWallet.Text = "View E-Wallet Top Up";
            this.btnViewEWallet.UseVisualStyleBackColor = false;
            // 
            // lblAdminWelcome
            // 
            this.lblAdminWelcome.AutoSize = true;
            this.lblAdminWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminWelcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdminWelcome.Location = new System.Drawing.Point(213, 50);
            this.lblAdminWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminWelcome.Name = "lblAdminWelcome";
            this.lblAdminWelcome.Size = new System.Drawing.Size(341, 37);
            this.lblAdminWelcome.TabIndex = 3;
            this.lblAdminWelcome.Text = " Welcome, System Admin";
            this.lblAdminWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdminLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogout.Location = new System.Drawing.Point(334, 475);
            this.btnAdminLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(133, 43);
            this.btnAdminLogout.TabIndex = 6;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // formAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(793, 555);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.lblAdminWelcome);
            this.Controls.Add(this.btnViewEWallet);
            this.Controls.Add(this.btnUserProfile);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnManageUsers);
            this.Name = "formAdminDashboard";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.formAdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnViewEWallet;
        private System.Windows.Forms.Label lblAdminWelcome;
        private System.Windows.Forms.Button btnAdminLogout;
    }
}