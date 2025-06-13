namespace oop_aasignment
{
    partial class FormOrderManagement
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
            this.goback3 = new System.Windows.Forms.Panel();
            this.picgoback3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnGoToMenu = new System.Windows.Forms.Button();
            this.goback3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgoback3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // goback3
            // 
            this.goback3.Controls.Add(this.picgoback3);
            this.goback3.Location = new System.Drawing.Point(12, 442);
            this.goback3.Name = "goback3";
            this.goback3.Size = new System.Drawing.Size(41, 47);
            this.goback3.TabIndex = 0;
            // 
            // picgoback3
            // 
            this.picgoback3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgoback3.Image = global::oop_aasignment.Properties.Resources.back;
            this.picgoback3.Location = new System.Drawing.Point(0, 0);
            this.picgoback3.Name = "picgoback3";
            this.picgoback3.Size = new System.Drawing.Size(41, 47);
            this.picgoback3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgoback3.TabIndex = 0;
            this.picgoback3.TabStop = false;
            this.picgoback3.Click += new System.EventHandler(this.picgoback3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(258, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "My Orders";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(48, 105);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(280, 24);
            this.cmbStatusFilter.TabIndex = 2;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(26, 154);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(910, 250);
            this.dgvOrders.TabIndex = 4;
            // 
            // btnGoToMenu
            // 
            this.btnGoToMenu.BackColor = System.Drawing.Color.Peru;
            this.btnGoToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToMenu.Location = new System.Drawing.Point(454, 427);
            this.btnGoToMenu.Name = "btnGoToMenu";
            this.btnGoToMenu.Size = new System.Drawing.Size(222, 42);
            this.btnGoToMenu.TabIndex = 5;
            this.btnGoToMenu.Text = "Go to Menu to Order";
            this.btnGoToMenu.UseVisualStyleBackColor = false;
            this.btnGoToMenu.Click += new System.EventHandler(this.btnGoToMenu_Click);
            // 
            // FormOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(948, 525);
            this.Controls.Add(this.btnGoToMenu);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.goback3);
            this.Name = "FormOrderManagement";
            this.Text = "Order Management";
            this.Load += new System.EventHandler(this.FormOrderManagement_Load);
            this.goback3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgoback3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goback3;
        private System.Windows.Forms.PictureBox picgoback3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnGoToMenu;
    }
}