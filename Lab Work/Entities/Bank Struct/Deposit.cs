using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    class Deposit
    {
        public int Id { get; set; }
        public Deposit(Decimal amount, int percent, int term)
        {
            Amount = amount;
            Percent = percent;
            Term = term;

            CreateTime = DateTime.Now;

            EndTime = CreateTime.AddMonths(Term);
        }

        public Decimal Amount { get; set; }
        public int Percent { get; set; }
        public int Term { get; set; }
        public bool IsBlocked { get; set; } = false;
        public DateTime CreateTime { get; private set; }
        public DateTime EndTime { get; private set; }
    }
}
