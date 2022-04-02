using Lab_Work.Entities;
using Lab_Work.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Lab_Work.Library;

namespace Lab_Work
{
    public partial class ClientPanelForm : Form
    {
        public ClientPanelForm()
        {
            InitializeComponent();
        }

        private void CreateBankAccountButton_Click(object sender, EventArgs e)
        {
            BankAccount account = Logged.User.Client.CreateAccount();

            BankAccountsListBox.Items.Add(account.Id);

        }

        private void CloseBankAccountButton_Click(object sender, EventArgs e)
        {
            int id = (int)BankAccountsListBox.SelectedItem;
            BankAccountsListBox.Items.RemoveAt(BankAccountsListBox.SelectedIndex);

            Logged.User.Client.RemoveAccount(id);
        }

        private void ApplyForLoanButton_Click(object sender, EventArgs e)
        {
            if (BankAccountsListBox.SelectedIndex != -1)
            {
                ApplyForLoanForm form = new ApplyForLoanForm(this);
                form.Show();
            }
        }
    }
}
