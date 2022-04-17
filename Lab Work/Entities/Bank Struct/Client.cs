using Lab_Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    public class Client : IClient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int BankId { get; set; }

        public List<Deposit> Deposits { get; set; }
        public List<Loan> Loans { get; set; }
        public List<BankAccount> Accounts { get; set; }

        
        public Client()
        {
            Deposits = new List<Deposit>();
            Loans = new List<Loan>();
            Accounts = new List<BankAccount>();
        }


        public Deposit CreateDeposit(Decimal amount, int percent, int term)
        {
            Deposit deposit = new Deposit(amount, percent, term);

            if (Deposits.Count != 0)
            {
                deposit.Id = Deposits[Deposits.Count - 1].Id + 1;
            }
            else
            {
                deposit.Id = 0;
            }

            Deposits.Add(deposit);

            return deposit;
        }

        public Deposit WithdrawDeposit(int id)
        {
            Deposit deposit = Deposits.Find(item => item.Id == id);

            if (deposit != null)
            { 
                Deposits.Remove(deposit);
            }

            return deposit;
        }

        public void TransactionDeposit(Client client, Deposit deposit)
        {
            client.CreateDeposit(deposit.Amount, deposit.Percent, deposit.Term);

            WithdrawDeposit(deposit.Id);
        }

        public void BlockDeposit(int id)
        {
            Deposit deposit = Deposits.Where(item => item.Id == id).FirstOrDefault();

            deposit.IsBlocked = true;
        }

        public void UnblockDeposit(int id)
        {
            Deposit deposit = Deposits.Where(item => item.Id == id).FirstOrDefault();

            deposit.IsBlocked = false;
        }

        public Loan CreateLoan(Decimal amount, int percent, int term)
        {
            Loan loan = new Loan(amount, percent, term);

            if (Loans.Count != 0)
            {
                loan.Id = Loans[Loans.Count - 1].Id + 1;
            }
            else
            {
                loan.Id = 0;
            }

            Loans.Add(loan);

            return loan;
        }

        public BankAccount CreateAccount()
        {
            BankAccount account = new BankAccount();

            if (Accounts.Count != 0)
            {
                account.Id = Accounts[Accounts.Count - 1].Id + 1;
            }
            else
            {
                account.Id = BankId * 100 + Id * 10 + 0;
            }

            Accounts.Add(account);

            return account;
        }

        public BankAccount RemoveAccount(int id)
        {
            BankAccount account = Accounts.Find(item => item.Id == id);
            
            Accounts.Remove(account);

            return account;
        }

        public BankAccount GetAccount(int id)
        {
            BankAccount account = Accounts.Find(item => item.Id == id);

            return account;
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}
