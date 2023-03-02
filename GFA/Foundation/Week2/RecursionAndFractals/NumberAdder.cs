/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class NumberAdder
    {
        public static void Main(string[] args)
        {
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            int number = 10;
            Console.WriteLine(Adder(number));
        }

        public static int Adder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + Adder(n - 1);
            }
        }

    }
}
*/