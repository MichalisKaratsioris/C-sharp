/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class SumDigits
    {
        public static void Main(string[] args)
        {
            // Given a non-negative integer n, return the sum of its digits recursively (without loops).
            int n = 123456789;
            Console.WriteLine(SummationDigits(n));
        }

        public static int SummationDigits(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + SummationDigits(n / 10);
            }
        }

    }
}
*/