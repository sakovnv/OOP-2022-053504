using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities.User
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsApproved { get; set; } = false;
        
        public Client Client { get; set; }
        public List<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }

        public Role AddRole(string roleName)
        {

            Role role = new Role(roleName);

            Roles.Add(role);

            return role;
        }

        public bool HasRole(string roleName)
        {
            Role role = Roles.Find(item => item.Name == roleName);
            
            if (role != null)
            {
                return true;
            }
            return false;
        }

        public bool DeleteRole(string roleName)
        {
            Role role = Roles.Find(item => item.Name == roleName);

            return Roles.Remove(role);
        }
    }
}
