using Lab_Work.Entities.User;
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
    public partial class ApplyForLoanForm : Form
    {
        ClientPanelForm clientPanelForm;
        public ApplyForLoanForm(ClientPanelForm form)
        {
            InitializeComponent();

            AccountNumberLabel.Text += form.BankAccountsListBox.SelectedItem;

            clientPanelForm = form;
            form.Hide();
        }

        private void ChoosePercentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChoosePercentTypeComboBox.SelectedIndex == 1)
            {
                IndividualPercentTextBox.Visible = true;
            }
            else
            {
                IndividualPercentTextBox.Visible = false;
            }
        }

        private void TermComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TermComboBox.SelectedIndex == 4)
            {
                TermNumericUpDown.Visible = true;
            }
            else
            {
                TermNumericUpDown.Visible = false;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (ChoosePercentTypeComboBox.SelectedIndex != -1 && TermComboBox.SelectedIndex != -1
                && PurposeOfLoanTextBox.Text.Length > 0 && AmountTextBox.Text.Length > 0)
            {

                if (ChoosePercentTypeComboBox.SelectedIndex == 1 && TermComboBox.SelectedIndex == 4)
                {
                    Logged.User.Client.CreateLoan(Convert.ToDecimal(AmountTextBox.Text), Convert.ToInt32(IndividualPercentTextBox.Text), (int)TermNumericUpDown.Value);
                }
                else if (ChoosePercentTypeComboBox.SelectedIndex == 1)
                {
                    int term = Convert.ToInt32(TermComboBox.SelectedItem.ToString().Trim(new char[] { ' ', 'm', 'o', 'n', 't', 'h' }));
                    
                    Logged.User.Client.CreateLoan(Convert.ToDecimal(AmountTextBox.Text), Convert.ToInt32(IndividualPercentTextBox.Text), term);
                }
                else if (TermComboBox.SelectedIndex == 4)
                {
                    Logged.User.Client.CreateLoan(Convert.ToDecimal(AmountTextBox.Text), Convert.ToInt32(ChoosePercentTypeComboBox.SelectedItem), (int)TermNumericUpDown.Value);
                }
                else
                {
                    int term = Convert.ToInt32(TermComboBox.SelectedItem.ToString().Trim(new char[] { ' ', 'm', 'o', 'n', 't', 'h' }));
                    Logged.User.Client.CreateLoan(Convert.ToDecimal(AmountTextBox.Text), Convert.ToInt32(ChoosePercentTypeComboBox.SelectedItem), term);
                }

                MessageBox.Show("your loan application has been successfully submitted.\n Wait for confirmation.", "Success");
                
                clientPanelForm.Show();
                this.Close();
            }
        }
    }
}
