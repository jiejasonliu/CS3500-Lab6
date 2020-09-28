namespace TipCalculator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TotalBillLabel = new System.Windows.Forms.Label();
            this.TotalBillField = new System.Windows.Forms.TextBox();
            this.TipField = new System.Windows.Forms.TextBox();
            this.TipPctLabel = new System.Windows.Forms.Label();
            this.TipPctField = new System.Windows.Forms.TextBox();
            this.TotalAmtLabel = new System.Windows.Forms.Label();
            this.TotalAmtField = new System.Windows.Forms.TextBox();
            this.TipAmtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TotalBillLabel
            // 
            this.TotalBillLabel.AutoSize = true;
            this.TotalBillLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalBillLabel.Location = new System.Drawing.Point(78, 60);
            this.TotalBillLabel.Name = "TotalBillLabel";
            this.TotalBillLabel.Size = new System.Drawing.Size(99, 16);
            this.TotalBillLabel.TabIndex = 0;
            this.TotalBillLabel.Text = "Enter Total Bill";
            // 
            // TotalBillField
            // 
            this.TotalBillField.Location = new System.Drawing.Point(207, 58);
            this.TotalBillField.Name = "TotalBillField";
            this.TotalBillField.Size = new System.Drawing.Size(96, 23);
            this.TotalBillField.TabIndex = 2;
            this.TotalBillField.TextChanged += new System.EventHandler(this.TotalBillField_TextChanged);
            // 
            // TipField
            // 
            this.TipField.Location = new System.Drawing.Point(195, 178);
            this.TipField.Name = "TipField";
            this.TipField.Size = new System.Drawing.Size(131, 23);
            this.TipField.TabIndex = 3;
            // 
            // TipPctLabel
            // 
            this.TipPctLabel.AutoSize = true;
            this.TipPctLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipPctLabel.Location = new System.Drawing.Point(66, 109);
            this.TipPctLabel.Name = "TipPctLabel";
            this.TipPctLabel.Size = new System.Drawing.Size(126, 16);
            this.TipPctLabel.TabIndex = 0;
            this.TipPctLabel.Text = "Enter Tip (decimal)";
            // 
            // TipPctField
            // 
            this.TipPctField.Location = new System.Drawing.Point(207, 102);
            this.TipPctField.Name = "TipPctField";
            this.TipPctField.Size = new System.Drawing.Size(96, 23);
            this.TipPctField.TabIndex = 2;
            this.TipPctField.TextChanged += new System.EventHandler(this.TipPctField_TextChanged);
            // 
            // TotalAmtLabel
            // 
            this.TotalAmtLabel.AutoSize = true;
            this.TotalAmtLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalAmtLabel.Location = new System.Drawing.Point(78, 230);
            this.TotalAmtLabel.Name = "TotalAmtLabel";
            this.TotalAmtLabel.Size = new System.Drawing.Size(93, 16);
            this.TotalAmtLabel.TabIndex = 0;
            this.TotalAmtLabel.Text = "Total Amount";
            // 
            // TotalAmtField
            // 
            this.TotalAmtField.Location = new System.Drawing.Point(195, 223);
            this.TotalAmtField.Name = "TotalAmtField";
            this.TotalAmtField.Size = new System.Drawing.Size(131, 23);
            this.TotalAmtField.TabIndex = 3;
            // 
            // TipAmtLabel
            // 
            this.TipAmtLabel.AutoSize = true;
            this.TipAmtLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TipAmtLabel.Location = new System.Drawing.Point(85, 180);
            this.TipAmtLabel.Name = "TipAmtLabel";
            this.TipAmtLabel.Size = new System.Drawing.Size(81, 16);
            this.TipAmtLabel.TabIndex = 0;
            this.TipAmtLabel.Text = "Tip Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 310);
            this.Controls.Add(this.TipAmtLabel);
            this.Controls.Add(this.TotalAmtField);
            this.Controls.Add(this.TotalAmtLabel);
            this.Controls.Add(this.TipPctField);
            this.Controls.Add(this.TipPctLabel);
            this.Controls.Add(this.TipField);
            this.Controls.Add(this.TotalBillField);
            this.Controls.Add(this.TotalBillLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalBillLabel;
        private System.Windows.Forms.TextBox TotalBillField;
        private System.Windows.Forms.TextBox TipField;
        private System.Windows.Forms.Label TipPctLabel;
        private System.Windows.Forms.TextBox TipPctField;
        private System.Windows.Forms.Label TotalAmtLabel;
        private System.Windows.Forms.TextBox TotalAmtField;
        private System.Windows.Forms.Label TipAmtLabel;
    }
}

