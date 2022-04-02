using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work.Interfaces
{
    interface IDbSet<T>
    {
        public void Save();
    }
}
