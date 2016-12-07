namespace Project06_Jernigan
{
    partial class SignUp
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
            this.updateButton = new System.Windows.Forms.Button();
            this.mailingCB = new System.Windows.Forms.CheckBox();
            this.customerList = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.personList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(39, 245);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 44);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // mailingCB
            // 
            this.mailingCB.AutoSize = true;
            this.mailingCB.Location = new System.Drawing.Point(181, 245);
            this.mailingCB.Name = "mailingCB";
            this.mailingCB.Size = new System.Drawing.Size(78, 17);
            this.mailingCB.TabIndex = 1;
            this.mailingCB.Text = "Mailing List";
            this.mailingCB.UseVisualStyleBackColor = true;
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(26, 38);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(138, 173);
            this.customerList.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(312, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // personList
            // 
            this.personList.FormattingEnabled = true;
            this.personList.Location = new System.Drawing.Point(267, 38);
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size(138, 173);
            this.personList.TabIndex = 4;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 317);
            this.Controls.Add(this.personList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.mailingCB);
            this.Controls.Add(this.updateButton);
            this.Name = "SignUp";
            this.Text = "Customer Sign Up - Christopher Jernigan";
            this.Load += new System.EventHandler(this.CustomerSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.CheckBox mailingCB;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox personList;
    }
}

