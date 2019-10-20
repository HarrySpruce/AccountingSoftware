namespace AccountingSoftware
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.createUser = new System.Windows.Forms.Button();
            this.loginReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(40, 25);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(309, 206);
            this.createUser.TabIndex = 7;
            this.createUser.Text = "Create User";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // loginReturn
            // 
            this.loginReturn.Location = new System.Drawing.Point(40, 252);
            this.loginReturn.Name = "loginReturn";
            this.loginReturn.Size = new System.Drawing.Size(309, 86);
            this.loginReturn.TabIndex = 8;
            this.loginReturn.Text = "Return to Login Screen";
            this.loginReturn.UseVisualStyleBackColor = true;
            this.loginReturn.Click += new System.EventHandler(this.loginReturn2);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 421);
            this.Controls.Add(this.loginReturn);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Admin Overview Panel";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button loginReturn;
    }
}