using Lab_Work.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    class Company : ICompany
    {
        public string Type { get; set; }
        public string LegalName { get; set; }
        public string PayerAccountNumber { get; set; }
        public string BankIdentificationCode { get; set; }
        public string LegalAdress { get; set; }
    }
}
