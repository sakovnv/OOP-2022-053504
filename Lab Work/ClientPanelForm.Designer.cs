
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
            this.SuspendLayout();
            // 
            // CreateBankAccountButton
            // 
            this.CreateBankAccountButton.Location = new System.Drawing.Point(567, 259);
            this.CreateBankAccountButton.Name = "CreateBankAccountButton";
            this.CreateBankAccountButton.Size = new System.Drawing.Size(128, 50);
            this.CreateBankAccountButton.TabIndex = 0;
            this.CreateBankAccountButton.Text = "Open a bank account";
            this.CreateBankAccountButton.UseVisualStyleBackColor = true;
            this.CreateBankAccountButton.Click += new System.EventHandler(this.CreateBankAccountButton_Click);
            // 
            // CloseBankAccountButton
            // 
            this.CloseBankAccountButton.Location = new System.Drawing.Point(567, 315);
            this.CloseBankAccountButton.Name = "CloseBankAccountButton";
            this.CloseBankAccountButton.Size = new System.Drawing.Size(128, 50);
            this.CloseBankAccountButton.TabIndex = 1;
            this.CloseBankAccountButton.Text = "Close a bank account";
            this.CloseBankAccountButton.UseVisualStyleBackColor = true;
            this.CloseBankAccountButton.Click += new System.EventHandler(this.CloseBankAccountButton_Click);
            // 
            // ApplyForLoanButton
            // 
            this.ApplyForLoanButton.Location = new System.Drawing.Point(399, 259);
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
            this.BankAccountsListBox.Location = new System.Drawing.Point(456, 12);
            this.BankAccountsListBox.Name = "BankAccountsListBox";
            this.BankAccountsListBox.Size = new System.Drawing.Size(239, 94);
            this.BankAccountsListBox.TabIndex = 3;
            // 
            // ClientPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.BankAccountsListBox);
            this.Controls.Add(this.ApplyForLoanButton);
            this.Controls.Add(this.CloseBankAccountButton);
            this.Controls.Add(this.CreateBankAccountButton);
            this.Name = "ClientPanelForm";
            this.Text = "ClientPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBankAccountButton;
        private System.Windows.Forms.Button CloseBankAccountButton;
        private System.Windows.Forms.Button ApplyForLoanButton;
        public System.Windows.Forms.ListBox BankAccountsListBox;
    }
}