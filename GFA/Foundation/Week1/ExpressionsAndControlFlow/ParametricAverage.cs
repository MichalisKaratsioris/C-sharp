/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class ParametricAverage
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input.
            // Next, the program will prompt the user to enter as many numbers
            // as the value of the first number the user entered.
            // Once the user enters all numbers the program will print
            // their sum and average.
            //
            // Example:
            //
            // How many numbers would you like to enter: 6
            // Enter number 1 of 6: 2
            // Enter number 2 of 6: 3
            // Enter number 3 of 6: 7
            // Enter number 4 of 6: 9
            // Enter number 5 of 6: 11
            // Enter number 6 of 6: 0
            // Sum: 32, Average: 5.333333333333333
            //

            Console.Write("How many numbers would you like to enter: ");
            int nums = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= nums; i++)
            {
                Console.Write($"Enter number {i} of {nums}: ");
                s += Convert.ToInt32(Console.ReadLine());
            }
            double avg = s / (double) nums;
            Console.WriteLine($"Sum: {s}, Average: {avg}");
        }
    }
}
*/