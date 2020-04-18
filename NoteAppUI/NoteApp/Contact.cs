using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    // TODO: во всём классе нет xml-комментариев
    public class Contact: ICloneable //класс для добавления контактов
    {
        // TODO: в классе сначала должны быть все поля, затем все свойства
        private NumberPhone _phone = new NumberPhone();
        /// <summary>
        /// Gets or sets contact's phone number.
        /// </summary>
        public NumberPhone Phone
        {
            get => _phone;
            set
            {
                // TODO: проверка уже реализована в классе номера телефона. Здесь её быть не должно
                const long MinValueNumber = 79000000000;
                const long MaxValueNumber = 79999999999;

                if (value.Number < MinValueNumber || value.Number > MaxValueNumber)
                {
                    throw new ArgumentException(
                        "Phone number must be between " + MinValueNumber + " and " +
                        MaxValueNumber + ", but was entered " + value.Number);
                }

                _phone = value;
            }
        }

        private String _name;//поле для добавления имени
        public String Name 
        {
            get { return _name; }
            set
            {
                if (value.Length <= 50)
                {
                    _name = Char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                    // TODO: грамошибка в тексте
                    // TODO: Здесь сообщение по-русски, в других классах и методах по-английски - откуда копировал? Сделать единообразно
                    throw new ArgumentException("Введите имя не длинее 50 символов " + value);

            }
        }

        // TODO: грамошибка в именовании, исправить везде
        private String _Surame;//поле для добавления фамилии
        public String Surame
        {
            get { return _Surame; }
            set
            {
                if (value.ToString().Length <= 50)
                {
                    _Surame = Char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                    throw new ArgumentException("Введите фамилию не длинее 50 символов " + value);

            }
        }
        // TODO: грамошибка в названии, исправить везде
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
        // TODO: переименовать в VkId - айдишников может быть много, должна быть конкретика
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
            // TODO: должны копироваться все данные из объекта
            var contact = new Contact();
            contact.Name = Name;
            contact.Surame = Surame;
            return contact;
        }
    }
}
