using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Create a function that accepts a real number and returns a string
    /// containing the numerals for the digits to the right of the decimal point.
    /// </summary>
    public static class Task2
    {
        /// <summary>
        /// Create a function that accepts a real number and returns a string 
        /// containing the numerals for the digits to the right of the decimal point.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string DigitsRightOfDecimal(decimal input)
        {
            // Convert the input to a string
            string inputString = input.ToString();

            // Split the input on the decimal
            string[] inputComponents = inputString.Split('.');

            // If the split results in any number of items other than 2 we know the format us unexpected somehow
            // The most likely situation was a whole number being recieved like "2", which would have a length of
            // 1. This means there are no digits to the right of the decimal
            if (inputComponents.Length != 2)
            { // Just return an empty string at this point
                return string.Empty;
            }

            // If we've made it this far we can return the second item, which should contain
            // the required digits.
            return inputComponents[1];
        }
    }
}
