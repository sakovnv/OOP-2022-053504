
namespace Lab_Work
{
    partial class CompanyRegisterForm
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
            this.TypeCompanyTextBox = new System.Windows.Forms.TextBox();
            this.LegalNameTextBox = new System.Windows.Forms.TextBox();
            this.PayerAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.BankIdentificationCodeTextBox = new System.Windows.Forms.TextBox();
            this.LegalAdressTextBox = new System.Windows.Forms.TextBox();
            this.RegisterCompanyLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BackLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TypeCompanyTextBox
            // 
            this.TypeCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeCompanyTextBox.Location = new System.Drawing.Point(12, 120);
            this.TypeCompanyTextBox.Name = "TypeCompanyTextBox";
            this.TypeCompanyTextBox.PlaceholderText = "Type";
            this.TypeCompanyTextBox.Size = new System.Drawing.Size(387, 32);
            this.TypeCompanyTextBox.TabIndex = 0;
            // 
            // LegalNameTextBox
            // 
            this.LegalNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LegalNameTextBox.Location = new System.Drawing.Point(12, 177);
            this.LegalNameTextBox.Name = "LegalNameTextBox";
            this.LegalNameTextBox.PlaceholderText = "Legal name";
            this.LegalNameTextBox.Size = new System.Drawing.Size(387, 32);
            this.LegalNameTextBox.TabIndex = 1;
            // 
            // PayerAccountNumberTextBox
            // 
            this.PayerAccountNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayerAccountNumberTextBox.Location = new System.Drawing.Point(12, 237);
            this.PayerAccountNumberTextBox.Name = "PayerAccountNumberTextBox";
            this.PayerAccountNumberTextBox.PlaceholderText = "Payer account number";
            this.PayerAccountNumberTextBox.Size = new System.Drawing.Size(387, 32);
            this.PayerAccountNumberTextBox.TabIndex = 2;
            // 
            // BankIdentificationCodeTextBox
            // 
            this.BankIdentificationCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankIdentificationCodeTextBox.Location = new System.Drawing.Point(12, 301);
            this.BankIdentificationCodeTextBox.Name = "BankIdentificationCodeTextBox";
            this.BankIdentificationCodeTextBox.PlaceholderText = "Bank Identification Code";
            this.BankIdentificationCodeTextBox.Size = new System.Drawing.Size(387, 32);
            this.BankIdentificationCodeTextBox.TabIndex = 3;
            // 
            // LegalAdressTextBox
            // 
            this.LegalAdressTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LegalAdressTextBox.Location = new System.Drawing.Point(12, 366);
            this.LegalAdressTextBox.Name = "LegalAdressTextBox";
            this.LegalAdressTextBox.PlaceholderText = "Legal adress";
            this.LegalAdressTextBox.Size = new System.Drawing.Size(387, 32);
            this.LegalAdressTextBox.TabIndex = 4;
            // 
            // RegisterCompanyLabel
            // 
            this.RegisterCompanyLabel.AutoSize = true;
            this.RegisterCompanyLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterCompanyLabel.Location = new System.Drawing.Point(60, 19);
            this.RegisterCompanyLabel.Name = "RegisterCompanyLabel";
            this.RegisterCompanyLabel.Size = new System.Drawing.Size(288, 45);
            this.RegisterCompanyLabel.TabIndex = 5;
            this.RegisterCompanyLabel.Text = "Register company";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(12, 431);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(387, 45);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BackLinkLabel
            // 
            this.BackLinkLabel.AutoSize = true;
            this.BackLinkLabel.Location = new System.Drawing.Point(12, 81);
            this.BackLinkLabel.Name = "BackLinkLabel";
            this.BackLinkLabel.Size = new System.Drawing.Size(32, 15);
            this.BackLinkLabel.TabIndex = 7;
            this.BackLinkLabel.TabStop = true;
            this.BackLinkLabel.Text = "Back";
            this.BackLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackLinkLabel_LinkClicked);
            // 
            // CompanyRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 488);
            this.Controls.Add(this.BackLinkLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RegisterCompanyLabel);
            this.Controls.Add(this.LegalAdressTextBox);
            this.Controls.Add(this.BankIdentificationCodeTextBox);
            this.Controls.Add(this.PayerAccountNumberTextBox);
            this.Controls.Add(this.LegalNameTextBox);
            this.Controls.Add(this.TypeCompanyTextBox);
            this.Name = "CompanyRegisterForm";
            this.Text = "CompanyRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TypeCompanyTextBox;
        private System.Windows.Forms.TextBox LegalNameTextBox;
        private System.Windows.Forms.TextBox PayerAccountNumberTextBox;
        private System.Windows.Forms.TextBox BankIdentificationCodeTextBox;
        private System.Windows.Forms.TextBox LegalAdressTextBox;
        private System.Windows.Forms.Label RegisterCompanyLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel BackLinkLabel;
    }
}