using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public static class Validator
    {
        #region Public methods

        /// <summary>
        /// Checking if a symbol is an underscore.
        /// </summary>
        /// <param name="symbol">The value of the symbol.</param>
        /// <returns>The value indicates whether the underscore symbol is.</returns>
        public static bool IsUnderscore(char symbol)
        {
            return symbol == '_';
        }

        /// <summary>
        /// Checking if a symbol is a hyphen
        /// </summary>
        /// <param name="symbol">The value of the symbol.</param>
        /// <returns>The value indicates whether the hyphen symbol is.</returns>
        public static bool IsHyphen(char symbol)
        {
            return symbol == '-';
        }

        /// <summary>
        /// Checking if the symbol is a Latin letter.
        /// </summary>
        /// <param name="symbol">The value of the symbol.</param>
        /// <returns>The value indicates whether the symbol is a Latin letter.</returns>
        public static bool IsLatinLetter(char symbol)
        {
            return symbol >= 'a' && symbol <= 'z';
        }

        /// <summary>
        /// Checking whether the symbol is a digit.
        /// </summary>
        /// <param name="symbol">The value of the symbol.</param>
        /// <returns>The value indicates whether the symbol is a digit.</returns>
        public static bool IsDigital(char symbol)
        {
            return char.IsDigit(symbol);
        }

        /// <summary>
        /// Checking if the symbol is a Russian letter.
        /// </summary>
        /// <param name="symbol">The value of the symbol.</param>
        /// <returns>The value indicates whether the symbol is a Russian letter.</returns>
        public static bool IsRussianLetter(char symbol)
        {
            return symbol >= 'а' && symbol <= 'я';
        }

        /// <summary>
        /// Assert the string for null or white space.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <param name="name">Name of the entered string.</param>
        public static void AssertNullOrWhiteSpace(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "Contact's " + name +
                    " can't be empty! Current value " + name + " is " + value);
            }
        }

        /// <summary>
        /// Assert the number of symbols in the entered string.
        /// </summary>
        /// <param name="value">String value.</param>
        /// <param name="name">Name of the entered string.</param>
        /// <param name="maxNumberSymbols">Maximum number of symbols per line.</param>
        public static void AssertLengthString(string value, string name,
            uint maxNumberSymbols)
        {
            if (value.Length > maxNumberSymbols)
            {
                throw new ArgumentException(
                    "Contact's " + name + " length should be no more than " +
                    maxNumberSymbols +
                    " symbols ! Current " + name + " length is " +
                    value.Length);
            }
        }

        #endregion
    }
}
