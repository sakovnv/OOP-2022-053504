using Lab_Work.Entities;
using Lab_Work.Entities.UserStruct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_Work.Data
{
    static class Database
    {
        private static DbSet<Bank> Banks { get; set; }
        private static DbSet<User> Users { get; set; }
        private static DbSet<Company> Companies { get; set; }

        public static DbSet<Bank> GetBanks()
        {
            if (Banks == null)
            {
                Banks = new DbSet<Bank>("Banks");
                return Banks;
            }
            else
            {
                return Banks;
            }
        }

        public static DbSet<User> GetUsers()
        {
            if (Users == null)
            {
                Users = new DbSet<User>("Users");
                return Users;
            }
            else
            {
                return Users;
            }
        }

        public static DbSet<Company> GetCompanies()
        {
            if (Companies == null)
            {
                Companies = new DbSet<Company>("Companies");
                return Companies;
            }
            else
            {
                return Companies;
            }
        }
    }
}
