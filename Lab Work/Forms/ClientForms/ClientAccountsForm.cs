using Lab_Work.Data;
using Lab_Work.Entities;
using Lab_Work.Entities.UserStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Work.Forms.ClientForms
{
    public partial class ClientAccountsForm : Form
    {
        DbSet<User> usersDb = Database.GetUsers();
        DbSet<Bank> banksDb = Database.GetBanks();

        private BankAccount currentAccount = null;
        private Client currentClient;
        public ClientAccountsForm()
        {
            InitializeComponent();

            Bank bank = banksDb.Set.Find(item => item.Id == Logged.User.BankId);
            currentClient = bank.GetClient(Logged.User.ClientId);

            foreach (BankAccount account in currentClient.Accounts)
            {
                BankAccountsListBox.Items.Add(account.Id);
            }
        }

        private void CreateBankAccountButton_Click(object sender, EventArgs e)
        {
            BankAccount account = currentClient.CreateAccount();

            BankAccountsListBox.Items.Add(account.Id);

            usersDb.Save();
            banksDb.Save();
        }

        private void CloseBankAccountButton_Click(object sender, EventArgs e)
        {
            int id = (int)BankAccountsListBox.SelectedItem;
            BankAccountsListBox.Items.RemoveAt(BankAccountsListBox.SelectedIndex);

            currentClient.RemoveAccount(id);
        }

        private void BankAccountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BankAccountsListBox.SelectedIndex != -1)
            {
                currentAccount = currentClient.Accounts[BankAccountsListBox.SelectedIndex];
                decimal amount = currentAccount.GetAmount();
                AmountLabel.Text = $"Amount: {amount}$";
            }
        }
        private void ApplyForLoanButton_Click(object sender, EventArgs e)
        {
            if (BankAccountsListBox.SelectedIndex != -1)
            {
                ApplyForLoanForm form = new ApplyForLoanForm(this);
                form.Show();
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (BankAccountsListBox.SelectedIndex != -1)
            {
                TransferForm form = new TransferForm(this, currentAccount);
                form.Show();
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                decimal amount = currentAccount.Sub(Convert.ToInt32(WithdrawTextBox.Text));
                AmountLabel.Text = $"Amount: {amount}$";
            }
        }

        ~ClientAccountsForm()
        {
            banksDb.Save();
        }
    }
}
