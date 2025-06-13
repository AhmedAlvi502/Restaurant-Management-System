namespace oop_aasignment
{
    partial class RespondToFeedback
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnSubmitResponse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbFeedback = new System.Windows.Forms.ComboBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(15, 246);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(1138, 306);
            this.txtResponse.TabIndex = 1;
            // 
            // btnSubmitResponse
            // 
            this.btnSubmitResponse.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmitResponse.Location = new System.Drawing.Point(228, 611);
            this.btnSubmitResponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitResponse.Name = "btnSubmitResponse";
            this.btnSubmitResponse.Size = new System.Drawing.Size(150, 46);
            this.btnSubmitResponse.TabIndex = 2;
            this.btnSubmitResponse.Text = "Submit";
            this.btnSubmitResponse.UseVisualStyleBackColor = false;
            this.btnSubmitResponse.Click += new System.EventHandler(this.btnSubmitResponse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Respond to Feedback";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(15, 569);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(128, 20);
            this.lblCharCount.TabIndex = 5;
            this.lblCharCount.Text = "0/500 characters";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightBlue;
            this.btnClear.Location = new System.Drawing.Point(717, 611);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 46);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbFeedback
            // 
            this.cbFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFeedback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFeedback.FormattingEnabled = true;
            this.cbFeedback.Location = new System.Drawing.Point(47, 77);
            this.cbFeedback.Name = "cbFeedback";
            this.cbFeedback.Size = new System.Drawing.Size(1106, 28);
            this.cbFeedback.TabIndex = 0;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.LightGray;
            this.btnGoBack.Location = new System.Drawing.Point(1079, 627);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(94, 41);
            this.btnGoBack.TabIndex = 7;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // RespondToFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.cbFeedback);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitResponse);
            this.Controls.Add(this.txtResponse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RespondToFeedback";
            this.Text = "RespondToFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnSubmitResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbFeedback;
        private System.Windows.Forms.Button btnGoBack;
    }
}