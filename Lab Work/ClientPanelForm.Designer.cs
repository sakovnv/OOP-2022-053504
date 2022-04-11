
namespace Lab_Work
{
    partial class ClientPanelForm
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
            this.CreateBankAccountButton = new System.Windows.Forms.Button();
            this.CloseBankAccountButton = new System.Windows.Forms.Button();
            this.ApplyForLoanButton = new System.Windows.Forms.Button();
            this.BankAccountsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.WithdrawTextBox = new System.Windows.Forms.TextBox();
            this.BankAccountTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.CreateDepositButton = new System.Windows.Forms.Button();
            this.WithdrawDepositButton = new System.Windows.Forms.Button();
            this.TransferDepositButton = new System.Windows.Forms.Button();
            this.FreezeDepositButton = new System.Windows.Forms.Button();
            this.DepositPercentTextBox = new System.Windows.Forms.TextBox();
            this.DepositAmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositTermTextBox = new System.Windows.Forms.TextBox();
            this.DepositListBox = new System.Windows.Forms.ListBox();
            this.DepositAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateBankAccountButton
            // 
            this.CreateBankAccountButton.Location = new System.Drawing.Point(12, 259);
            this.CreateBankAccountButton.Name = "CreateBankAccountButton";
            this.CreateBankAccountButton.Size = new System.Drawing.Size(128, 50);
            this.CreateBankAccountButton.TabIndex = 0;
            this.CreateBankAccountButton.Text = "Open a bank account";
            this.CreateBankAccountButton.UseVisualStyleBackColor = true;
            this.CreateBankAccountButton.Click += new System.EventHandler(this.CreateBankAccountButton_Click);
            // 
            // CloseBankAccountButton
            // 
            this.CloseBankAccountButton.Location = new System.Drawing.Point(12, 315);
            this.CloseBankAccountButton.Name = "CloseBankAccountButton";
            this.CloseBankAccountButton.Size = new System.Drawing.Size(128, 50);
            this.CloseBankAccountButton.TabIndex = 1;
            this.CloseBankAccountButton.Text = "Close a bank account";
            this.CloseBankAccountButton.UseVisualStyleBackColor = true;
            this.CloseBankAccountButton.Click += new System.EventHandler(this.CloseBankAccountButton_Click);
            // 
            // ApplyForLoanButton
            // 
            this.ApplyForLoanButton.Location = new System.Drawing.Point(12, 175);
            this.ApplyForLoanButton.Name = "ApplyForLoanButton";
            this.ApplyForLoanButton.Size = new System.Drawing.Size(128, 50);
            this.ApplyForLoanButton.TabIndex = 2;
            this.ApplyForLoanButton.Text = "Apply for a loan";
            this.ApplyForLoanButton.UseVisualStyleBackColor = true;
            this.ApplyForLoanButton.Click += new System.EventHandler(this.ApplyForLoanButton_Click);
            // 
            // BankAccountsListBox
            // 
            this.BankAccountsListBox.FormattingEnabled = true;
            this.BankAccountsListBox.ItemHeight = 15;
            this.BankAccountsListBox.Location = new System.Drawing.Point(12, 12);
            this.BankAccountsListBox.Name = "BankAccountsListBox";
            this.BankAccountsListBox.Size = new System.Drawing.Size(151, 94);
            this.BankAccountsListBox.TabIndex = 3;
            this.BankAccountsListBox.SelectedIndexChanged += new System.EventHandler(this.BankAccountsListBox_SelectedIndexChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(12, 109);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(57, 15);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount: ";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(234, 315);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(128, 50);
            this.WithdrawButton.TabIndex = 5;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // WithdrawTextBox
            // 
            this.WithdrawTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WithdrawTextBox.Location = new System.Drawing.Point(207, 273);
            this.WithdrawTextBox.Name = "WithdrawTextBox";
            this.WithdrawTextBox.PlaceholderText = "withdraw amount";
            this.WithdrawTextBox.Size = new System.Drawing.Size(182, 36);
            this.WithdrawTextBox.TabIndex = 6;
            // 
            // BankAccountTextBox
            // 
            this.BankAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankAccountTextBox.Location = new System.Drawing.Point(496, 217);
            this.BankAccountTextBox.Name = "BankAccountTextBox";
            this.BankAccountTextBox.PlaceholderText = "Client\'s bank account";
            this.BankAccountTextBox.Size = new System.Drawing.Size(182, 36);
            this.BankAccountTextBox.TabIndex = 7;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTextBox.Location = new System.Drawing.Point(496, 273);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PlaceholderText = "Amount";
            this.AmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AmountTextBox.Size = new System.Drawing.Size(182, 36);
            this.AmountTextBox.TabIndex = 8;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(567, 315);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(128, 50);
            this.TransferButton.TabIndex = 9;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // CreateDepositButton
            // 
            this.CreateDepositButton.Location = new System.Drawing.Point(540, 137);
            this.CreateDepositButton.Name = "CreateDepositButton";
            this.CreateDepositButton.Size = new System.Drawing.Size(128, 50);
            this.CreateDepositButton.TabIndex = 10;
            this.CreateDepositButton.Text = "Create deposit";
            this.CreateDepositButton.UseVisualStyleBackColor = true;
            this.CreateDepositButton.Click += new System.EventHandler(this.CreateDepositButton_Click);
            // 
            // WithdrawDepositButton
            // 
            this.WithdrawDepositButton.Location = new System.Drawing.Point(261, 137);
            this.WithdrawDepositButton.Name = "WithdrawDepositButton";
            this.WithdrawDepositButton.Size = new System.Drawing.Size(128, 50);
            this.WithdrawDepositButton.TabIndex = 11;
            this.WithdrawDepositButton.Text = "Withdraw deposit";
            this.WithdrawDepositButton.UseVisualStyleBackColor = true;
            this.WithdrawDepositButton.Click += new System.EventHandler(this.WithdrawDepositButton_Click);
            // 
            // TransferDepositButton
            // 
            this.TransferDepositButton.Location = new System.Drawing.Point(433, 315);
            this.TransferDepositButton.Name = "TransferDepositButton";
            this.TransferDepositButton.Size = new System.Drawing.Size(128, 50);
            this.TransferDepositButton.TabIndex = 12;
            this.TransferDepositButton.Text = "Transfer deposit";
            this.TransferDepositButton.UseVisualStyleBackColor = true;
            this.TransferDepositButton.Click += new System.EventHandler(this.TransferDepositButton_Click);
            // 
            // FreezeDepositButton
            // 
            this.FreezeDepositButton.Location = new System.Drawing.Point(395, 137);
            this.FreezeDepositButton.Name = "FreezeDepositButton";
            this.FreezeDepositButton.Size = new System.Drawing.Size(128, 50);
            this.FreezeDepositButton.TabIndex = 13;
            this.FreezeDepositButton.Text = "Freeze deposit";
            this.FreezeDepositButton.UseVisualStyleBackColor = true;
            this.FreezeDepositButton.Click += new System.EventHandler(this.FreezeDepositButton_Click);
            // 
            // DepositPercentTextBox
            // 
            this.DepositPercentTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositPercentTextBox.Location = new System.Drawing.Point(524, 56);
            this.DepositPercentTextBox.Name = "DepositPercentTextBox";
            this.DepositPercentTextBox.PlaceholderText = "Percent";
            this.DepositPercentTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositPercentTextBox.TabIndex = 14;
            // 
            // DepositAmountTextBox
            // 
            this.DepositAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositAmountTextBox.Location = new System.Drawing.Point(524, 12);
            this.DepositAmountTextBox.Name = "DepositAmountTextBox";
            this.DepositAmountTextBox.PlaceholderText = "Amount";
            this.DepositAmountTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositAmountTextBox.TabIndex = 15;
            // 
            // DepositTermTextBox
            // 
            this.DepositTermTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositTermTextBox.Location = new System.Drawing.Point(524, 100);
            this.DepositTermTextBox.Name = "DepositTermTextBox";
            this.DepositTermTextBox.PlaceholderText = "Term (in month)";
            this.DepositTermTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositTermTextBox.TabIndex = 16;
            // 
            // DepositListBox
            // 
            this.DepositListBox.FormattingEnabled = true;
            this.DepositListBox.ItemHeight = 15;
            this.DepositListBox.Location = new System.Drawing.Point(251, 12);
            this.DepositListBox.Name = "DepositListBox";
            this.DepositListBox.Size = new System.Drawing.Size(151, 64);
            this.DepositListBox.TabIndex = 17;
            this.DepositListBox.SelectedIndexChanged += new System.EventHandler(this.DepositListBox_SelectedIndexChanged);
            // 
            // DepositAmountLabel
            // 
            this.DepositAmountLabel.AutoSize = true;
            this.DepositAmountLabel.Location = new System.Drawing.Point(251, 79);
            this.DepositAmountLabel.Name = "DepositAmountLabel";
            this.DepositAmountLabel.Size = new System.Drawing.Size(57, 15);
            this.DepositAmountLabel.TabIndex = 18;
            this.DepositAmountLabel.Text = "Amount: ";
            // 
            // ClientPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.DepositAmountLabel);
            this.Controls.Add(this.DepositListBox);
            this.Controls.Add(this.DepositTermTextBox);
            this.Controls.Add(this.DepositAmountTextBox);
            this.Controls.Add(this.DepositPercentTextBox);
            this.Controls.Add(this.FreezeDepositButton);
            this.Controls.Add(this.TransferDepositButton);
            this.Controls.Add(this.WithdrawDepositButton);
            this.Controls.Add(this.CreateDepositButton);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.BankAccountTextBox);
            this.Controls.Add(this.WithdrawTextBox);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.BankAccountsListBox);
            this.Controls.Add(this.ApplyForLoanButton);
            this.Controls.Add(this.CloseBankAccountButton);
            this.Controls.Add(this.CreateBankAccountButton);
            this.Name = "ClientPanelForm";
            this.Text = "ClientPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateBankAccountButton;
        private System.Windows.Forms.Button CloseBankAccountButton;
        private System.Windows.Forms.Button ApplyForLoanButton;
        public System.Windows.Forms.ListBox BankAccountsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.TextBox WithdrawTextBox;
        private System.Windows.Forms.TextBox BankAccountTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.Button CreateDepositButton;
        private System.Windows.Forms.Button WithdrawDepositButton;
        private System.Windows.Forms.Button TransferDepositButton;
        private System.Windows.Forms.Button FreezeDepositButton;
        private System.Windows.Forms.TextBox DepositPercentTextBox;
        private System.Windows.Forms.TextBox DepositAmountTextBox;
        private System.Windows.Forms.TextBox DepositTermTextBox;
        public System.Windows.Forms.ListBox DepositListBox;
        private System.Windows.Forms.Label DepositAmountLabel;
    }
}