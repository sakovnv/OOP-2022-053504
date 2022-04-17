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
    public partial class TransferDepositForm : Form
    {
        ClientPanelForm clientPanelForm;
        DbSet<Bank> banksDb;
        public TransferDepositForm(ClientPanelForm form)
        {
            InitializeComponent();

            clientPanelForm = form;
            banksDb = Database.GetBanks();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (clientPanelForm.DepositListBox.SelectedIndex != -1)
            {
                foreach (Bank bank in banksDb.Set)
                {
                    foreach (Client client in bank.Clients)
                    {
                        BankAccount account = client.Accounts.Find(item => item.Id == Convert.ToInt32(AccountIdTextBox.Text));
                        if (account != null)
                        {
                            Logged.Client.WithdrawDeposit(clientPanelForm.DepositListBox.SelectedIndex);
                            clientPanelForm.DepositListBox.Items.RemoveAt(clientPanelForm.DepositListBox.SelectedIndex);
                            decimal amount = account.Add(Logged.Client.Deposits[clientPanelForm.DepositListBox.SelectedIndex].Amount);
                            Close();
                        }
                    }
                }
            }
        }
    }
}
