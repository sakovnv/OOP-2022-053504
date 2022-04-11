using Lab_Work.Entities;
using Lab_Work.Entities.UserStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Interfaces
{
    interface IUserBuilder
    {
        public void AddClientRole();
        public void AddAdminRole();
        public void AddManagerRole();
        public User GetUser();
    }
}
