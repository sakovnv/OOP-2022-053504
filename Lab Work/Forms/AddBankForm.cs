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
    public partial class AddBankForm : Form
    {
        MainForm mainForm;
        DbSet<Bank> banksDb;
        public AddBankForm(MainForm _mainForm)
        {
            InitializeComponent();

            mainForm = _mainForm;
            banksDb = Database.GetBanks();
        }

        private void AddBankButton_Click(object sender, EventArgs e)
        {
            if (BankNameTextBox.Text.Length > 0)
            {
                Bank bank = new Bank { Id = banksDb.Set.Count(), Name = BankNameTextBox.Text };

                mainForm.BanksListBox.Items.Add(bank);

                banksDb.Set.Add(bank);
                banksDb.Save();

                this.Close();
            }
        }
    }
}
