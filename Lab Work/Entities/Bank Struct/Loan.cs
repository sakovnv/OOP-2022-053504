using Lab_Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    class Loan : ILoan
    {
        public int Id { get; set; }
        public Loan(Decimal amount, Decimal percent, int term)
        {
            Amount = amount;
            Percent = percent;
            Term = term;

            CreateTime = DateTime.Now;
            EndTime = CreateTime.AddMonths(term);
        }

        public Decimal Amount { get; set; }
        public Decimal Percent { get; set; }
        public int Term { get; set; }
        public DateTime CreateTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public bool IsApproved { get; set; } = false;
        public int AccountId { get; set; }
    }
}
