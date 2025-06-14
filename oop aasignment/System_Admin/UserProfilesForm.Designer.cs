namespace oop_aasignment
{
    partial class UserProfilesForm
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
            this.lblProfileUpdate = new System.Windows.Forms.Label();
            this.btnSystemAdmin = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnChef = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfileUpdate
            // 
            this.lblProfileUpdate.AutoSize = true;
            this.lblProfileUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileUpdate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblProfileUpdate.Location = new System.Drawing.Point(264, 55);
            this.lblProfileUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileUpdate.Name = "lblProfileUpdate";
            this.lblProfileUpdate.Size = new System.Drawing.Size(428, 37);
            this.lblProfileUpdate.TabIndex = 4;
            this.lblProfileUpdate.Text = "Choose a User Profile to Update\r\n";
            this.lblProfileUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSystemAdmin
            // 
            this.btnSystemAdmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSystemAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnSystemAdmin.Location = new System.Drawing.Point(327, 145);
            this.btnSystemAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSystemAdmin.Name = "btnSystemAdmin";
            this.btnSystemAdmin.Size = new System.Drawing.Size(267, 62);
            this.btnSystemAdmin.TabIndex = 5;
            this.btnSystemAdmin.Text = "System Admin Profile";
            this.btnSystemAdmin.UseVisualStyleBackColor = false;
            this.btnSystemAdmin.Click += new System.EventHandler(this.btnSystemAdmin_Click);
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.Location = new System.Drawing.Point(327, 225);
            this.btnManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(267, 62);
            this.btnManager.TabIndex = 6;
            this.btnManager.Text = "Manager Profile";
            this.btnManager.UseVisualStyleBackColor = false;
            // 
            // btnChef
            // 
            this.btnChef.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChef.ForeColor = System.Drawing.Color.Black;
            this.btnChef.Location = new System.Drawing.Point(327, 314);
            this.btnChef.Margin = new System.Windows.Forms.Padding(4);
            this.btnChef.Name = "btnChef";
            this.btnChef.Size = new System.Drawing.Size(267, 62);
            this.btnChef.TabIndex = 7;
            this.btnChef.Text = "Chef Profile";
            this.btnChef.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(327, 403);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(267, 62);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Customer Profiles";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(735, 422);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(133, 43);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // formUserProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(920, 514);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnChef);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnSystemAdmin);
            this.Controls.Add(this.lblProfileUpdate);
            this.Name = "formUserProfiles";
            this.Text = "User Profiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileUpdate;
        private System.Windows.Forms.Button btnSystemAdmin;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnChef;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnGoBack;
    }
}