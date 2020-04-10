using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class StringExtension
    {
        public static string TrimAndLower(this string str)
        {
            str = str.Trim().ToLower();
            return str;
        }
    }
}
