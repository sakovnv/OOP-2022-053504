using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    class Bank : IBank
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Client> Clients { get; set; }

        public Bank()
        {
            Clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public void DeleteClient(int id)
        {
            Clients.Remove( Clients.Where(item => item.Id == id).First() );
        }

        public IEnumerable<Client> GetAllClients()
        {
            return Clients;
        }

        public Client GetClient(int id)
        {
            return Clients.Where(item => item.Id == id).First();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
