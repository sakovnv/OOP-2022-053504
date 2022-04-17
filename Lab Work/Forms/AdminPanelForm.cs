using Lab_Work.Data;
using Lab_Work.Entities;
using Lab_Work.Entities.Builder;
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

namespace Lab_Work
{
    public partial class AdminPanelForm : Form
    {
        private DbSet<User> usersDb;
        private DbSet<Bank> banksDb;
        private Client currentClient;
        public AdminPanelForm()
        {
            InitializeComponent();

            banksDb = Database.GetBanks();
            usersDb = Database.GetUsers();

            currentClient = null;

            FillUsersList();

        }

        private void FillUsersList()
        {
            foreach (User item in usersDb.Set)
            {
                UsersListBox.Items.Add(item.Login);
            }
        }

        private void UsersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex != -1)
            {
                User user = usersDb.Set[UsersListBox.SelectedIndex];

                Bank bank = banksDb.Set.Find(item => item.Id == user.BankId);
                currentClient = bank.GetClient(user.ClientId);

                LoansListBox.Items.Clear();

                IdLabel.Text = "ID: " + usersDb.Set[UsersListBox.SelectedIndex].Id;
                LoginLabel.Text = "Login: " + usersDb.Set[UsersListBox.SelectedIndex].Login;
                EmailLabel.Text = "Email " + usersDb.Set[UsersListBox.SelectedIndex].Email;
                IsApprovedLabel.Text = "Is approved: " + usersDb.Set[UsersListBox.SelectedIndex].IsApproved;
                if (currentClient != null)
                { 
                    FullNameLabel.Text = "Full name: " + currentClient.FullName;
                    PassportSeriesLabel.Text = "Passport series: " + currentClient.PassportSeries;
                    PassportNumberLabel.Text = "Passport number: " + currentClient.PassportNumber;
                    PhoneNumberLabel.Text = "Phone number: " + currentClient.PhoneNumber;
            
                    if (currentClient.Loans.Count != 0)
                    {
                        foreach (Loan loan in currentClient.Loans)
                        {
                            LoansListBox.Items.Add(loan.Id);
                        }
                    }
                }
                if (!usersDb.Set[UsersListBox.SelectedIndex].IsApproved)
                {
                    ApproveButton.Visible = true;
                }
                else
                {
                    ApproveButton.Visible = false;
                }
            }


        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            UserBuilder userBuilder = new UserBuilder(usersDb.Set[UsersListBox.SelectedIndex]);

            usersDb.Set[UsersListBox.SelectedIndex].IsApproved = true;
            userBuilder.AddClientRole();
            usersDb.Save();
                
            ApproveButton.Visible = false;
            IsApprovedLabel.Text = "Is approved: " + usersDb.Set[UsersListBox.SelectedIndex].IsApproved;
        }

        private void LoansListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentClient != null)
            {
                Loan loan = currentClient.Loans[LoansListBox.SelectedIndex];
                LoanIdLabel.Text = "ID: " + loan.Id;
                LoanAmountLabel.Text = "Amount: " + loan.Amount;
                LoanTermLabel.Text = "Term: " + loan.Term;
                LoanPercentLabel.Text = "Percent: " + loan.Percent;
                LoanCreateTimeLabel.Text = "Create time: " + loan.CreateTime;
                LoanEndTimeLabel.Text = "End time: " + loan.EndTime;
                LoanIsApprovedLabel.Text = "Is approved: " + loan.IsApproved;
                
                if (!loan.IsApproved)
                {
                    LoanIsApprovedButton.Visible = true;
                }
                else
                {
                    LoanIsApprovedButton.Visible = false;
                }
            }
        }

        private void LoanIsApprovedButton_Click(object sender, EventArgs e)
        {
            if (currentClient != null)
            { 
                Loan loan = currentClient.Loans[LoansListBox.SelectedIndex];
                loan.IsApproved = true;
                LoanIsApprovedButton.Visible = false;
                BankAccount account = currentClient.GetAccount(loan.AccountId);
                account.Add(loan.Amount);
                banksDb.Save();
                usersDb.Save();
            }
        }
    }
}
