namespace oop_aasignment.System_Admin
{
    partial class formAddUser
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAdminProfile = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(242, 105);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(278, 167);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(202, 226);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(131, 23);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(242, 285);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(374, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(374, 227);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(374, 286);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(374, 435);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(117, 34);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add User\r\n";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(183, 341);
            this.lblConfirmPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(150, 23);
            this.lblConfirmPass.TabIndex = 15;
            this.lblConfirmPass.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(374, 342);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(239, 22);
            this.txtConfirmPass.TabIndex = 16;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.Black;
            this.btnClearFields.Location = new System.Drawing.Point(610, 435);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(144, 33);
            this.btnClearFields.TabIndex = 17;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(62, 437);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 33);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnExitViewer_Click);
            // 
            // lblAdminProfile
            // 
            this.lblAdminProfile.AutoSize = true;
            this.lblAdminProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdminProfile.Location = new System.Drawing.Point(239, 27);
            this.lblAdminProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminProfile.Name = "lblAdminProfile";
            this.lblAdminProfile.Size = new System.Drawing.Size(361, 74);
            this.lblAdminProfile.TabIndex = 19;
            this.lblAdminProfile.Text = "Type New User Credentials\r\n\r\n";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(374, 105);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(239, 22);
            this.txtUserName.TabIndex = 20;
            // 
            // formAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(828, 513);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblAdminProfile);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "formAddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblAdminProfile;
        private System.Windows.Forms.TextBox txtUserName;
    }
}