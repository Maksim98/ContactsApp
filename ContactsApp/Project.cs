using System.Collections.Generic;
using System.Linq;
using System;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        public List<Contact> ContactList;

        /// <summary>
        /// Конструктор списка 
        /// </summary>
        public Project()
        {
            ContactList = new List<Contact>();
        }

        /// <summary>
        /// Сортировка списка по алфавиту.
        /// </summary>
        public List<Contact> Sort()
        {
            var list = ContactList;
            list.Sort((First, Second) => First.Surname.CompareTo(Second.Surname));
            return list;
        }

        /// <summary>
        /// Получение списка именинников.
        /// </summary>
        public string GetListBirthday()
        {
            var listContacts = ContactList.Where(First => First.BirthDay.Day == DateTime.Now.Day && First.BirthDay.Month == DateTime.Now.Month);

            return string.Join(",", listContacts.Select(contact => contact.Surname).ToList());
        }
        /// <summary
        /// Поиск по фамилии.
        /// </summary>
        public List<Contact> GetByNameOrSurname(string text)
        {
            return Sort().FindAll(First => First.Surname.Contains(text) || First.Name.Contains(text));
        }
    }
}
