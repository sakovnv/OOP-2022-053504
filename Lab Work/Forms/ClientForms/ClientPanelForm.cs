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
using Lab_Work.Forms.ClientForms;

namespace Lab_Work
{
    public partial class ClientPanelForm : Form
    {
        private DbSet<Bank> banksDb;
        private DbSet<User> usersDb;
        private Client currentClient;
        public ClientPanelForm()
        {
            InitializeComponent();

            banksDb = Database.GetBanks();
            usersDb = Database.GetUsers();

            Bank bank = banksDb.Set.Find(item => item.Id == Logged.User.BankId);
            currentClient = bank.GetClient(Logged.User.ClientId);
            foreach(Deposit deposit in currentClient.Deposits)
            {
                DepositListBox.Items.Add(deposit.Id);
            }
        }


        private void WithdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
        }

        private void CreateDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositAmountTextBox.Text.Length > 0 && DepositPercentTextBox.Text.Length > 0 && DepositTermTextBox.Text.Length > 0)
            { 
                Deposit deposit = currentClient.CreateDeposit(Convert.ToDecimal(DepositAmountTextBox.Text), Convert.ToInt32(DepositPercentTextBox.Text), Convert.ToInt32(DepositTermTextBox.Text));

                usersDb.Save();
                banksDb.Save();

                DepositListBox.Items.Add(deposit.Id);
            }
        }

        private void WithdrawDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                Deposit deposit = currentClient.WithdrawDeposit(DepositListBox.SelectedIndex);
                DepositListBox.Items.RemoveAt(DepositListBox.SelectedIndex);
            }
        }

        private void FreezeDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                currentClient.BlockDeposit(DepositListBox.SelectedIndex);
            }
        }

        private void TransferDepositButton_Click(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                TransferDepositForm form = new TransferDepositForm(this);
                form.Show();
            }
        }

        private void DepositListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DepositListBox.SelectedIndex != -1)
            {
                decimal amount = currentClient.Deposits[DepositListBox.SelectedIndex].Amount;
                DepositAmountLabel.Text = $"Amount: {amount}$";
            }
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            ClientAccountsForm form = new ClientAccountsForm();
            form.Show();
        }
        ~ClientPanelForm()
        {
            banksDb.Save();
        }
    }
}
