using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using TestOne.Models;
using System.IO;
using Newtonsoft.Json;

namespace TestOne.Services
{
    class FileSaveAndLoad
    {
        private string path;

        public FileSaveAndLoad(string path)
        {
            this.path = path;
        }

        public BindingList<Person> loadData()
        {
            if (!File.Exists(path))
            {
                File.CreateText(path).Dispose();
                return new BindingList<Person>();
            }
            using (var reader = File.OpenText(path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Person>>(fileText);
            }
        }

        public void SaveData(BindingList<Person> _test)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.Write(JsonConvert.SerializeObject(_test));
            }
        }
    }
}
