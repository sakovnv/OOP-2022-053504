
namespace Lab_Work
{
    partial class AdminPanelForm
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
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.IsApprovedLabel = new System.Windows.Forms.Label();
            this.UsersListLabel = new System.Windows.Forms.Label();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.PassportSeriesLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.LoansListBox = new System.Windows.Forms.ListBox();
            this.LoansListLabel = new System.Windows.Forms.Label();
            this.LoanIdLabel = new System.Windows.Forms.Label();
            this.LoanAmountLabel = new System.Windows.Forms.Label();
            this.LoanTermLabel = new System.Windows.Forms.Label();
            this.LoanPercentLabel = new System.Windows.Forms.Label();
            this.LoanCreateTimeLabel = new System.Windows.Forms.Label();
            this.LoanEndTimeLabel = new System.Windows.Forms.Label();
            this.LoanIsApprovedLabel = new System.Windows.Forms.Label();
            this.LoanIsApprovedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.ItemHeight = 15;
            this.UsersListBox.Location = new System.Drawing.Point(12, 44);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(210, 139);
            this.UsersListBox.TabIndex = 0;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(228, 10);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(45, 30);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID: ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(228, 40);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(77, 30);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login: ";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(228, 70);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(75, 30);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email: ";
            // 
            // IsApprovedLabel
            // 
            this.IsApprovedLabel.AutoSize = true;
            this.IsApprovedLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsApprovedLabel.Location = new System.Drawing.Point(228, 100);
            this.IsApprovedLabel.Name = "IsApprovedLabel";
            this.IsApprovedLabel.Size = new System.Drawing.Size(139, 30);
            this.IsApprovedLabel.TabIndex = 4;
            this.IsApprovedLabel.Text = "Is approved: ";
            // 
            // UsersListLabel
            // 
            this.UsersListLabel.AutoSize = true;
            this.UsersListLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersListLabel.Location = new System.Drawing.Point(71, 16);
            this.UsersListLabel.Name = "UsersListLabel";
            this.UsersListLabel.Size = new System.Drawing.Size(87, 25);
            this.UsersListLabel.TabIndex = 5;
            this.UsersListLabel.Text = "Users list";
            // 
            // ApproveButton
            // 
            this.ApproveButton.Location = new System.Drawing.Point(440, 107);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(75, 23);
            this.ApproveButton.TabIndex = 6;
            this.ApproveButton.Text = "Approve";
            this.ApproveButton.UseVisualStyleBackColor = true;
            this.ApproveButton.Visible = false;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // PassportSeriesLabel
            // 
            this.PassportSeriesLabel.AutoSize = true;
            this.PassportSeriesLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportSeriesLabel.Location = new System.Drawing.Point(228, 160);
            this.PassportSeriesLabel.Name = "PassportSeriesLabel";
            this.PassportSeriesLabel.Size = new System.Drawing.Size(155, 30);
            this.PassportSeriesLabel.TabIndex = 7;
            this.PassportSeriesLabel.Text = "Passport series";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FullNameLabel.Location = new System.Drawing.Point(228, 130);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(117, 30);
            this.FullNameLabel.TabIndex = 8;
            this.FullNameLabel.Text = "Full name: ";
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassportNumberLabel.Location = new System.Drawing.Point(228, 190);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(182, 30);
            this.PassportNumberLabel.TabIndex = 9;
            this.PassportNumberLabel.Text = "Passport number ";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(228, 220);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(167, 30);
            this.PhoneNumberLabel.TabIndex = 10;
            this.PhoneNumberLabel.Text = "Phone number: ";
            // 
            // LoansListBox
            // 
            this.LoansListBox.FormattingEnabled = true;
            this.LoansListBox.ItemHeight = 15;
            this.LoansListBox.Location = new System.Drawing.Point(12, 299);
            this.LoansListBox.Name = "LoansListBox";
            this.LoansListBox.Size = new System.Drawing.Size(210, 139);
            this.LoansListBox.TabIndex = 11;
            this.LoansListBox.SelectedIndexChanged += new System.EventHandler(this.LoansListBox_SelectedIndexChanged);
            // 
            // LoansListLabel
            // 
            this.LoansListLabel.AutoSize = true;
            this.LoansListLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoansListLabel.Location = new System.Drawing.Point(71, 271);
            this.LoansListLabel.Name = "LoansListLabel";
            this.LoansListLabel.Size = new System.Drawing.Size(90, 25);
            this.LoansListLabel.TabIndex = 12;
            this.LoansListLabel.Text = "Loans list";
            // 
            // LoanIdLabel
            // 
            this.LoanIdLabel.AutoSize = true;
            this.LoanIdLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanIdLabel.Location = new System.Drawing.Point(228, 266);
            this.LoanIdLabel.Name = "LoanIdLabel";
            this.LoanIdLabel.Size = new System.Drawing.Size(45, 30);
            this.LoanIdLabel.TabIndex = 13;
            this.LoanIdLabel.Text = "ID: ";
            // 
            // LoanAmountLabel
            // 
            this.LoanAmountLabel.AutoSize = true;
            this.LoanAmountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanAmountLabel.Location = new System.Drawing.Point(228, 296);
            this.LoanAmountLabel.Name = "LoanAmountLabel";
            this.LoanAmountLabel.Size = new System.Drawing.Size(101, 30);
            this.LoanAmountLabel.TabIndex = 14;
            this.LoanAmountLabel.Text = "Amount: ";
            // 
            // LoanTermLabel
            // 
            this.LoanTermLabel.AutoSize = true;
            this.LoanTermLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanTermLabel.Location = new System.Drawing.Point(228, 326);
            this.LoanTermLabel.Name = "LoanTermLabel";
            this.LoanTermLabel.Size = new System.Drawing.Size(73, 30);
            this.LoanTermLabel.TabIndex = 15;
            this.LoanTermLabel.Text = "Term: ";
            // 
            // LoanPercentLabel
            // 
            this.LoanPercentLabel.AutoSize = true;
            this.LoanPercentLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanPercentLabel.Location = new System.Drawing.Point(228, 356);
            this.LoanPercentLabel.Name = "LoanPercentLabel";
            this.LoanPercentLabel.Size = new System.Drawing.Size(96, 30);
            this.LoanPercentLabel.TabIndex = 16;
            this.LoanPercentLabel.Text = "Percent: ";
            // 
            // LoanCreateTimeLabel
            // 
            this.LoanCreateTimeLabel.AutoSize = true;
            this.LoanCreateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanCreateTimeLabel.Location = new System.Drawing.Point(228, 386);
            this.LoanCreateTimeLabel.Name = "LoanCreateTimeLabel";
            this.LoanCreateTimeLabel.Size = new System.Drawing.Size(137, 30);
            this.LoanCreateTimeLabel.TabIndex = 17;
            this.LoanCreateTimeLabel.Text = "Create time: ";
            // 
            // LoanEndTimeLabel
            // 
            this.LoanEndTimeLabel.AutoSize = true;
            this.LoanEndTimeLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanEndTimeLabel.Location = new System.Drawing.Point(228, 416);
            this.LoanEndTimeLabel.Name = "LoanEndTimeLabel";
            this.LoanEndTimeLabel.Size = new System.Drawing.Size(109, 30);
            this.LoanEndTimeLabel.TabIndex = 18;
            this.LoanEndTimeLabel.Text = "End time: ";
            // 
            // LoanIsApprovedLabel
            // 
            this.LoanIsApprovedLabel.AutoSize = true;
            this.LoanIsApprovedLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoanIsApprovedLabel.Location = new System.Drawing.Point(228, 446);
            this.LoanIsApprovedLabel.Name = "LoanIsApprovedLabel";
            this.LoanIsApprovedLabel.Size = new System.Drawing.Size(139, 30);
            this.LoanIsApprovedLabel.TabIndex = 19;
            this.LoanIsApprovedLabel.Text = "Is approved: ";
            // 
            // LoanIsApprovedButton
            // 
            this.LoanIsApprovedButton.Location = new System.Drawing.Point(440, 453);
            this.LoanIsApprovedButton.Name = "LoanIsApprovedButton";
            this.LoanIsApprovedButton.Size = new System.Drawing.Size(75, 23);
            this.LoanIsApprovedButton.TabIndex = 20;
            this.LoanIsApprovedButton.Text = "Approve";
            this.LoanIsApprovedButton.UseVisualStyleBackColor = true;
            this.LoanIsApprovedButton.Visible = false;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.LoanIsApprovedButton);
            this.Controls.Add(this.LoanIsApprovedLabel);
            this.Controls.Add(this.LoanEndTimeLabel);
            this.Controls.Add(this.LoanCreateTimeLabel);
            this.Controls.Add(this.LoanPercentLabel);
            this.Controls.Add(this.LoanTermLabel);
            this.Controls.Add(this.LoanAmountLabel);
            this.Controls.Add(this.LoanIdLabel);
            this.Controls.Add(this.LoansListLabel);
            this.Controls.Add(this.LoansListBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PassportNumberLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PassportSeriesLabel);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.UsersListLabel);
            this.Controls.Add(this.IsApprovedLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.UsersListBox);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label IsApprovedLabel;
        private System.Windows.Forms.Label UsersListLabel;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Label PassportSeriesLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.ListBox LoansListBox;
        private System.Windows.Forms.Label LoansListLabel;
        private System.Windows.Forms.Label LoanIdLabel;
        private System.Windows.Forms.Label LoanAmountLabel;
        private System.Windows.Forms.Label LoanTermLabel;
        private System.Windows.Forms.Label LoanPercentLabel;
        private System.Windows.Forms.Label LoanCreateTimeLabel;
        private System.Windows.Forms.Label LoanEndTimeLabel;
        private System.Windows.Forms.Label LoanIsApprovedLabel;
        private System.Windows.Forms.Button LoanIsApprovedButton;
    }
}