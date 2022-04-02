using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Entities.User
{
    class Role
    {
        public string Name { get; set; }

        public Role(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
