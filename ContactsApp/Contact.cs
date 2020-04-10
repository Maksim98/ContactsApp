using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс приватных переменных
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Поле с именем класса
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле с фамилией контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Поле с номером контакта
        /// </summary>
        public PhoneNumber Phone;

        /// <summary>
        /// Поле с датой рождения
        /// </summary>
        private DateTime _birthDay;

        /// <summary>
        /// Поле с электронной почтой
        /// </summary>
        private string _email;

        ///<summary>
        ///Поле с ID ВКонтакте
        ///</summary>
        private string _vkId;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Contact()
        {
            Phone = new PhoneNumber(70000000000);
        }

        /// <summary>
        /// Ввод имени контакта
        /// </summary>
        public string Name
        {
            get => _name;

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле имени не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException($"Длина имени должна быть не более 50-ти символов, а была { value.Length }");
                }
                else
                {
                    _name = Char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }


        /// <summary>
        /// Ввод фамилии контакта
        /// </summary>
        public string Surname
        {
            get => _surname;

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле 'Surname' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина фамилии должна быть не более 50-ти символов, а была" + value.Length);
                }
                else
                {
                    _surname = Char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        /// <summary>
        /// Ввод даты рождения
        /// </summary>
        public DateTime BirthDay
        {
            get => _birthDay;

            set
            {
                if (value.Year <= 1900)
                {
                    throw new ArgumentException("Дата рождения не может быть меньше 1900 года");
                }
                else if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата не должна быть больше " + DateTime.Now.ToShortDateString() + ", а была " + value.Date.ToShortDateString());
                }
                else
                {
                    _birthDay = value;
                }
            }
        }

        /// <summary>
        /// Ввод электронной почты.
        /// </summary>
        public string Email
        {
            get => _email;

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Поле 'E-mail' не может быть пустым");
                }
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Длина адреса почты должна быть не более 50 символов, а была " + value.Length);
                }
                else
                    _email = value;
            }
        }

        /// <summary>
        /// Ввод адреса ВК
        /// </summary>
        public string VkId
        {
            get => _vkId;

            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id Вконтакте должна быть не более 15-ти символов, а была " + value.Length);
                }
                else
                {
                    _vkId = value;
                }
            }
        }
    }
}
