/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            // Write a function called `sum()` that returns the sum of numbers
            // from zero to the given parameter
            //
            // Example: sum(5) = 0 + 1 + 2 + 3 + 4 + 5 = 15

            Console.Write("Please, provide the number up until which you want the sum: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Summation(number));

        }

        private static int Summation(int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            return s;
        }
    }
}
*/