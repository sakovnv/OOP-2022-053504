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

namespace Lab_Work
{
    public partial class AuthForm : Form
    {
        DbSet<User> usersDb;
        DbSet<Bank> banksDb;
        public AuthForm()
        {
            InitializeComponent();

            usersDb = Database.GetUsers();
            banksDb = Database.GetBanks();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm(this);
            form.Show();
            Hide();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0)
            { 
                User user = usersDb.Set.Find(item => item.Login == LoginTextBox.Text);
                if (user != null)
                {
                    if (user.Password == PasswordTextBox.Text)
                    {
                        if (user.IsApproved == true)
                        {
                            usersDb.Save();
                            Logged.User = user;

                            Bank bank = banksDb.Set.Find(item => item.Id == Logged.User.BankId);
                            Logged.Client = bank.GetClient(Logged.User.ClientId);
                            if (user.HasRole("admin"))
                            {
                                AdminPanelForm form = new AdminPanelForm();
                                form.Show();
                            }
                            else if (user.HasRole("client"))
                            {
                                ClientPanelForm form = new ClientPanelForm();
                                form.Show();
                            }

                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Your account need for approval\nWait while manager approve your account", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password for this account is incorrect", "Warning");
                    }
                }
                else
                {
                    MessageBox.Show("This account wasn't found", "Warning");
                }
            }
        }

        private void AsCompanyLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompanyRegisterForm form = new CompanyRegisterForm(this);
            form.Show();
            Hide();
        }
    }
}