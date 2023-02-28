/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class CountFromTo
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers. If the second number
            // is not greater than the first the program should print:
            // "The second number should be bigger"
            //
            // Otherwise it should output all integers between the first and
            // the second number (excluding the second number)
            //
            // Example:
            //
            // Please enter the first number: 3
            // Please enter the second number: 6
            // 3
            // 4
            // 5


            Console.Write("Please enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n2 <= n1)
            {
                Console.WriteLine("The second number should be bigger.");
            }
            else
            {
                for (int i = n1; i < n2; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
*/