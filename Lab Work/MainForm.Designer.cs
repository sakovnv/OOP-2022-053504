
using System.Collections;

namespace Lab_Work
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddClientButton = new System.Windows.Forms.Button();
            this.BanksListBox = new System.Windows.Forms.ListBox();
            this.AddBankButton = new System.Windows.Forms.Button();
            this.ClientsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddClientButton
            // 
            this.AddClientButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddClientButton.Location = new System.Drawing.Point(12, 343);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(101, 38);
            this.AddClientButton.TabIndex = 0;
            this.AddClientButton.Text = "Add client";
            this.AddClientButton.UseMnemonic = false;
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // BanksListBox
            // 
            this.BanksListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BanksListBox.FormattingEnabled = true;
            this.BanksListBox.ItemHeight = 21;
            this.BanksListBox.Location = new System.Drawing.Point(133, 12);
            this.BanksListBox.Name = "BanksListBox";
            this.BanksListBox.Size = new System.Drawing.Size(274, 193);
            this.BanksListBox.TabIndex = 1;
            this.BanksListBox.SelectedIndexChanged += new System.EventHandler(this.BanksListBox_SelectedIndexChanged);
            // 
            // AddBankButton
            // 
            this.AddBankButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBankButton.Location = new System.Drawing.Point(12, 68);
            this.AddBankButton.Name = "AddBankButton";
            this.AddBankButton.Size = new System.Drawing.Size(101, 38);
            this.AddBankButton.TabIndex = 2;
            this.AddBankButton.Text = "Add bank";
            this.AddBankButton.UseMnemonic = false;
            this.AddBankButton.UseVisualStyleBackColor = true;
            this.AddBankButton.Click += new System.EventHandler(this.AddBankButton_Click);
            // 
            // ClientsListBox
            // 
            this.ClientsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientsListBox.FormattingEnabled = true;
            this.ClientsListBox.ItemHeight = 21;
            this.ClientsListBox.Location = new System.Drawing.Point(133, 287);
            this.ClientsListBox.Name = "ClientsListBox";
            this.ClientsListBox.Size = new System.Drawing.Size(274, 193);
            this.ClientsListBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 602);
            this.Controls.Add(this.ClientsListBox);
            this.Controls.Add(this.AddBankButton);
            this.Controls.Add(this.BanksListBox);
            this.Controls.Add(this.AddClientButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClientButton;
        public System.Windows.Forms.ListBox BanksListBox;
        private System.Windows.Forms.Button AddBankButton;
        public System.Windows.Forms.ListBox ClientsListBox;
    }
}

