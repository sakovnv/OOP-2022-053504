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
using System.Security.Cryptography;
using Lab_Work.Library;
using Lab_Work.Data;

namespace Lab_Work
{
    public partial class ClientPanelForm : Form
    {
        private DbSet<Bank> banksDb;
        private DbSet<User> usersDb;
        private BankAccount currentAccount = null;
        public ClientPanelForm()
        {
            InitializeComponent();

            banksDb = Database.GetBanks();
            usersDb = Database.GetUsers();

            foreach(BankAccount account in Logged.User.Client.Accounts)
            {
                BankAccountsListBox.Items.Add(account.Id);
            }

            foreach(Deposit deposit in Logged.User.Client.Deposits)
            {
                DepositListBox.Items.Add(deposit.Id);
            }
        }

        private void CreateBankAccountButton_Click(object sender, EventArgs e)
        {
            BankAccount account = Logged.User.Client.CreateAccount();

            BankAccountsListBox.Items.Add(account.Id);

            usersDb.Save();
            banksDb.Save();
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

        private void BankAccountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BankAccountsListBox.SelectedIndex != -1)
            { 
                currentAccount = Logged.User.Client.Accounts[BankAccountsListBox.SelectedIndex];
                decimal amount = currentAccount.GetAmount();
                AmountLabel.Text = $"Amount: {amount}$";
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

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                foreach(Bank bank in banksDb.Set)
                {
                    foreach(Client client in bank.Clients)
                    {
                        BankAccount account = client.GetAccount(Convert.ToInt32(BankAccountTextBox.Text));
                        if (account != null)
                        {
                            decimal amount = account.Add(Convert.ToInt32(AmountTextBox.Text));
                            AmountLabel.Text = $"Amount: {amount}$";
                        }
                    }
                }
            }
        }

        private void CreateDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositAmountTextBox.Text.Length > 0 && DepositPercentTextBox.Text.Length > 0 && DepositTermTextBox.Text.Length > 0)
            { 
                Deposit deposit = Logged.User.Client.CreateDeposit(Convert.ToDecimal(DepositAmountTextBox.Text), Convert.ToInt32(DepositPercentTextBox.Text), Convert.ToInt32(DepositTermTextBox.Text));

                usersDb.Save();
                banksDb.Save();

                DepositListBox.Items.Add(deposit.Id);
            }
        }

        private void WithdrawDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1 && BankAccountsListBox.SelectedIndex != -1)
            {
                Deposit deposit = Logged.User.Client.WithdrawDeposit(DepositListBox.SelectedIndex);
                DepositListBox.Items.RemoveAt(DepositListBox.SelectedIndex);

                decimal amount = Logged.User.Client.Accounts[BankAccountsListBox.SelectedIndex].Add(deposit.Amount);
                
                AmountLabel.Text = $"Amount: {amount}$";
            }
        }

        private void FreezeDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                Logged.User.Client.BlockDeposit(DepositListBox.SelectedIndex);
            }
        }

        private void TransferDepositButton_Click(object sender, EventArgs e)
        {
            if (currentAccount != null && DepositListBox.SelectedIndex != -1)
            {
                foreach (Bank bank in banksDb.Set)
                {
                    foreach (Client client in bank.Clients)
                    {
                        BankAccount account = client.GetAccount(Convert.ToInt32(BankAccountTextBox.Text));
                        if (account != null)
                        {
                            decimal amount = account.Add(Logged.User.Client.Deposits[DepositListBox.SelectedIndex].Amount);
                            AmountLabel.Text = $"Amount: {amount}$";
                        }
                    }
                }
            }
        }

        private void DepositListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                decimal amount = Logged.User.Client.Deposits[DepositListBox.SelectedIndex].Amount;
                DepositAmountLabel.Text = $"Amount: {amount}$";
            }
        }
    }
}
