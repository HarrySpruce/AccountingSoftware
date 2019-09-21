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
            this.SuspendLayout();
            // 
            // formEditorButton
            // 
            this.formEditorButton.Location = new System.Drawing.Point(20, 20);
            this.formEditorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formEditorButton.Name = "formEditorButton";
            this.formEditorButton.Size = new System.Drawing.Size(207, 178);
            this.formEditorButton.TabIndex = 0;
            this.formEditorButton.Text = "Form Editor";
            this.formEditorButton.UseVisualStyleBackColor = true;
            this.formEditorButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.formEditorButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Overview";
            this.Text = "Overview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button formEditorButton;
    }
}