
namespace Lab_Work
{
    partial class AddBankForm
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
            this.AddBankButton = new System.Windows.Forms.Button();
            this.CancelAddingButton = new System.Windows.Forms.Button();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.BankNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBankButton
            // 
            this.AddBankButton.Location = new System.Drawing.Point(12, 97);
            this.AddBankButton.Name = "AddBankButton";
            this.AddBankButton.Size = new System.Drawing.Size(211, 49);
            this.AddBankButton.TabIndex = 15;
            this.AddBankButton.Text = "Add";
            this.AddBankButton.UseVisualStyleBackColor = true;
            this.AddBankButton.Click += new System.EventHandler(this.AddBankButton_Click);
            // 
            // CancelAddingButton
            // 
            this.CancelAddingButton.Location = new System.Drawing.Point(229, 97);
            this.CancelAddingButton.Name = "CancelAddingButton";
            this.CancelAddingButton.Size = new System.Drawing.Size(207, 49);
            this.CancelAddingButton.TabIndex = 14;
            this.CancelAddingButton.Text = "Cancel";
            this.CancelAddingButton.UseVisualStyleBackColor = true;
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankNameLabel.Location = new System.Drawing.Point(191, 16);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(71, 30);
            this.BankNameLabel.TabIndex = 13;
            this.BankNameLabel.Text = "Name";
            // 
            // BankNameTextBox
            // 
            this.BankNameTextBox.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankNameTextBox.Location = new System.Drawing.Point(12, 49);
            this.BankNameTextBox.Name = "BankNameTextBox";
            this.BankNameTextBox.Size = new System.Drawing.Size(424, 32);
            this.BankNameTextBox.TabIndex = 12;
            // 
            // AddBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 158);
            this.Controls.Add(this.AddBankButton);
            this.Controls.Add(this.CancelAddingButton);
            this.Controls.Add(this.BankNameLabel);
            this.Controls.Add(this.BankNameTextBox);
            this.Name = "AddBankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBankForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBankButton;
        private System.Windows.Forms.Button CancelAddingButton;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.TextBox BankNameTextBox;
    }
}