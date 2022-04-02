
namespace Lab_Work
{
    partial class ApplyForLoanForm
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
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.TermComboBox = new System.Windows.Forms.ComboBox();
            this.PurposeOfLoanTextBox = new System.Windows.Forms.TextBox();
            this.IndividualPercentTextBox = new System.Windows.Forms.TextBox();
            this.ChoosePercentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TermNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TermNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountNumberLabel.Location = new System.Drawing.Point(12, 34);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(118, 19);
            this.AccountNumberLabel.TabIndex = 0;
            this.AccountNumberLabel.Text = "Bank account №: ";
            // 
            // TermComboBox
            // 
            this.TermComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TermComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermComboBox.FormattingEnabled = true;
            this.TermComboBox.Items.AddRange(new object[] {
            "3 month",
            "6 month",
            "12 month",
            "24 month",
            "more than 24 month"});
            this.TermComboBox.Location = new System.Drawing.Point(12, 79);
            this.TermComboBox.Name = "TermComboBox";
            this.TermComboBox.Size = new System.Drawing.Size(158, 33);
            this.TermComboBox.TabIndex = 15;
            this.TermComboBox.SelectedIndexChanged += new System.EventHandler(this.TermComboBox_SelectedIndexChanged);
            // 
            // PurposeOfLoanTextBox
            // 
            this.PurposeOfLoanTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PurposeOfLoanTextBox.Location = new System.Drawing.Point(12, 140);
            this.PurposeOfLoanTextBox.Name = "PurposeOfLoanTextBox";
            this.PurposeOfLoanTextBox.PlaceholderText = "Purpose of the loan";
            this.PurposeOfLoanTextBox.Size = new System.Drawing.Size(351, 34);
            this.PurposeOfLoanTextBox.TabIndex = 16;
            // 
            // IndividualPercentTextBox
            // 
            this.IndividualPercentTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IndividualPercentTextBox.Location = new System.Drawing.Point(12, 290);
            this.IndividualPercentTextBox.Name = "IndividualPercentTextBox";
            this.IndividualPercentTextBox.PlaceholderText = "Percent";
            this.IndividualPercentTextBox.Size = new System.Drawing.Size(351, 34);
            this.IndividualPercentTextBox.TabIndex = 17;
            this.IndividualPercentTextBox.Visible = false;
            // 
            // ChoosePercentTypeComboBox
            // 
            this.ChoosePercentTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePercentTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoosePercentTypeComboBox.FormattingEnabled = true;
            this.ChoosePercentTypeComboBox.Items.AddRange(new object[] {
            "0",
            "individual",
            "5",
            "10",
            "15"});
            this.ChoosePercentTypeComboBox.Location = new System.Drawing.Point(205, 79);
            this.ChoosePercentTypeComboBox.Name = "ChoosePercentTypeComboBox";
            this.ChoosePercentTypeComboBox.Size = new System.Drawing.Size(158, 33);
            this.ChoosePercentTypeComboBox.TabIndex = 20;
            this.ChoosePercentTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ChoosePercentTypeComboBox_SelectedIndexChanged);
            // 
            // TermNumericUpDown
            // 
            this.TermNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TermNumericUpDown.Location = new System.Drawing.Point(12, 240);
            this.TermNumericUpDown.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.TermNumericUpDown.Name = "TermNumericUpDown";
            this.TermNumericUpDown.Size = new System.Drawing.Size(351, 34);
            this.TermNumericUpDown.TabIndex = 21;
            this.TermNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.TermNumericUpDown.Visible = false;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(12, 360);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(351, 86);
            this.ApplyButton.TabIndex = 22;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTextBox.Location = new System.Drawing.Point(12, 190);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.PlaceholderText = "Amount";
            this.AmountTextBox.Size = new System.Drawing.Size(351, 34);
            this.AmountTextBox.TabIndex = 23;
            // 
            // ApplyForLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 472);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.TermNumericUpDown);
            this.Controls.Add(this.ChoosePercentTypeComboBox);
            this.Controls.Add(this.IndividualPercentTextBox);
            this.Controls.Add(this.PurposeOfLoanTextBox);
            this.Controls.Add(this.TermComboBox);
            this.Controls.Add(this.AccountNumberLabel);
            this.Name = "ApplyForLoanForm";
            this.Text = "ApplyForLoanForm";
            ((System.ComponentModel.ISupportInitialize)(this.TermNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.ComboBox TermComboBox;
        private System.Windows.Forms.TextBox PurposeOfLoanTextBox;
        private System.Windows.Forms.TextBox IndividualPercentTextBox;
        private System.Windows.Forms.ComboBox ChoosePercentTypeComboBox;
        private System.Windows.Forms.NumericUpDown TermNumericUpDown;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}