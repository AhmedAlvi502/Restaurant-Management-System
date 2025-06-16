namespace oop_aasignment
{
    partial class formViewEWallet
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
            this.lblEWalletViewer = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblWalletID = new System.Windows.Forms.Label();
            this.cmbWalletID = new System.Windows.Forms.ComboBox();
            this.btnEWalletReport = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnExitViewer = new System.Windows.Forms.Button();
            this.dgvEWallet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWallet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEWalletViewer
            // 
            this.lblEWalletViewer.AutoSize = true;
            this.lblEWalletViewer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEWalletViewer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEWalletViewer.Location = new System.Drawing.Point(299, 29);
            this.lblEWalletViewer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEWalletViewer.Name = "lblEWalletViewer";
            this.lblEWalletViewer.Size = new System.Drawing.Size(310, 37);
            this.lblEWalletViewer.TabIndex = 3;
            this.lblEWalletViewer.Text = "EWallet Top-up Viewer";
            this.lblEWalletViewer.Click += new System.EventHandler(this.lblEWalletViewer_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblYear.Location = new System.Drawing.Point(415, 95);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(96, 23);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Select Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMonth.Location = new System.Drawing.Point(161, 95);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(116, 23);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Select Month";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2024",
            "2025"});
            this.cmbYear.Location = new System.Drawing.Point(372, 136);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(172, 24);
            this.cmbYear.TabIndex = 4;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "5",
            "6"});
            this.cmbMonth.Location = new System.Drawing.Point(135, 136);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(172, 24);
            this.cmbMonth.TabIndex = 5;
            // 
            // lblWalletID
            // 
            this.lblWalletID.AutoSize = true;
            this.lblWalletID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWalletID.Location = new System.Drawing.Point(615, 95);
            this.lblWalletID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWalletID.Name = "lblWalletID";
            this.lblWalletID.Size = new System.Drawing.Size(132, 23);
            this.lblWalletID.TabIndex = 8;
            this.lblWalletID.Text = "Select WalletID";
            // 
            // cmbWalletID
            // 
            this.cmbWalletID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWalletID.FormattingEnabled = true;
            this.cmbWalletID.Items.AddRange(new object[] {
            "21",
            "22",
            "23"});
            this.cmbWalletID.Location = new System.Drawing.Point(598, 136);
            this.cmbWalletID.Name = "cmbWalletID";
            this.cmbWalletID.Size = new System.Drawing.Size(172, 24);
            this.cmbWalletID.TabIndex = 9;
            // 
            // btnEWalletReport
            // 
            this.btnEWalletReport.BackColor = System.Drawing.Color.LightGreen;
            this.btnEWalletReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEWalletReport.Location = new System.Drawing.Point(400, 405);
            this.btnEWalletReport.Name = "btnEWalletReport";
            this.btnEWalletReport.Size = new System.Drawing.Size(159, 33);
            this.btnEWalletReport.TabIndex = 20;
            this.btnEWalletReport.Text = "Generate Report";
            this.btnEWalletReport.UseVisualStyleBackColor = false;
            this.btnEWalletReport.Click += new System.EventHandler(this.btnEWalletReport_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.Black;
            this.btnClearFields.Location = new System.Drawing.Point(765, 405);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(144, 33);
            this.btnClearFields.TabIndex = 19;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnExitViewer
            // 
            this.btnExitViewer.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitViewer.ForeColor = System.Drawing.Color.Black;
            this.btnExitViewer.Location = new System.Drawing.Point(59, 405);
            this.btnExitViewer.Name = "btnExitViewer";
            this.btnExitViewer.Size = new System.Drawing.Size(144, 33);
            this.btnExitViewer.TabIndex = 18;
            this.btnExitViewer.Text = "Exit Viewer";
            this.btnExitViewer.UseVisualStyleBackColor = false;
            this.btnExitViewer.Click += new System.EventHandler(this.btnExitViewer_Click);
            // 
            // dgvEWallet
            // 
            this.dgvEWallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEWallet.Location = new System.Drawing.Point(106, 186);
            this.dgvEWallet.Name = "dgvEWallet";
            this.dgvEWallet.RowHeadersWidth = 51;
            this.dgvEWallet.RowTemplate.Height = 24;
            this.dgvEWallet.Size = new System.Drawing.Size(749, 193);
            this.dgvEWallet.TabIndex = 21;
            // 
            // formViewEWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(962, 468);
            this.Controls.Add(this.dgvEWallet);
            this.Controls.Add(this.btnEWalletReport);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnExitViewer);
            this.Controls.Add(this.cmbWalletID);
            this.Controls.Add(this.lblWalletID);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblEWalletViewer);
            this.Name = "formViewEWallet";
            this.Text = "EWallet Top-up Viewer";
            this.Load += new System.EventHandler(this.formViewEWallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWallet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEWalletViewer;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblWalletID;
        private System.Windows.Forms.ComboBox cmbWalletID;
        private System.Windows.Forms.Button btnEWalletReport;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnExitViewer;
        private System.Windows.Forms.DataGridView dgvEWallet;
    }
}