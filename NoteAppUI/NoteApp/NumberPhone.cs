using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class NumberPhone
    {
        private long _number;
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
                    throw new ArgumentException("Введите номер телефона начиная с 7 " + value);
                
            }
        }
    }
}
