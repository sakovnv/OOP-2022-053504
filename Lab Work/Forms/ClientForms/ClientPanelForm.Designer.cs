
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
            this.CreateDepositButton = new System.Windows.Forms.Button();
            this.WithdrawDepositButton = new System.Windows.Forms.Button();
            this.TransferDepositButton = new System.Windows.Forms.Button();
            this.FreezeDepositButton = new System.Windows.Forms.Button();
            this.DepositPercentTextBox = new System.Windows.Forms.TextBox();
            this.DepositAmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositTermTextBox = new System.Windows.Forms.TextBox();
            this.DepositListBox = new System.Windows.Forms.ListBox();
            this.DepositAmountLabel = new System.Windows.Forms.Label();
            this.AccountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateDepositButton
            // 
            this.CreateDepositButton.Location = new System.Drawing.Point(261, 136);
            this.CreateDepositButton.Name = "CreateDepositButton";
            this.CreateDepositButton.Size = new System.Drawing.Size(128, 50);
            this.CreateDepositButton.TabIndex = 10;
            this.CreateDepositButton.Text = "Create deposit";
            this.CreateDepositButton.UseVisualStyleBackColor = true;
            this.CreateDepositButton.Click += new System.EventHandler(this.CreateDepositButton_Click);
            // 
            // WithdrawDepositButton
            // 
            this.WithdrawDepositButton.Location = new System.Drawing.Point(12, 118);
            this.WithdrawDepositButton.Name = "WithdrawDepositButton";
            this.WithdrawDepositButton.Size = new System.Drawing.Size(128, 50);
            this.WithdrawDepositButton.TabIndex = 11;
            this.WithdrawDepositButton.Text = "Withdraw deposit";
            this.WithdrawDepositButton.UseVisualStyleBackColor = true;
            this.WithdrawDepositButton.Click += new System.EventHandler(this.WithdrawDepositButton_Click);
            // 
            // TransferDepositButton
            // 
            this.TransferDepositButton.Location = new System.Drawing.Point(12, 230);
            this.TransferDepositButton.Name = "TransferDepositButton";
            this.TransferDepositButton.Size = new System.Drawing.Size(128, 50);
            this.TransferDepositButton.TabIndex = 12;
            this.TransferDepositButton.Text = "Transfer deposit";
            this.TransferDepositButton.UseVisualStyleBackColor = true;
            this.TransferDepositButton.Click += new System.EventHandler(this.TransferDepositButton_Click);
            // 
            // FreezeDepositButton
            // 
            this.FreezeDepositButton.Location = new System.Drawing.Point(12, 174);
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
            this.DepositPercentTextBox.Location = new System.Drawing.Point(245, 55);
            this.DepositPercentTextBox.Name = "DepositPercentTextBox";
            this.DepositPercentTextBox.PlaceholderText = "Percent";
            this.DepositPercentTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositPercentTextBox.TabIndex = 14;
            // 
            // DepositAmountTextBox
            // 
            this.DepositAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositAmountTextBox.Location = new System.Drawing.Point(245, 11);
            this.DepositAmountTextBox.Name = "DepositAmountTextBox";
            this.DepositAmountTextBox.PlaceholderText = "Amount";
            this.DepositAmountTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositAmountTextBox.TabIndex = 15;
            // 
            // DepositTermTextBox
            // 
            this.DepositTermTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositTermTextBox.Location = new System.Drawing.Point(245, 99);
            this.DepositTermTextBox.Name = "DepositTermTextBox";
            this.DepositTermTextBox.PlaceholderText = "Term (in month)";
            this.DepositTermTextBox.Size = new System.Drawing.Size(171, 31);
            this.DepositTermTextBox.TabIndex = 16;
            // 
            // DepositListBox
            // 
            this.DepositListBox.FormattingEnabled = true;
            this.DepositListBox.ItemHeight = 15;
            this.DepositListBox.Location = new System.Drawing.Point(12, 12);
            this.DepositListBox.Name = "DepositListBox";
            this.DepositListBox.Size = new System.Drawing.Size(151, 64);
            this.DepositListBox.TabIndex = 17;
            this.DepositListBox.SelectedIndexChanged += new System.EventHandler(this.DepositListBox_SelectedIndexChanged);
            // 
            // DepositAmountLabel
            // 
            this.DepositAmountLabel.AutoSize = true;
            this.DepositAmountLabel.Location = new System.Drawing.Point(12, 79);
            this.DepositAmountLabel.Name = "DepositAmountLabel";
            this.DepositAmountLabel.Size = new System.Drawing.Size(57, 15);
            this.DepositAmountLabel.TabIndex = 18;
            this.DepositAmountLabel.Text = "Amount: ";
            // 
            // AccountsButton
            // 
            this.AccountsButton.Location = new System.Drawing.Point(261, 230);
            this.AccountsButton.Name = "AccountsButton";
            this.AccountsButton.Size = new System.Drawing.Size(128, 46);
            this.AccountsButton.TabIndex = 19;
            this.AccountsButton.Text = "Accounts";
            this.AccountsButton.UseVisualStyleBackColor = true;
            this.AccountsButton.Click += new System.EventHandler(this.AccountsButton_Click);
            // 
            // ClientPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 288);
            this.Controls.Add(this.AccountsButton);
            this.Controls.Add(this.DepositAmountLabel);
            this.Controls.Add(this.DepositListBox);
            this.Controls.Add(this.DepositTermTextBox);
            this.Controls.Add(this.DepositAmountTextBox);
            this.Controls.Add(this.DepositPercentTextBox);
            this.Controls.Add(this.FreezeDepositButton);
            this.Controls.Add(this.TransferDepositButton);
            this.Controls.Add(this.WithdrawDepositButton);
            this.Controls.Add(this.CreateDepositButton);
            this.Name = "ClientPanelForm";
            this.Text = "ClientPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateDepositButton;
        private System.Windows.Forms.Button WithdrawDepositButton;
        private System.Windows.Forms.Button TransferDepositButton;
        private System.Windows.Forms.Button FreezeDepositButton;
        private System.Windows.Forms.TextBox DepositPercentTextBox;
        private System.Windows.Forms.TextBox DepositAmountTextBox;
        private System.Windows.Forms.TextBox DepositTermTextBox;
        public System.Windows.Forms.ListBox DepositListBox;
        private System.Windows.Forms.Label DepositAmountLabel;
        private System.Windows.Forms.Button AccountsButton;
    }
}