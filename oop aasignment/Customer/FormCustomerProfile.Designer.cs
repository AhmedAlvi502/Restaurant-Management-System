namespace oop_aasignment
{
    partial class FormCustomerProfile
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
            this.goback1 = new System.Windows.Forms.Panel();
            this.picgoback1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.pnlSecurity = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelSecurity = new System.Windows.Forms.Button();
            this.btnSaveSecurity = new System.Windows.Forms.Button();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.txtSecretQuestion = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblSecHeading = new System.Windows.Forms.Label();
            this.btnEditSecurity = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.goback1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgoback1)).BeginInit();
            this.pnlSecurity.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // goback1
            // 
            this.goback1.BackColor = System.Drawing.SystemColors.Control;
            this.goback1.Controls.Add(this.picgoback1);
            this.goback1.Location = new System.Drawing.Point(31, 438);
            this.goback1.Name = "goback1";
            this.goback1.Size = new System.Drawing.Size(54, 45);
            this.goback1.TabIndex = 0;
            // 
            // picgoback1
            // 
            this.picgoback1.BackColor = System.Drawing.Color.DarkOrange;
            this.picgoback1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgoback1.Image = global::oop_aasignment.Properties.Resources.back;
            this.picgoback1.Location = new System.Drawing.Point(0, 0);
            this.picgoback1.Name = "picgoback1";
            this.picgoback1.Size = new System.Drawing.Size(54, 45);
            this.picgoback1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picgoback1.TabIndex = 0;
            this.picgoback1.TabStop = false;
            this.picgoback1.Click += new System.EventHandler(this.picgoback1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 83);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(52, 138);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(54, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 35);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 5;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(162, 135);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(229, 22);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(229, 22);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(444, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(440, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(288, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(472, 405);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 25);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Visible = false;
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(413, 193);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(62, 20);
            this.chkShowPass.TabIndex = 13;
            this.chkShowPass.Text = "Show";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // pnlSecurity
            // 
            this.pnlSecurity.Controls.Add(this.label3);
            this.pnlSecurity.Controls.Add(this.label2);
            this.pnlSecurity.Controls.Add(this.label1);
            this.pnlSecurity.Controls.Add(this.btnCancelSecurity);
            this.pnlSecurity.Controls.Add(this.btnSaveSecurity);
            this.pnlSecurity.Controls.Add(this.txtSecretAnswer);
            this.pnlSecurity.Controls.Add(this.txtSecretQuestion);
            this.pnlSecurity.Controls.Add(this.txtConfirmPassword);
            this.pnlSecurity.Controls.Add(this.lblSecHeading);
            this.pnlSecurity.Location = new System.Drawing.Point(96, 35);
            this.pnlSecurity.Name = "pnlSecurity";
            this.pnlSecurity.Size = new System.Drawing.Size(545, 360);
            this.pnlSecurity.TabIndex = 14;
            this.pnlSecurity.Visible = false;
            this.pnlSecurity.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCancelSecurity_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Secret Answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Secret Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // btnCancelSecurity
            // 
            this.btnCancelSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSecurity.Location = new System.Drawing.Point(318, 240);
            this.btnCancelSecurity.Name = "btnCancelSecurity";
            this.btnCancelSecurity.Size = new System.Drawing.Size(89, 42);
            this.btnCancelSecurity.TabIndex = 5;
            this.btnCancelSecurity.Text = "Cancel";
            this.btnCancelSecurity.UseVisualStyleBackColor = true;
            this.btnCancelSecurity.Click += new System.EventHandler(this.btnCancelSecurity_Click);
            // 
            // btnSaveSecurity
            // 
            this.btnSaveSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSecurity.Location = new System.Drawing.Point(35, 240);
            this.btnSaveSecurity.Name = "btnSaveSecurity";
            this.btnSaveSecurity.Size = new System.Drawing.Size(75, 42);
            this.btnSaveSecurity.TabIndex = 4;
            this.btnSaveSecurity.Text = "Save";
            this.btnSaveSecurity.UseVisualStyleBackColor = true;
            this.btnSaveSecurity.Click += new System.EventHandler(this.btnSaveSecurity_Click);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Location = new System.Drawing.Point(183, 163);
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(250, 22);
            this.txtSecretAnswer.TabIndex = 3;
            // 
            // txtSecretQuestion
            // 
            this.txtSecretQuestion.Location = new System.Drawing.Point(183, 111);
            this.txtSecretQuestion.Name = "txtSecretQuestion";
            this.txtSecretQuestion.Size = new System.Drawing.Size(250, 22);
            this.txtSecretQuestion.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(183, 59);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 22);
            this.txtConfirmPassword.TabIndex = 1;
            // 
            // lblSecHeading
            // 
            this.lblSecHeading.AutoSize = true;
            this.lblSecHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecHeading.Location = new System.Drawing.Point(166, 17);
            this.lblSecHeading.Name = "lblSecHeading";
            this.lblSecHeading.Size = new System.Drawing.Size(188, 25);
            this.lblSecHeading.TabIndex = 0;
            this.lblSecHeading.Text = "Update Security Info";
            // 
            // btnEditSecurity
            // 
            this.btnEditSecurity.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSecurity.Location = new System.Drawing.Point(182, 401);
            this.btnEditSecurity.Name = "btnEditSecurity";
            this.btnEditSecurity.Size = new System.Drawing.Size(153, 37);
            this.btnEditSecurity.TabIndex = 15;
            this.btnEditSecurity.Text = "Edit Security Info";
            this.btnEditSecurity.UseVisualStyleBackColor = false;
            this.btnEditSecurity.Click += new System.EventHandler(this.btnEditSecurity_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.chkShowPass);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.btnEdit);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Location = new System.Drawing.Point(64, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(608, 307);
            this.pnlMain.TabIndex = 16;
            // 
            // FormCustomerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(726, 495);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSecurity);
            this.Controls.Add(this.btnEditSecurity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.goback1);
            this.Name = "FormCustomerProfile";
            this.Text = "Customer Profile";
            this.Load += new System.EventHandler(this.FormCustomerProfile_Load);
            this.goback1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgoback1)).EndInit();
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSecurity.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goback1;
        private System.Windows.Forms.PictureBox picgoback1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Panel pnlSecurity;
        private System.Windows.Forms.Button btnCancelSecurity;
        private System.Windows.Forms.Button btnSaveSecurity;
        private System.Windows.Forms.TextBox txtSecretAnswer;
        private System.Windows.Forms.TextBox txtSecretQuestion;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblSecHeading;
        private System.Windows.Forms.Button btnEditSecurity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;

    }
}