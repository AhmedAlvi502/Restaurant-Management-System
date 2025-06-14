namespace oop_aasignment
{
    partial class formAdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminProfile));
            this.lblAdminProfile = new System.Windows.Forms.Label();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.btnAdminClear = new System.Windows.Forms.Button();
            this.btnAdminUpdate = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblAdminConfirmPass = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminPhone = new System.Windows.Forms.Label();
            this.txtAdminPhone = new System.Windows.Forms.TextBox();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnShowConPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdminProfile
            // 
            this.lblAdminProfile.AutoSize = true;
            this.lblAdminProfile.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminProfile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdminProfile.Location = new System.Drawing.Point(239, 35);
            this.lblAdminProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminProfile.Name = "lblAdminProfile";
            this.lblAdminProfile.Size = new System.Drawing.Size(297, 37);
            this.lblAdminProfile.TabIndex = 1;
            this.lblAdminProfile.Text = "Update Admin Profile";
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdminBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdminBack.Location = new System.Drawing.Point(122, 470);
            this.btnAdminBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(129, 39);
            this.btnAdminBack.TabIndex = 41;
            this.btnAdminBack.Text = "Back ";
            this.btnAdminBack.UseVisualStyleBackColor = false;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBackToDashBoard_Click);
            // 
            // btnAdminClear
            // 
            this.btnAdminClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdminClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminClear.ForeColor = System.Drawing.Color.Black;
            this.btnAdminClear.Location = new System.Drawing.Point(486, 434);
            this.btnAdminClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminClear.Name = "btnAdminClear";
            this.btnAdminClear.Size = new System.Drawing.Size(100, 34);
            this.btnAdminClear.TabIndex = 40;
            this.btnAdminClear.Text = "Clear";
            this.btnAdminClear.UseVisualStyleBackColor = false;
            this.btnAdminClear.Click += new System.EventHandler(this.btnAdminClear_Click);
            // 
            // btnAdminUpdate
            // 
            this.btnAdminUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdminUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUpdate.Location = new System.Drawing.Point(346, 434);
            this.btnAdminUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminUpdate.Name = "btnAdminUpdate";
            this.btnAdminUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnAdminUpdate.TabIndex = 39;
            this.btnAdminUpdate.Text = "Update Profile";
            this.btnAdminUpdate.UseVisualStyleBackColor = false;
            this.btnAdminUpdate.Click += new System.EventHandler(this.btnAdminUpdate_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(346, 375);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(239, 22);
            this.txtConfirmPass.TabIndex = 38;
            // 
            // lblAdminConfirmPass
            // 
            this.lblAdminConfirmPass.AutoSize = true;
            this.lblAdminConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminConfirmPass.Location = new System.Drawing.Point(175, 375);
            this.lblAdminConfirmPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminConfirmPass.Name = "lblAdminConfirmPass";
            this.lblAdminConfirmPass.Size = new System.Drawing.Size(150, 23);
            this.lblAdminConfirmPass.TabIndex = 37;
            this.lblAdminConfirmPass.Text = "Confirm Password:";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(346, 316);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(239, 22);
            this.txtAdminPassword.TabIndex = 36;
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(173, 316);
            this.lblAdminPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(84, 23);
            this.lblAdminPassword.TabIndex = 35;
            this.lblAdminPassword.Text = "Password:";
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Location = new System.Drawing.Point(346, 179);
            this.txtAdminEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(239, 22);
            this.txtAdminEmail.TabIndex = 34;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.Location = new System.Drawing.Point(173, 183);
            this.lblAdminEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(55, 23);
            this.lblAdminEmail.TabIndex = 33;
            this.lblAdminEmail.Text = "Email:";
            // 
            // lblAdminPhone
            // 
            this.lblAdminPhone.AutoSize = true;
            this.lblAdminPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPhone.Location = new System.Drawing.Point(173, 253);
            this.lblAdminPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminPhone.Name = "lblAdminPhone";
            this.lblAdminPhone.Size = new System.Drawing.Size(131, 23);
            this.lblAdminPhone.TabIndex = 32;
            this.lblAdminPhone.Text = "Phone Number:";
            // 
            // txtAdminPhone
            // 
            this.txtAdminPhone.Location = new System.Drawing.Point(346, 249);
            this.txtAdminPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPhone.Name = "txtAdminPhone";
            this.txtAdminPhone.Size = new System.Drawing.Size(239, 22);
            this.txtAdminPhone.TabIndex = 31;
            this.txtAdminPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(346, 116);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(239, 22);
            this.txtAdminName.TabIndex = 30;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.Location = new System.Drawing.Point(173, 116);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(91, 23);
            this.lblAdminName.TabIndex = 29;
            this.lblAdminName.Text = "Full Name:";
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.Color.White;
            this.btnShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPass.Image")));
            this.btnShowPass.Location = new System.Drawing.Point(593, 313);
            this.btnShowPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(36, 25);
            this.btnShowPass.TabIndex = 42;
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPas_Click);
            // 
            // btnShowConPass
            // 
            this.btnShowConPass.BackColor = System.Drawing.Color.White;
            this.btnShowConPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowConPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowConPass.Image = ((System.Drawing.Image)(resources.GetObject("btnShowConPass.Image")));
            this.btnShowConPass.Location = new System.Drawing.Point(593, 374);
            this.btnShowConPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowConPass.Name = "btnShowConPass";
            this.btnShowConPass.Size = new System.Drawing.Size(36, 25);
            this.btnShowConPass.TabIndex = 43;
            this.btnShowConPass.UseVisualStyleBackColor = false;
            this.btnShowConPass.Click += new System.EventHandler(this.btnShoConPas_Click);
            // 
            // formAdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(804, 543);
            this.Controls.Add(this.btnShowConPass);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnAdminBack);
            this.Controls.Add(this.btnAdminClear);
            this.Controls.Add(this.btnAdminUpdate);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblAdminConfirmPass);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.txtAdminEmail);
            this.Controls.Add(this.lblAdminEmail);
            this.Controls.Add(this.lblAdminPhone);
            this.Controls.Add(this.txtAdminPhone);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.lblAdminProfile);
            this.Name = "formAdminProfile";
            this.Text = "Admin Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminProfile;
        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.Button btnAdminClear;
        private System.Windows.Forms.Button btnAdminUpdate;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblAdminConfirmPass;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.Label lblAdminPhone;
        private System.Windows.Forms.TextBox txtAdminPhone;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnShowConPass;
    }
}