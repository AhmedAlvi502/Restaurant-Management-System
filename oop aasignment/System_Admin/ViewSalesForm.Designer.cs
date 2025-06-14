namespace oop_aasignment
{
    partial class formSalesView
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
            this.components = new System.ComponentModel.Container();
            this.lblSalesViewer = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbChef = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.sqlCommandBuilder1 = new System.Data.SqlClient.SqlCommandBuilder();
            this.btnExitViewer = new System.Windows.Forms.Button();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesViewer
            // 
            this.lblSalesViewer.AutoSize = true;
            this.lblSalesViewer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesViewer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSalesViewer.Location = new System.Drawing.Point(344, 44);
            this.lblSalesViewer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesViewer.Name = "lblSalesViewer";
            this.lblSalesViewer.Size = new System.Drawing.Size(274, 37);
            this.lblSalesViewer.TabIndex = 2;
            this.lblSalesViewer.Text = "Sales Report Viewer";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "\"5\"",
            "\"6\""});
            this.cmbMonth.Location = new System.Drawing.Point(35, 148);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(172, 24);
            this.cmbMonth.TabIndex = 0;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "\"2024\"",
            "\"2025\""});
            this.cmbYear.Location = new System.Drawing.Point(230, 148);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(172, 24);
            this.cmbYear.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Vegetarian",
            "Italian",
            "Local Malaysian",
            "Drinks"});
            this.cmbCategory.Location = new System.Drawing.Point(425, 148);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(172, 24);
            this.cmbCategory.TabIndex = 0;
            // 
            // cmbChef
            // 
            this.cmbChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChef.FormattingEnabled = true;
            this.cmbChef.Items.AddRange(new object[] {
            "Said",
            "Adel",
            "Aiman",
            "David"});
            this.cmbChef.Location = new System.Drawing.Point(627, 148);
            this.cmbChef.Name = "cmbChef";
            this.cmbChef.Size = new System.Drawing.Size(172, 24);
            this.cmbChef.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMonth.Location = new System.Drawing.Point(60, 113);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(116, 23);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Select Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblYear.Location = new System.Drawing.Point(264, 113);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(96, 23);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Select Year";
            // 
            // lblChef
            // 
            this.lblChef.AutoSize = true;
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChef.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChef.Location = new System.Drawing.Point(647, 113);
            this.lblChef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(100, 23);
            this.lblChef.TabIndex = 3;
            this.lblChef.Text = "Select Chef";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategory.Location = new System.Drawing.Point(441, 113);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(137, 23);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Select Category";
            // 
            // btnExitViewer
            // 
            this.btnExitViewer.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitViewer.ForeColor = System.Drawing.Color.Black;
            this.btnExitViewer.Location = new System.Drawing.Point(30, 499);
            this.btnExitViewer.Name = "btnExitViewer";
            this.btnExitViewer.Size = new System.Drawing.Size(144, 33);
            this.btnExitViewer.TabIndex = 12;
            this.btnExitViewer.Text = "Exit Viewer";
            this.btnExitViewer.UseVisualStyleBackColor = false;
            this.btnExitViewer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.IndianRed;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.Black;
            this.btnClearFields.Location = new System.Drawing.Point(815, 499);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(144, 33);
            this.btnClearFields.TabIndex = 16;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.LightGreen;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.Location = new System.Drawing.Point(399, 499);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(159, 33);
            this.btnGenReport.TabIndex = 17;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.ColumnHeadersHeight = 29;
            this.salesDataGridView.Location = new System.Drawing.Point(35, 205);
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.RowHeadersWidth = 51;
            this.salesDataGridView.RowTemplate.Height = 24;
            this.salesDataGridView.Size = new System.Drawing.Size(924, 261);
            this.salesDataGridView.TabIndex = 18;
            // 
            // formSalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(999, 586);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnExitViewer);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblSalesViewer);
            this.Controls.Add(this.cmbChef);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Name = "formSalesView";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.formSalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSalesViewer;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbChef;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.BindingSource sedapMakanSalesBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.Button btnExitViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnGenReport;
        private System.Windows.Forms.DataGridView salesDataGridView;
    }
}