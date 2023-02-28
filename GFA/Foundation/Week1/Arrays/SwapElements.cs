/*

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Arrays
{
    internal class SwapElements
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders` programmatically
            // - Print the swapped array into the console:
            //   [third, second, first]

            string[] orders = { "first", "second", "third" };
            (orders[0], orders[2]) = (orders[2], orders[0]);
            for (int i = 0; i < orders.Length; i++)
            {
                if (i < orders.Length - 1)
                {
                    Console.Write($"{orders[i]}, ");
                }
                else
                {
                    Console.Write($"{orders[i]}");

                }
            }

        }
    }
}
*/