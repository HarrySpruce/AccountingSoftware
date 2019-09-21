namespace AccountingSoftware
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Confirm = new System.Windows.Forms.Button();
            this.adminCode = new System.Windows.Forms.TextBox();
            this.enterCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(20, 98);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(112, 35);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // adminCode
            // 
            this.adminCode.Location = new System.Drawing.Point(20, 58);
            this.adminCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminCode.MaxLength = 4;
            this.adminCode.Name = "adminCode";
            this.adminCode.Size = new System.Drawing.Size(110, 26);
            this.adminCode.TabIndex = 1;
            this.adminCode.UseSystemPasswordChar = true;
            // 
            // enterCodeLabel
            // 
            this.enterCodeLabel.AutoSize = true;
            this.enterCodeLabel.Location = new System.Drawing.Point(20, 20);
            this.enterCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterCodeLabel.Name = "enterCodeLabel";
            this.enterCodeLabel.Size = new System.Drawing.Size(139, 20);
            this.enterCodeLabel.TabIndex = 2;
            this.enterCodeLabel.Text = "Enter Admin Code";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 349);
            this.Controls.Add(this.enterCodeLabel);
            this.Controls.Add(this.adminCode);
            this.Controls.Add(this.Confirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Admin Password Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox adminCode;
        private System.Windows.Forms.Label enterCodeLabel;
    }
}