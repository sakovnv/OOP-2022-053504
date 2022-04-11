using Lab_Work.Interfaces;
using Lab_Work.Entities.UserStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities.Builder
{
    class UserBuilder : IUserBuilder
    {
        private User user;

        public UserBuilder() 
        {
            user = new User();
        }
        public UserBuilder(User user)
        {
            this.user = user;
        }
        public void AddAdminRole()
        {
            user.AddRole("admin");
        }

        public void AddClientRole()
        {
            user.AddRole("client");
        }

        public void AddManagerRole()
        {
            user.AddRole("manager");
        }

        public User GetUser()
        {
            return user;
        }
    }
}
