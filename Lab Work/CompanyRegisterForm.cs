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
    public partial class CompanyRegisterForm : Form
    {
        AuthForm authForm;
        DbSet<Company> companiesDb;
        public CompanyRegisterForm(AuthForm form)
        {
            InitializeComponent();

            authForm = form;
            companiesDb = Database.GetCompanies();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (TypeCompanyTextBox.Text.Length > 0 && LegalNameTextBox.Text.Length > 0 
                && PayerAccountNumberTextBox.Text.Length > 0 && BankIdentificationCodeTextBox.Text.Length > 0
                && LegalAdressTextBox.Text.Length > 0)
            {
                Company company = new Company
                {
                    Type = TypeCompanyTextBox.Text,
                    LegalName = LegalNameTextBox.Text,
                    PayerAccountNumber = PayerAccountNumberTextBox.Text,
                    BankIdentificationCode = BankIdentificationCodeTextBox.Text,
                    LegalAdress = LegalAdressTextBox.Text
                };
                companiesDb.Set.Add(company);
                companiesDb.Save();

                authForm.Show();
                Close();
            }
        }

        private void BackLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            authForm.Show();
            Close();
        }
    }
}
