using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Contact: ICloneable //класс для добавления контактов
    {
        private NumberPhone _numberPhone;
        private String _name;
        public String Name //поле для добавления имени
        {
            get { return _name; }
            set
            {
                if (value.Length <= 50)
                {
                    _name = Char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                    throw new ArgumentException("Введите имя не длинее 50 символов " + value);

            }
        }
    
        private String _surname;
        public String Surame//поле для добавления фамилии
        {
            get { return _surname; }
            set
            {
                if (value.ToString().Length <= 50)
                {
                    _surname = Char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                    throw new ArgumentException("Введите фамилию не длинее 50 символов " + value);

            }
        }
        private DateTime _birthsday;//поле для добавления дня рождения
        public DateTime Birthsday
        {
            get { return _birthsday; }
            set
            {
                if (value < DateTime.Now && value > new DateTime(1900, 1, 1))
                {
                    _birthsday = value;
                }
                else
                    throw new ArgumentException("Неверная дата рождения, она должна быть не больше текущей и не меньше 1900 г. " + value);

            }
        }

        private String _email;//поле для добавления почты E-mail
        public String Email
        {
            get { return _email; }
            set
            {
                if (value.ToString().Length <= 50)
                {
                    _email = value;
                }
                else
                    throw new ArgumentException("Введите E-mail не длинее 50 символов " + value);

            }
        }
        private String _id;//поле для добавления id
        public String ID
        {
            get { return _id; }
            set
            {
                if (value.ToString().Length <= 15)
                {
                    _id = value;
                }
                else
                    throw new ArgumentException("Введите id не длинее 15 символов " + value);

            }
        }

        public object Clone()
        {
            var contact = new Contact();
            contact.Name = Name;
            contact.Surame = Surame;
            return contact;
        }
    }
}
