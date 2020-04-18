using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    // TODO: xml
    public class Project //класс для добавления всех контактов в проект
    {
        public List<Contact> Contacts { get; }

        public Project()
        {
            Contacts = new List<Contact>();
        }
    }
}
