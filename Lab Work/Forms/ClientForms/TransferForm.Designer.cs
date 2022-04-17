
namespace Lab_Work.Forms.ClientForms
{
    partial class TransferForm
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
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.BankAccountTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTextBox.Location = new System.Drawing.Point(12, 84);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PlaceholderText = "Amount";
            this.AmountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AmountTextBox.Size = new System.Drawing.Size(279, 36);
            this.AmountTextBox.TabIndex = 10;
            // 
            // BankAccountTextBox
            // 
            this.BankAccountTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BankAccountTextBox.Location = new System.Drawing.Point(12, 28);
            this.BankAccountTextBox.Name = "BankAccountTextBox";
            this.BankAccountTextBox.PlaceholderText = "Client\'s bank account";
            this.BankAccountTextBox.Size = new System.Drawing.Size(279, 36);
            this.BankAccountTextBox.TabIndex = 9;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 140);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(279, 56);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 205);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.BankAccountTextBox);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox BankAccountTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}