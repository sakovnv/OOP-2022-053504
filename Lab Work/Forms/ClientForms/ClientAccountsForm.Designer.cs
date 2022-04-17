
namespace Lab_Work.Forms.ClientForms
{
    partial class ClientAccountsForm
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.BankAccountsListBox = new System.Windows.Forms.ListBox();
            this.CloseBankAccountButton = new System.Windows.Forms.Button();
            this.CreateBankAccountButton = new System.Windows.Forms.Button();
            this.ApplyForLoanButton = new System.Windows.Forms.Button();
            this.WithdrawTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.TransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(12, 135);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(101, 30);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Amount: ";
            // 
            // BankAccountsListBox
            // 
            this.BankAccountsListBox.FormattingEnabled = true;
            this.BankAccountsListBox.ItemHeight = 15;
            this.BankAccountsListBox.Location = new System.Drawing.Point(12, 26);
            this.BankAccountsListBox.Name = "BankAccountsListBox";
            this.BankAccountsListBox.Size = new System.Drawing.Size(246, 94);
            this.BankAccountsListBox.TabIndex = 7;
            this.BankAccountsListBox.SelectedIndexChanged += new System.EventHandler(this.BankAccountsListBox_SelectedIndexChanged);
            // 
            // CloseBankAccountButton
            // 
            this.CloseBankAccountButton.Location = new System.Drawing.Point(12, 268);
            this.CloseBankAccountButton.Name = "CloseBankAccountButton";
            this.CloseBankAccountButton.Size = new System.Drawing.Size(246, 50);
            this.CloseBankAccountButton.TabIndex = 6;
            this.CloseBankAccountButton.Text = "Close a bank account";
            this.CloseBankAccountButton.UseVisualStyleBackColor = true;
            this.CloseBankAccountButton.Click += new System.EventHandler(this.CloseBankAccountButton_Click);
            // 
            // CreateBankAccountButton
            // 
            this.CreateBankAccountButton.Location = new System.Drawing.Point(12, 212);
            this.CreateBankAccountButton.Name = "CreateBankAccountButton";
            this.CreateBankAccountButton.Size = new System.Drawing.Size(246, 50);
            this.CreateBankAccountButton.TabIndex = 5;
            this.CreateBankAccountButton.Text = "Open a bank account";
            this.CreateBankAccountButton.UseVisualStyleBackColor = true;
            this.CreateBankAccountButton.Click += new System.EventHandler(this.CreateBankAccountButton_Click);
            // 
            // ApplyForLoanButton
            // 
            this.ApplyForLoanButton.Location = new System.Drawing.Point(12, 324);
            this.ApplyForLoanButton.Name = "ApplyForLoanButton";
            this.ApplyForLoanButton.Size = new System.Drawing.Size(246, 50);
            this.ApplyForLoanButton.TabIndex = 9;
            this.ApplyForLoanButton.Text = "Apply for a loan";
            this.ApplyForLoanButton.UseVisualStyleBackColor = true;
            this.ApplyForLoanButton.Click += new System.EventHandler(this.ApplyForLoanButton_Click);
            // 
            // WithdrawTextBox
            // 
            this.WithdrawTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawTextBox.Location = new System.Drawing.Point(12, 403);
            this.WithdrawTextBox.Name = "WithdrawTextBox";
            this.WithdrawTextBox.PlaceholderText = "withdraw amount";
            this.WithdrawTextBox.Size = new System.Drawing.Size(246, 36);
            this.WithdrawTextBox.TabIndex = 11;
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(12, 445);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(246, 50);
            this.WithdrawButton.TabIndex = 10;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(12, 501);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(246, 50);
            this.TransferButton.TabIndex = 12;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // ClientAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 563);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.WithdrawTextBox);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.ApplyForLoanButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.BankAccountsListBox);
            this.Controls.Add(this.CloseBankAccountButton);
            this.Controls.Add(this.CreateBankAccountButton);
            this.Name = "ClientAccountsForm";
            this.Text = "ClientAccountsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label AmountLabel;
        public System.Windows.Forms.ListBox BankAccountsListBox;
        private System.Windows.Forms.Button CloseBankAccountButton;
        private System.Windows.Forms.Button CreateBankAccountButton;
        private System.Windows.Forms.Button ApplyForLoanButton;
        private System.Windows.Forms.TextBox WithdrawTextBox;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button TransferButton;
    }
}