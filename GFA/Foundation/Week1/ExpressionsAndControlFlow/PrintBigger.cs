/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class PrintBigger
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one.
            // If they are equal, it prints the second one.
            //
            // Example
            //
            // Please enter a number: 5
            // Please enter a number: 13
            // 13

            Console.Write("Please enter a number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());   

            Console.Write("Please enter a number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= n2)
            {
                Console.WriteLine(n2);
            }
            else
            {
                Console.WriteLine(n1);
            }

        }
    }
}
*/