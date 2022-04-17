using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities
{
    public class Bank : IBank
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
            client.BankId = Id;

            if (Clients.Count != 0)
            { 
                client.Id = Clients[Clients.Count - 1].Id + 1;
            }
            else
            {
                client.Id = 0;
            }

            Clients.Add(client);
        }

        public void DeleteClient(int id)
        {
            Clients.Remove( Clients.Find(item => item.Id == id) );
        }

        public IEnumerable<Client> GetAllClients()
        {
            return Clients;
        }

        public Client GetClient(int id)
        {
            return Clients.Find(item => item.Id == id);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
