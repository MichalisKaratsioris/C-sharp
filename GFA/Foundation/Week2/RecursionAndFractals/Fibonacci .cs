/*

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class Fibonacci
    {
        public static void Main(string[] args)
        {
            // The fibonacci sequence is a famous bit of mathematics, and it happens to have a recursive definition.
            // The first two values in the sequence are 0 and 1 (essentially 2 base cases). Each subsequent value is
            // the sum of the previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21 and so on.

            // Define a recursive fibonacci(n) method that returns the nth fibonacci number, with n = 0 representing
            // the start of the sequence.

            //int n = 3; // Expected output: 2
            //int n = 6; // Expected output: 8
            //int n = 7; // Expected output: 13
            int n = 10; // Expected output: 55
            Console.WriteLine(FibonacciGenerator(n));
        }

        public static int FibonacciGenerator(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return number;
            }
            else
            {
                return FibonacciGenerator(number - 1) + FibonacciGenerator(number - 2);
            }
        }
    }
}
*/