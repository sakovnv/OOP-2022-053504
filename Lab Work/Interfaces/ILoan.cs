using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Interfaces
{
    interface ILoan
    {
        public Decimal Amount { get; set; }
        public Decimal Percent { get; set; }
        public int Term { get; set; }
    }
}
