using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public class Person
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Возраст должен быть меньше 0, а был " +
                    value);
                }
                else
                    _age = value;
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Person person = new Person();
            person.Age = 28; //Aналогично вызову person.SetAge(28)
            Console.WriteLine(person.Age);
            //Аналогично вызову Console.WriteLine(person.GetAge())
        }
    }
}
