using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Create a RECURSIVE function accepts an array of integers and reverses it. 
    /// </summary>
    public static class Task3
    {
        /// <summary>
        /// Create a RECURSIVE function accepts an array of integers and reverses it. 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        public static void ReverseArray(int[] input, int index = 0)
        {
            // If we've already swapped half the array we are done...
            if(index >= input.Length / 2)
            {
                return;
            }

            /// Swap the current index with the opposite end of the array
            Task1.NumSwap(ref input[index], ref input[input.Length - 1 - index]);

            // Recersively call the same function, move to the next index
            ReverseArray(input, index + 1);
        }
    }
}
