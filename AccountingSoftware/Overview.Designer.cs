namespace AccountingSoftware
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            this.formEditorButton = new System.Windows.Forms.Button();
            this.loginReturn = new System.Windows.Forms.Button();
            this.adminLogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formEditorButton
            // 
            this.formEditorButton.Location = new System.Drawing.Point(9, 14);
            this.formEditorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formEditorButton.Name = "formEditorButton";
            this.formEditorButton.Size = new System.Drawing.Size(207, 178);
            this.formEditorButton.TabIndex = 0;
            this.formEditorButton.Text = "Form Editor";
            this.formEditorButton.UseVisualStyleBackColor = true;
            this.formEditorButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // loginReturn
            // 
            this.loginReturn.Location = new System.Drawing.Point(12, 200);
            this.loginReturn.Name = "loginReturn";
            this.loginReturn.Size = new System.Drawing.Size(204, 182);
            this.loginReturn.TabIndex = 1;
            this.loginReturn.Text = "Return to Login";
            this.loginReturn.UseVisualStyleBackColor = true;
            this.loginReturn.Click += new System.EventHandler(this.returnLogin);
            // 
            // adminLogin
            // 
            this.adminLogin.Location = new System.Drawing.Point(223, 14);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(221, 178);
            this.adminLogin.TabIndex = 2;
            this.adminLogin.Text = "Admin Login";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminCodeEntry);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(223, 200);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(221, 182);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitLeave);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.loginReturn);
            this.Controls.Add(this.formEditorButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button formEditorButton;
        private System.Windows.Forms.Button loginReturn;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button Exit;
    }
}