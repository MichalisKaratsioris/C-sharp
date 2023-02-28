/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class Factorio
    {
        static void Main(string[] args)
        {
            // - Create a function called `calculateFactorial()`
            //   that returns the factorial of its input
            //
            // - Example: calculateFactorial(5) = 1 * 2 * 3 * 4 * 5 = 120

            Console.Write("Please, provide the number of the factorial you want to calculate: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculateFactorial(number));

        }

        public static int calculateFactorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }

    }
}
*/