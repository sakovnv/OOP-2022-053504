using Lab_Work.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Interfaces
{
    interface IClient
    {
        public string FullName { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Deposit CreateDeposit(Decimal amount, int percent, int term);
        public Deposit WithdrawDeposit(int id);
        public void TransactionDeposit(Client client, Deposit deposit);
        public void BlockDeposit(int id);
        public void UnblockDeposit(int id);

        public Loan CreateLoan(Decimal amount, int percent, int term);

        public BankAccount CreateAccount();

    }
}
