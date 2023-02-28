/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class AnimalsAndLegs
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // Print how many legs all the animals have in total
            //
            // Example
            //
            // Please enter the number of chickens: 4
            // Please enter the number of pigs: 2
            // The number of legs: 16
            //

            Console.Write("Please enter the number of chickens: ");
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the number of pigs: ");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int totalLegs = 2 * chickens + 4 * pigs;
            Console.WriteLine($"The number of legs is {totalLegs}.");
        }
    }
}

*/