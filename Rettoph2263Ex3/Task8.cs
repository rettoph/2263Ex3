using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Write a function that accepts a 2D string array and 
    /// returns the average of all the ascii values of all the characters in all the strings in that array. 
    /// Write a function that randomly fills that array with strings containing 5 to 10 
    /// randomly selected lower case characters.
    /// </summary>
    public static class Task8
    {
        public const string Letters = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Write a function that accepts a 2D string array and 
        /// returns the average of all the ascii values of all the characters in all the strings in that array. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int Average2DStringArray(string[,] input)
        {
            // Grab the dimensions of the input array
            int width = input.GetLength(0);
            int height = input.GetLength(1);

            // Create a placeholders for average calculations
            int sum = 0;
            int count = 0; 

            // Iterate through the table columns
            for(int x=0; x<width; x++)
            {
                // Iterate through the table rows
                for (int y = 0; y < height; y++)
                {
                    // Iterate through every char in the word
                    for (int c = 0; c < input[x,y].Length; c++)
                    {
                        // Keep track of the sum of every char
                        sum += input[x, y][c];
                        count++;
                    }
                }
            }

            // Calculate & return the average
            return sum / count;
        }

        /// <summary>
        /// Write a function that randomly fills that array with strings containing 5 to 10 
        /// randomly selected lower case characters.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static string[,] Random2DStringArray(int width, int height)
        {
            // create a default 2d array of strings based on input dimensions
            string[,] output = new string[width, height];

            // Iterate through the columns
            for(int x=0; x<width; x++)
            {
                // Iterate through the cells
                for (int y = 0; y < width; y++)
                {
                    // Populate the current cell with a random word
                    output[x, y] = RandomString();
                }
            }

            return output;
        }

        /// <summary>
        /// Generate a random string 5-10 chars long
        /// </summary>
        /// <returns></returns>
        private static string RandomString()
        {
            string output = "";

            int length = Random.Shared.Next(5, 10);

            for(int i=0; i<length; i++)
            {
                int letterIndex = Random.Shared.Next(0, Letters.Length);

                output += Letters[letterIndex];
            }

            return output;
        }
    }
}
