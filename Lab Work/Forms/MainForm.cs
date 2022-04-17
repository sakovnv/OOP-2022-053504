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

namespace Lab_Work
{
    public partial class MainForm : Form
    {
        DbSet<Bank> banksDb;
        public MainForm()
        {
            InitializeComponent();

            banksDb = Database.GetBanks();

            foreach(Bank item in banksDb.Set)
            {
                BanksListBox.Items.Add(item);
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (BanksListBox.SelectedIndex != -1)
            {
                AddClientForm form = new AddClientForm(this);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a bank in the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBankButton_Click(object sender, EventArgs e)
        {
            AddBankForm form = new AddBankForm(this);
            form.ShowDialog();
        }

        private void BanksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bank bank = banksDb.Set[BanksListBox.SelectedIndex];

            ClientsListBox.Items.Clear();
            foreach(Client item in bank.Clients)
            {
                ClientsListBox.Items.Add(item);
            }
        }
    }
}
