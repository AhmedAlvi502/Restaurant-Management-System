namespace oop_aasignment.System_Admin
{
    partial class formManageUsers
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
            this.btnUserTable = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnAddManager = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddChef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserTable
            // 
            this.btnUserTable.BackColor = System.Drawing.Color.LightGreen;
            this.btnUserTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserTable.Location = new System.Drawing.Point(739, 479);
            this.btnUserTable.Name = "btnUserTable";
            this.btnUserTable.Size = new System.Drawing.Size(159, 33);
            this.btnUserTable.TabIndex = 18;
            this.btnUserTable.Text = "Show Existing Users";
            this.btnUserTable.UseVisualStyleBackColor = false;
            this.btnUserTable.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(23, 479);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(159, 33);
            this.btnGoBack.TabIndex = 19;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAddAdmin.Location = new System.Drawing.Point(315, 118);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(267, 62);
            this.btnAddAdmin.TabIndex = 20;
            this.btnAddAdmin.Text = "Add System Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnAddManager
            // 
            this.btnAddManager.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddManager.ForeColor = System.Drawing.Color.Black;
            this.btnAddManager.Location = new System.Drawing.Point(315, 217);
            this.btnAddManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddManager.Name = "btnAddManager";
            this.btnAddManager.Size = new System.Drawing.Size(267, 62);
            this.btnAddManager.TabIndex = 21;
            this.btnAddManager.Text = "Add Manager\r\n";
            this.btnAddManager.UseVisualStyleBackColor = false;
            this.btnAddManager.Click += new System.EventHandler(this.btnAddManager_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsers.Location = new System.Drawing.Point(273, 54);
            this.lblUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(371, 37);
            this.lblUsers.TabIndex = 22;
            this.lblUsers.Text = "Manage SedapMakan Users\r\n";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnAddCustomer.Location = new System.Drawing.Point(315, 392);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(267, 62);
            this.btnAddCustomer.TabIndex = 23;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddChef
            // 
            this.btnAddChef.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChef.ForeColor = System.Drawing.Color.Black;
            this.btnAddChef.Location = new System.Drawing.Point(315, 300);
            this.btnAddChef.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddChef.Name = "btnAddChef";
            this.btnAddChef.Size = new System.Drawing.Size(267, 62);
            this.btnAddChef.TabIndex = 24;
            this.btnAddChef.Text = "Add Chef\r\n";
            this.btnAddChef.UseVisualStyleBackColor = false;
            this.btnAddChef.Click += new System.EventHandler(this.button1_Click);
            // 
            // formManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(949, 557);
            this.Controls.Add(this.btnAddChef);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.btnAddManager);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnUserTable);
            this.Name = "formManageUsers";
            this.Text = "Manage Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserTable;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnAddManager;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddChef;
    }
}