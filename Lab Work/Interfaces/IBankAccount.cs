using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Interfaces
{
    interface IBankAccount
    {
        public void SetAmount(Decimal amount);
        public Decimal GetAmount();
        public Decimal Add(Decimal amount);
        public Decimal Sub(Decimal amount);
    }
}
