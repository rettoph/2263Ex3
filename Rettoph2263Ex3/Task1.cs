using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Create a function that accepts 2 integers (pass by reference) and swaps them. 
    /// In addition to being able to test your function with the button and txtIn, 
    /// create a listbox that tests your function for arguments 2 and 3, 5 and 7, and 42 and 43.
    /// </summary>
    public static class Task1
    {
        /// <summary>
        /// Create a function that accepts 2 integers (pass by reference) and swaps them.
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        public static void NumSwap(ref int input1, ref int input2)
        {
            // Create a temp placeholder
            int temp = input1;

            // Swap the first numbers
            input1 = input2;

            // Swap the second using the previous temp value
            input2 = temp;
        }

        /// <summary>
        /// Create a function that accepts 2 integers (pass by reference) and swaps them.
        /// 
        /// This one is fancy because it allows us to input a string of 2 numbers 
        /// deliminated by a comma. It will swap the numbers and return a rebuilt
        /// string of the numbers swapped.
        /// </summary>
        /// <param name="input"></param>
        public static string NumSwap(string input)
        {
            // Split the input string on the comma deliminator
            string[] inputStrings = input.Split(',');

            // Parse the input string components to ints
            int num1 = int.Parse(inputStrings[0]);
            int num2 = int.Parse(inputStrings[1]);

            // Swap the ints, passing in the references
            NumSwap(ref num1, ref num2);

            // Construct a new string with the swapped ints & return it
            string output = num1 + "," + num2;
            return output;
        }
    }
}
