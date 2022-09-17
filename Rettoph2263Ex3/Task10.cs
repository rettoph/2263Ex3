using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Write a recursive function that accepts a 1D integer and sums 
    /// all the values in the array. Do not use any builtin gadget, 
    /// but write the code that traverses the array yourself. 
    /// Note that a recursive function does not use any loops (while, for, until, gotos, etc), 
    /// but calls itself.
    /// </summary>
    public static class Task10
    {
        /// <summary>
        /// Write a recursive function that accepts a 1D integer and sums 
        /// all the values in the array.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int SumArray(int[] input, int index = 0)
        {
            if(index == input.Length)
            {
                return 0;
            }
 
            return input[index] + SumArray(input, index + 1);
        }
    }
}
