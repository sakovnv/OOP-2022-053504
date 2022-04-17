using Lab_Work.Data;
using Lab_Work.Entities;
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
    public partial class TransferForm : Form
    {
        private DbSet<Bank> banksDb;
        private ClientAccountsForm clientAccountForm;
        private BankAccount currentAccount;
        public TransferForm(ClientAccountsForm form, BankAccount account)
        {
            InitializeComponent();

            clientAccountForm = form;
            currentAccount = account;
            banksDb = Database.GetBanks();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (currentAccount != null)
            {
                foreach (Bank bank in banksDb.Set)
                {
                    foreach (Client client in bank.Clients)
                    {
                        BankAccount account = client.GetAccount(Convert.ToInt32(BankAccountTextBox.Text));
                        if (account != null)
                        {
                            decimal addAmount = account.Add(Convert.ToInt32(AmountTextBox.Text));
                            decimal amount = currentAccount.Sub(addAmount);

                            clientAccountForm.AmountLabel.Text = $"Amount: {amount}$";

                            banksDb.Save();
                        }
                    }
                }
            }
        }
    }
}
