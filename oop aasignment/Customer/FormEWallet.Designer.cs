namespace oop_aasignment
{
    partial class FormEWallet
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
            this.goback4 = new System.Windows.Forms.Panel();
            this.picgoback4 = new System.Windows.Forms.PictureBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTopUp = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblTopUp = new System.Windows.Forms.Label();
            this.lblTopUpMessage = new System.Windows.Forms.Label();
            this.btnCancelTopUp = new System.Windows.Forms.Button();
            this.btnConfirmTopUp = new System.Windows.Forms.Button();
            this.txtTopUpPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtTopUpAmount = new System.Windows.Forms.TextBox();
            this.lblTopUpAmount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.goback4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgoback4)).BeginInit();
            this.pnlTopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // goback4
            // 
            this.goback4.Controls.Add(this.picgoback4);
            this.goback4.Location = new System.Drawing.Point(11, 462);
            this.goback4.Name = "goback4";
            this.goback4.Size = new System.Drawing.Size(50, 50);
            this.goback4.TabIndex = 0;
            // 
            // picgoback4
            // 
            this.picgoback4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgoback4.Image = global::oop_aasignment.Properties.Resources.back;
            this.picgoback4.Location = new System.Drawing.Point(0, 0);
            this.picgoback4.Name = "picgoback4";
            this.picgoback4.Size = new System.Drawing.Size(50, 50);
            this.picgoback4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgoback4.TabIndex = 0;
            this.picgoback4.TabStop = false;
            this.picgoback4.Click += new System.EventHandler(this.picgoback4_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(72, 219);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(102, 31);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "RM 0.00";
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.BackColor = System.Drawing.Color.Peru;
            this.btnAddFunds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFunds.Location = new System.Drawing.Point(74, 294);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(129, 37);
            this.btnAddFunds.TabIndex = 2;
            this.btnAddFunds.Text = "Add Funds";
            this.btnAddFunds.UseVisualStyleBackColor = false;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(546, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // pnlTopUp
            // 
            this.pnlTopUp.BackColor = System.Drawing.Color.Tan;
            this.pnlTopUp.Controls.Add(this.chkShowPassword);
            this.pnlTopUp.Controls.Add(this.lblTopUp);
            this.pnlTopUp.Controls.Add(this.lblTopUpMessage);
            this.pnlTopUp.Controls.Add(this.btnCancelTopUp);
            this.pnlTopUp.Controls.Add(this.btnConfirmTopUp);
            this.pnlTopUp.Controls.Add(this.txtTopUpPassword);
            this.pnlTopUp.Controls.Add(this.lblPassword);
            this.pnlTopUp.Controls.Add(this.cmbMethod);
            this.pnlTopUp.Controls.Add(this.lblMethod);
            this.pnlTopUp.Controls.Add(this.txtTopUpAmount);
            this.pnlTopUp.Controls.Add(this.lblTopUpAmount);
            this.pnlTopUp.Location = new System.Drawing.Point(269, 54);
            this.pnlTopUp.Name = "pnlTopUp";
            this.pnlTopUp.Size = new System.Drawing.Size(462, 428);
            this.pnlTopUp.TabIndex = 5;
            this.pnlTopUp.Visible = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(364, 188);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(62, 20);
            this.chkShowPassword.TabIndex = 10;
            this.chkShowPassword.Text = "Show";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblTopUp
            // 
            this.lblTopUp.AutoSize = true;
            this.lblTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUp.Location = new System.Drawing.Point(191, 15);
            this.lblTopUp.Name = "lblTopUp";
            this.lblTopUp.Size = new System.Drawing.Size(77, 25);
            this.lblTopUp.TabIndex = 9;
            this.lblTopUp.Text = "TopUp";
            // 
            // lblTopUpMessage
            // 
            this.lblTopUpMessage.AutoSize = true;
            this.lblTopUpMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUpMessage.Location = new System.Drawing.Point(39, 341);
            this.lblTopUpMessage.Name = "lblTopUpMessage";
            this.lblTopUpMessage.Size = new System.Drawing.Size(34, 28);
            this.lblTopUpMessage.TabIndex = 8;
            this.lblTopUpMessage.Text = "s/f";
            // 
            // btnCancelTopUp
            // 
            this.btnCancelTopUp.BackColor = System.Drawing.Color.Peru;
            this.btnCancelTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTopUp.Location = new System.Drawing.Point(216, 264);
            this.btnCancelTopUp.Name = "btnCancelTopUp";
            this.btnCancelTopUp.Size = new System.Drawing.Size(144, 33);
            this.btnCancelTopUp.TabIndex = 7;
            this.btnCancelTopUp.Text = "Cancel TopUp";
            this.btnCancelTopUp.UseVisualStyleBackColor = false;
            this.btnCancelTopUp.Click += new System.EventHandler(this.btnCancelTopUp_Click);
            // 
            // btnConfirmTopUp
            // 
            this.btnConfirmTopUp.BackColor = System.Drawing.Color.Peru;
            this.btnConfirmTopUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmTopUp.Location = new System.Drawing.Point(28, 264);
            this.btnConfirmTopUp.Name = "btnConfirmTopUp";
            this.btnConfirmTopUp.Size = new System.Drawing.Size(144, 33);
            this.btnConfirmTopUp.TabIndex = 6;
            this.btnConfirmTopUp.Text = "Confirm TopUp";
            this.btnConfirmTopUp.UseVisualStyleBackColor = false;
            this.btnConfirmTopUp.Click += new System.EventHandler(this.btnConfirmTopUp_Click);
            // 
            // txtTopUpPassword
            // 
            this.txtTopUpPassword.Location = new System.Drawing.Point(208, 187);
            this.txtTopUpPassword.Name = "txtTopUpPassword";
            this.txtTopUpPassword.Size = new System.Drawing.Size(131, 22);
            this.txtTopUpPassword.TabIndex = 5;
            this.txtTopUpPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(156, 22);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Confirm Password";
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Location = new System.Drawing.Point(208, 126);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(131, 24);
            this.cmbMethod.TabIndex = 3;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(25, 126);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(124, 22);
            this.lblMethod.TabIndex = 2;
            this.lblMethod.Text = "Select Method";
            // 
            // txtTopUpAmount
            // 
            this.txtTopUpAmount.Location = new System.Drawing.Point(207, 64);
            this.txtTopUpAmount.Name = "txtTopUpAmount";
            this.txtTopUpAmount.Size = new System.Drawing.Size(132, 22);
            this.txtTopUpAmount.TabIndex = 1;
            // 
            // lblTopUpAmount
            // 
            this.lblTopUpAmount.AutoSize = true;
            this.lblTopUpAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopUpAmount.Location = new System.Drawing.Point(25, 62);
            this.lblTopUpAmount.Name = "lblTopUpAmount";
            this.lblTopUpAmount.Size = new System.Drawing.Size(119, 22);
            this.lblTopUpAmount.TabIndex = 0;
            this.lblTopUpAmount.Text = "Enter Amount";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(279, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 38);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "My E-Wallet";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTitle.ForeColor = System.Drawing.Color.White;
            this.lblBalanceTitle.Location = new System.Drawing.Point(44, 191);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(163, 28);
            this.lblBalanceTitle.TabIndex = 7;
            this.lblBalanceTitle.Text = "Available Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::oop_aasignment.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(74, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(272, 125);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(456, 314);
            this.dgvHistory.TabIndex = 9;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionHistory.Location = new System.Drawing.Point(402, 93);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(197, 28);
            this.lblTransactionHistory.TabIndex = 10;
            this.lblTransactionHistory.Text = "Transaction History";
            // 
            // FormEWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.pnlTopUp);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBalanceTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAddFunds);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.goback4);
            this.Controls.Add(this.lblTransactionHistory);
            this.Name = "FormEWallet";
            this.Text = "E-Wallet";
            this.Load += new System.EventHandler(this.FormEWallet_Load);
            this.goback4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgoback4)).EndInit();
            this.pnlTopUp.ResumeLayout(false);
            this.pnlTopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goback4;
        private System.Windows.Forms.PictureBox picgoback4;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnAddFunds;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlTopUp;
        private System.Windows.Forms.Button btnCancelTopUp;
        private System.Windows.Forms.Button btnConfirmTopUp;
        private System.Windows.Forms.TextBox txtTopUpPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtTopUpAmount;
        private System.Windows.Forms.Label lblTopUpAmount;
        private System.Windows.Forms.Label lblTopUpMessage;
        private System.Windows.Forms.Label lblTopUp;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label lblTransactionHistory;
    }
}