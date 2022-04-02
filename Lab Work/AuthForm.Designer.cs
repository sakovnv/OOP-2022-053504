
namespace Lab_Work
{
    partial class AuthForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.hasAccountLabel = new System.Windows.Forms.Label();
            this.RegisterLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AuthButton = new System.Windows.Forms.Button();
            this.AuthorizationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.Location = new System.Drawing.Point(12, 185);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Login";
            this.LoginTextBox.Size = new System.Drawing.Size(340, 32);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 251);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(340, 32);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // hasAccountLabel
            // 
            this.hasAccountLabel.AutoSize = true;
            this.hasAccountLabel.Location = new System.Drawing.Point(221, 119);
            this.hasAccountLabel.Name = "hasAccountLabel";
            this.hasAccountLabel.Size = new System.Drawing.Size(131, 15);
            this.hasAccountLabel.TabIndex = 2;
            this.hasAccountLabel.Text = "Don\'t have an account?";
            // 
            // RegisterLinkLabel
            // 
            this.RegisterLinkLabel.AutoSize = true;
            this.RegisterLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.RegisterLinkLabel.Location = new System.Drawing.Point(303, 143);
            this.RegisterLinkLabel.Name = "RegisterLinkLabel";
            this.RegisterLinkLabel.Size = new System.Drawing.Size(49, 15);
            this.RegisterLinkLabel.TabIndex = 3;
            this.RegisterLinkLabel.TabStop = true;
            this.RegisterLinkLabel.Text = "Register";
            this.RegisterLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.RegisterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(12, 321);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(340, 60);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Auth";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // AuthorizationLabel
            // 
            this.AuthorizationLabel.AutoSize = true;
            this.AuthorizationLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorizationLabel.Location = new System.Drawing.Point(44, 27);
            this.AuthorizationLabel.Name = "AuthorizationLabel";
            this.AuthorizationLabel.Size = new System.Drawing.Size(269, 51);
            this.AuthorizationLabel.TabIndex = 5;
            this.AuthorizationLabel.Text = "Authorization";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 393);
            this.Controls.Add(this.AuthorizationLabel);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.RegisterLinkLabel);
            this.Controls.Add(this.hasAccountLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label hasAccountLabel;
        private System.Windows.Forms.LinkLabel RegisterLinkLabel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label AuthorizationLabel;
    }
}