using Lab_Work.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    interface IBank
    {
        public void AddClient(Client client);
        public void DeleteClient(int id);
        public IEnumerable<Client> GetAllClients();
        public Client GetClient(int id);
    }
}
