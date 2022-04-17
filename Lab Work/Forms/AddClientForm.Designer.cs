
namespace Lab_Work
{
    partial class AddClientForm
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PassportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.PassportNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PassportSeriesLabel = new System.Windows.Forms.Label();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CancelAddingButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameTextBox.Location = new System.Drawing.Point(12, 48);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(424, 32);
            this.FullNameTextBox.TabIndex = 0;
            // 
            // PassportSeriesTextBox
            // 
            this.PassportSeriesTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportSeriesTextBox.Location = new System.Drawing.Point(12, 122);
            this.PassportSeriesTextBox.Name = "PassportSeriesTextBox";
            this.PassportSeriesTextBox.Size = new System.Drawing.Size(424, 32);
            this.PassportSeriesTextBox.TabIndex = 1;
            // 
            // PassportNumberTextBox
            // 
            this.PassportNumberTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportNumberTextBox.Location = new System.Drawing.Point(12, 199);
            this.PassportNumberTextBox.Name = "PassportNumberTextBox";
            this.PassportNumberTextBox.Size = new System.Drawing.Size(424, 32);
            this.PassportNumberTextBox.TabIndex = 2;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 275);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(424, 32);
            this.PhoneNumberTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameLabel.Location = new System.Drawing.Point(104, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(223, 30);
            this.FullNameLabel.TabIndex = 4;
            this.FullNameLabel.Text = "Input client\'s fullname";
            this.FullNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassportSeriesLabel
            // 
            this.PassportSeriesLabel.AutoSize = true;
            this.PassportSeriesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportSeriesLabel.Location = new System.Drawing.Point(139, 89);
            this.PassportSeriesLabel.Name = "PassportSeriesLabel";
            this.PassportSeriesLabel.Size = new System.Drawing.Size(155, 30);
            this.PassportSeriesLabel.TabIndex = 5;
            this.PassportSeriesLabel.Text = "Passport series";
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportNumberLabel.Location = new System.Drawing.Point(130, 166);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(176, 30);
            this.PassportNumberLabel.TabIndex = 6;
            this.PassportNumberLabel.Text = "Passport number";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(139, 242);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(156, 30);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "Phone number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(191, 322);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(64, 30);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(12, 355);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(424, 32);
            this.EmailTextBox.TabIndex = 8;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // CancelAddingButton
            // 
            this.CancelAddingButton.Location = new System.Drawing.Point(229, 403);
            this.CancelAddingButton.Name = "CancelAddingButton";
            this.CancelAddingButton.Size = new System.Drawing.Size(207, 49);
            this.CancelAddingButton.TabIndex = 10;
            this.CancelAddingButton.Text = "Cancel";
            this.CancelAddingButton.UseVisualStyleBackColor = true;
            this.CancelAddingButton.Click += new System.EventHandler(this.CancelAddingButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(12, 403);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(211, 49);
            this.AddClientButton.TabIndex = 11;
            this.AddClientButton.Text = "Add";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 461);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.CancelAddingButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PassportNumberLabel);
            this.Controls.Add(this.PassportSeriesLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PassportNumberTextBox);
            this.Controls.Add(this.PassportSeriesTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox PassportSeriesTextBox;
        private System.Windows.Forms.TextBox PassportNumberTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label PassportSeriesLabel;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button CancelAddingButton;
        private System.Windows.Forms.Button AddClientButton;
    }
}