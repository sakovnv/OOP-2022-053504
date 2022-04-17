
using Lab_Work.Entities;

namespace Lab_Work
{
    partial class RegisterForm
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
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.hasAccountLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PassportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.PassportNumberTextBox = new System.Windows.Forms.TextBox();
            this.BanksComboBox = new System.Windows.Forms.ComboBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrationLabel.Location = new System.Drawing.Point(60, 25);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(241, 51);
            this.RegistrationLabel.TabIndex = 11;
            this.RegistrationLabel.Text = "Registration";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(12, 587);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(340, 60);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LoginLinkLabel.Location = new System.Drawing.Point(312, 139);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Size = new System.Drawing.Size(40, 15);
            this.LoginLinkLabel.TabIndex = 9;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Log in";
            this.LoginLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.LoginLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkLabel_LinkClicked);
            // 
            // hasAccountLabel
            // 
            this.hasAccountLabel.AutoSize = true;
            this.hasAccountLabel.Location = new System.Drawing.Point(212, 115);
            this.hasAccountLabel.Name = "hasAccountLabel";
            this.hasAccountLabel.Size = new System.Drawing.Size(140, 15);
            this.hasAccountLabel.TabIndex = 8;
            this.hasAccountLabel.Text = "Do you have an account?";
            this.hasAccountLabel.Click += new System.EventHandler(this.hasAccountLabel_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 480);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(340, 32);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginTextBox.Location = new System.Drawing.Point(12, 180);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PlaceholderText = "Login";
            this.LoginTextBox.Size = new System.Drawing.Size(340, 32);
            this.LoginTextBox.TabIndex = 6;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(12, 530);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PlaceholderText = "Repeat password";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(340, 32);
            this.RepeatPasswordTextBox.TabIndex = 9;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(12, 230);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(340, 32);
            this.EmailTextBox.TabIndex = 7;
            // 
            // PassportSeriesTextBox
            // 
            this.PassportSeriesTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportSeriesTextBox.Location = new System.Drawing.Point(12, 380);
            this.PassportSeriesTextBox.Name = "PassportSeriesTextBox";
            this.PassportSeriesTextBox.PlaceholderText = "Passport series";
            this.PassportSeriesTextBox.Size = new System.Drawing.Size(340, 32);
            this.PassportSeriesTextBox.TabIndex = 12;
            // 
            // PassportNumberTextBox
            // 
            this.PassportNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportNumberTextBox.Location = new System.Drawing.Point(12, 430);
            this.PassportNumberTextBox.Name = "PassportNumberTextBox";
            this.PassportNumberTextBox.PlaceholderText = "Passport number";
            this.PassportNumberTextBox.Size = new System.Drawing.Size(340, 32);
            this.PassportNumberTextBox.TabIndex = 13;
            // 
            // BanksComboBox
            // 
            this.BanksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BanksComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BanksComboBox.FormattingEnabled = true;
            this.BanksComboBox.Location = new System.Drawing.Point(12, 121);
            this.BanksComboBox.Name = "BanksComboBox";
            this.BanksComboBox.Size = new System.Drawing.Size(134, 33);
            this.BanksComboBox.TabIndex = 14;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameTextBox.Location = new System.Drawing.Point(12, 280);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.PlaceholderText = "Full name";
            this.FullNameTextBox.Size = new System.Drawing.Size(340, 32);
            this.FullNameTextBox.TabIndex = 15;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 330);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.PlaceholderText = "Phone number";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(340, 32);
            this.PhoneNumberTextBox.TabIndex = 16;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 659);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.BanksComboBox);
            this.Controls.Add(this.PassportNumberTextBox);
            this.Controls.Add(this.PassportSeriesTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.hasAccountLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
        private System.Windows.Forms.Label hasAccountLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PassportSeriesTextBox;
        private System.Windows.Forms.TextBox PassportNumberTextBox;
        private System.Windows.Forms.ComboBox BanksComboBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
    }
}