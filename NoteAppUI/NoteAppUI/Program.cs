using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteApp;
using System.Windows.Forms;

namespace NoteAppUI
{
    public class Program
    {
        public static void Main()
        {
            NumberPhone numberPhone = new NumberPhone();
            numberPhone.Number = 7951593616; //Aналогично вызову person.SetAge(28)
            Console.WriteLine(numberPhone.Number); //Аналогично вызову Console.WriteLine(person.GetAge())
        }
    }
}
