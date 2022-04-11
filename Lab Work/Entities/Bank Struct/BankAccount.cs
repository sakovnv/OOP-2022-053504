using Lab_Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    class BankAccount : IBankAccount
    {
        public int Id { get; set; }

        public Decimal amount;

        public BankAccount()
        {
            amount = 0;
        }

        public Decimal GetAmount()
        {
            return amount;
        }

        public void SetAmount(Decimal amount)
        {
            this.amount = amount;
        }

        public Decimal Add(Decimal amount)
        {
            this.amount += amount;

            return this.amount;
        }

        public Decimal Sub(Decimal amount)
        {
            if (this.amount - amount >= 0)
            {
                this.amount -= amount;
            }
            return this.amount;
        }
    }
}
