using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettoph2263Ex3
{
    /// <summary>
    /// (9 points) Write a function that accepts a 2D integer square array 
    /// (i.e., the same number of rows and columns) and flips it on the diagonal 
    /// that goes from the upper left hand corner to the lower right hand corner.
    /// </summary>
    public static class Task6
    {
        /// <summary>
        ///  Write a function that accepts a 2D integer square array 
        /// (i.e., the same number of rows and columns) and flips it on the diagonal 
        /// that goes from the upper left hand corner to the lower right hand corner.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[,] Flip2DSquare(int[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            int[,] output = new int[width, height];

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    int outputX = width - x - 1;
                    int outputY = height - y - 1;

                    output[outputX, outputY] = input[x, y];
                }
            }

            return output;
        }

        /// <summary>
        /// Generate a randomly populated 2d square
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[,] Random2DSquare(int size)
        {
            int[,] table = new int[size,size];

            for(var x=0; x< size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    table[x, y] = Random.Shared.Next(0, 99);
                }
            }

            return table;
        }
    }
}
