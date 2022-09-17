using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    ///  (9 points) Create a function that accepts a positive integer and returns an integer array of 
    ///  that length that contains random integers between 0 and 99. 
    ///  Use your function from #3 to reverse that array. 
    ///  Then create a third function that accepts that reversed array and returns a string containing a 
    ///  string representation of the integers in that array separated by spaces 
    ///  (do not use any builtin gadget to convert the integer array into a string. 
    ///  I am expecting loops and math and ascii code here.)
    /// </summary>
    internal class Task4
    {
        /// <summary>
        /// 48 is the ascii value of the 0 char in base 10
        /// </summary>
        private const int Zero = 48;

        /// <summary>
        /// Create a function that accepts a positive integer and returns an integer array of that length that
        /// contains random integers between 0 and 99. Use your function from #3 to reverse that array.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[] RandomInts(int size)
        {
            // Create a new array to hold our numbers
            int[] output = new int[size];

            // Populate the array with random ints from 0 to 99
            for(int i=0; i<size; i++)
            {
                output[i] = Random.Shared.Next(0, 99);
            }

            // Reverse the array
            Task3.ReverseArray(output, 0);

            return output;
        }

        /// <summary>
        /// create a third function that accepts that reversed array and returns a string containing a string 
        /// representation of the integers in that array separated by spaces
        /// (do not use any builtin gadget to convert the integer array into a string. 
        /// I am expecting loops and math and ascii code here.)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string IntArrayToString(int[] input)
        {
            string output = string.Empty;

            foreach(int item in input)
            {
                output += IntToString(item) + " ";
            }

            return output;
        }

        /// <summary>
        /// Convert an int between 0 and 99 to
        /// its string representation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string IntToString(int input)
        {
            // Ensure that only numbers between 0 and 99 are converted
            if(input < 0 || input > 99)
            {
                return "?";
            }

            // Calculate the ones & tens places
            int onesPlace = input % 10;
            int tensPlace = input / 10;

            // Convert the ones and tens place digits to chars
            char onesChar = DigitToChar(onesPlace);
            char tensChar = DigitToChar(tensPlace);

            // Add the two chars together to create a string representation of the input number
            string output = string.Concat(tensChar, onesChar);

            return output;
        }

        /// <summary>
        /// Convert a single digit (between 0 and 9)
        /// into a char
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        private static char DigitToChar(int digit)
        {
            // Ensure the input is a single digit between 0 and 9
            if (digit < 0 || digit > 9)
            {
                return '?';
            }

            // Since ASCII numbers are sequential, we just need to add the input 
            // to the ascii value for 0 char
            int outputValue = Task4.Zero + digit;

            // For Reference, here is a lookup table:
            // 48 - '0'
            // 49 - '1'
            // 50 - '2'
            // 51 - '3'
            // 52 - '4'
            // 53 - '5'
            // 54 - '6'
            // 55 - '7'
            // 56 - '8'
            // 57 - '9'

            // Convert the calculated ascii value to a char
            char output = (char)outputValue;

            return output;
        }
    }
}
