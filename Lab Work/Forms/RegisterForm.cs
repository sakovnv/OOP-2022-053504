using Lab_Work.Data;
using Lab_Work.Entities;
using Lab_Work.Entities.Builder;
using Lab_Work.Entities.UserStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Work
{
    public partial class RegisterForm : Form
    {
        DbSet<User> usersDb;
        DbSet<Bank> banksDb;
        AuthForm authForm;
        
        public RegisterForm(AuthForm form)
        {
            InitializeComponent();

            authForm = form;
            usersDb = Database.GetUsers();
            banksDb = Database.GetBanks();


            foreach (Bank bank in banksDb.Set)
            {
                BanksComboBox.Items.Add(bank);
            }
        }

        private void LoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            authForm.Show();
            Close();
        }

        private void hasAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Length > 0 && EmailTextBox.Text.Length > 0
                && PassportSeriesTextBox.Text.Length > 0 && PassportNumberTextBox.Text.Length > 0
                && PasswordTextBox.Text.Length > 0 && RepeatPasswordTextBox.Text.Length > 0
                && PassportNumberTextBox.Text.Length > 0 && FullNameTextBox.Text.Length > 0
                && PhoneNumberTextBox.Text.Length > 0
                && BanksComboBox.SelectedIndex != -1)
            {
                if (PasswordTextBox.Text == RepeatPasswordTextBox.Text)
                {
                    User user = usersDb.Set.Find(item => item.Login == LoginTextBox.Text || item.Email == EmailTextBox.Text);

                    Bank bank = banksDb.Set.Find(bank => bank.Name == BanksComboBox.Text);

                    Client client = bank.Clients.Find(client => client.PassportSeries == PassportSeriesTextBox.Text && client.PassportNumber == PassportNumberTextBox.Text);

                    if (client == null)
                    {
                        client = new Client()
                        {
                            FullName = FullNameTextBox.Text,
                            PassportSeries = PassportSeriesTextBox.Text,
                            PassportNumber = PassportNumberTextBox.Text,
                            Email = EmailTextBox.Text,
                            PhoneNumber = PhoneNumberTextBox.Text,
                        };
                        bank.AddClient(client);
                        User newUser = new User() { Login = LoginTextBox.Text, Email = EmailTextBox.Text, Password = PasswordTextBox.Text };
                        newUser.ClientId = client.Id;
                        newUser.BankId = bank.Id;

                        newUser.Id = usersDb.Set[usersDb.Set.Count - 1].Id + 1;

                        usersDb.Set.Add(newUser);
                        banksDb.Save();
                        usersDb.Save();

                        MessageBox.Show("Your account successfull registed\nWait for manager approves your account", "Success");
                    }
                    else
                    {
                        MessageBox.Show("These login or email already exist", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Warning");
                }
            }
        }
    }
}
