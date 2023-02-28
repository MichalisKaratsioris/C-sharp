/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Arrays
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements of `numbers` programmatically
            // - Print the elements of the reversed `numbers`:
            //   [7, 6, 5, 4, 3]

            int[] numbers = { 3, 4, 5, 6, 7 };
            int[] temp = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                temp[i] = numbers[numbers.Length - 1 - i];
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1)
                {
                    Console.Write($"{temp[i]}, ");
                }
                else
                {
                    Console.Write($"{temp[i]}");
                }
            }
        }
    }
}
*/