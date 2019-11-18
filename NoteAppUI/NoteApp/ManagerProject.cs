using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    class ManagerProject
    {
        private const String FilePath = "C:\\Users\\Makse\\Documents\\ContactsApp.notes";

        public Project Project { get; set; }

        public void SaveToFile()
        {
            var jsonString = JsonConvert.SerializeObject(Project.Contacts);
            File.WriteAllText(FilePath, jsonString);
            
        }

        public Project LoadFromFile()
        {
            var file = File.ReadAllText("FilePath");
            List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(file);
            return new Project(contacts);
        }
    }
}
