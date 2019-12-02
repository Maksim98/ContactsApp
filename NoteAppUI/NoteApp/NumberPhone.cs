using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class NumberPhone //класс для добавления номера телефона
    {
        private long _number; //поле добавления номера телефона и проверки на правильность ввода
        public long Number
        {
            get { return _number; }
            set
            {
                if (value.ToString().Length == 11 && value.ToString().First() == '7')
                {
                    _number = value;
                }
                else
                    throw new ArgumentException("Введите номер телефона начиная с 7 и общее кол-во цифр должно быть равно 11" + value);
                
            }
        }
    }
}
