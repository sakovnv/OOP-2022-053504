using Lab_Work.Data;
using Lab_Work.Entities;
using Lab_Work.Entities.Builder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Work
{
    public partial class AddClientForm : Form
    {
        private DbSet<Bank> banksDb;
        private MainForm mainForm;
        public AddClientForm(MainForm form)
        {
            banksDb = Database.GetBanks();

            mainForm = form;
            InitializeComponent();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 0 && PassportSeriesTextBox.Text.Length > 0
                && PassportNumberTextBox.Text.Length > 0 && PhoneNumberTextBox.Text.Length > 0
                && EmailTextBox.Text.Length > 0)
            {
                Bank bank = banksDb.Set[mainForm.BanksListBox.SelectedIndex];

                Client client = new Client
                {
                    FullName = FullNameTextBox.Text,
                    PassportSeries = PassportSeriesTextBox.Text,
                    PassportNumber = PassportNumberTextBox.Text,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Email = EmailTextBox.Text
                };

                bank.AddClient(client);

                banksDb.Save();

                mainForm.ClientsListBox.Items.Add(client.FullName);
                
                this.Close();
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelAddingButton_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
