namespace oop_aasignment
{
    partial class FormFeedback
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
            this.goback5 = new System.Windows.Forms.Panel();
            this.picgoback5 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlPrevious = new System.Windows.Forms.Panel();
            this.dgvPreviousFeedback = new System.Windows.Forms.DataGridView();
            this.btnViewFeedbacks = new System.Windows.Forms.Button();
            this.goback5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgoback5)).BeginInit();
            this.pnlPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // goback5
            // 
            this.goback5.Controls.Add(this.picgoback5);
            this.goback5.Location = new System.Drawing.Point(12, 388);
            this.goback5.Name = "goback5";
            this.goback5.Size = new System.Drawing.Size(50, 50);
            this.goback5.TabIndex = 0;
            // 
            // picgoback5
            // 
            this.picgoback5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picgoback5.Image = global::oop_aasignment.Properties.Resources.back;
            this.picgoback5.Location = new System.Drawing.Point(0, 0);
            this.picgoback5.Name = "picgoback5";
            this.picgoback5.Size = new System.Drawing.Size(50, 50);
            this.picgoback5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgoback5.TabIndex = 0;
            this.picgoback5.TabStop = false;
            this.picgoback5.Click += new System.EventHandler(this.picgoback5_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(260, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "We Value Your Feedback!";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(16, 160);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(706, 215);
            this.txtFeedback.TabIndex = 2;
            this.txtFeedback.Enter += new System.EventHandler(this.txtFeedback_Enter);
            this.txtFeedback.Leave += new System.EventHandler(this.txtFeedback_Leave);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(28, 113);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Peru;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(105, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 33);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(236, 399);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 20);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "label2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(616, 48);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(616, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(172, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // pnlPrevious
            // 
            this.pnlPrevious.Controls.Add(this.dgvPreviousFeedback);
            this.pnlPrevious.Location = new System.Drawing.Point(16, 160);
            this.pnlPrevious.Name = "pnlPrevious";
            this.pnlPrevious.Size = new System.Drawing.Size(754, 215);
            this.pnlPrevious.TabIndex = 9;
            this.pnlPrevious.Visible = false;
            // 
            // dgvPreviousFeedback
            // 
            this.dgvPreviousFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreviousFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousFeedback.Location = new System.Drawing.Point(24, 19);
            this.dgvPreviousFeedback.Name = "dgvPreviousFeedback";
            this.dgvPreviousFeedback.ReadOnly = true;
            this.dgvPreviousFeedback.RowHeadersWidth = 51;
            this.dgvPreviousFeedback.RowTemplate.Height = 24;
            this.dgvPreviousFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreviousFeedback.Size = new System.Drawing.Size(716, 163);
            this.dgvPreviousFeedback.TabIndex = 0;
            // 
            // btnViewFeedbacks
            // 
            this.btnViewFeedbacks.BackColor = System.Drawing.Color.Peru;
            this.btnViewFeedbacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewFeedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFeedbacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFeedbacks.Location = new System.Drawing.Point(603, 393);
            this.btnViewFeedbacks.Name = "btnViewFeedbacks";
            this.btnViewFeedbacks.Size = new System.Drawing.Size(137, 33);
            this.btnViewFeedbacks.TabIndex = 10;
            this.btnViewFeedbacks.Text = "View / Edit";
            this.btnViewFeedbacks.UseVisualStyleBackColor = false;
            this.btnViewFeedbacks.Click += new System.EventHandler(this.btnViewFeedbacks_Click);
            // 
            // FormFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewFeedbacks);
            this.Controls.Add(this.pnlPrevious);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.goback5);
            this.Name = "FormFeedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.FormFeedback_Load);
            this.goback5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgoback5)).EndInit();
            this.pnlPrevious.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel goback5;
        private System.Windows.Forms.PictureBox picgoback5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlPrevious;
        private System.Windows.Forms.DataGridView dgvPreviousFeedback;
        private System.Windows.Forms.Button btnViewFeedbacks;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormFeedback
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(936, 489);
        //    this.Name = "FormFeedback";
        //    this.Text = "FormFeedback";
        //    this.Load += new System.EventHandler(this.FormFeedback_Load);
        //    this.ResumeLayout(false);

        //}

        #endregion
    }
}