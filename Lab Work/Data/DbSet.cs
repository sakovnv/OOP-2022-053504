using Lab_Work.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab_Work.Data
{
    class DbSet<T> : IDbSet<T>
    {
        private string FileName { get; set; }
        public List<T> Set { get; set; }
        public DbSet(string fileName)
        {
            FileName = fileName;
            FileName += ".json";

            Set = new List<T>();

            if (!File.Exists(FileName))
            {
                File.Create(FileName).Dispose();
                Save();
            }
            Get();   
        }

        public void Save()
        {
            using (StreamWriter fs = new StreamWriter(FileName, false))
            {
                string json = JsonSerializer.Serialize(Set, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
                fs.Write(json);
            }
        }

        private List<T> Get()
        {
            string json = File.ReadAllText(FileName);
            Set = JsonSerializer.Deserialize<List<T>>(json, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
            return Set;
        }
    }
}
