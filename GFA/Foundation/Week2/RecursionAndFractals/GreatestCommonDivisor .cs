/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class GreatestCommonDivisor
    {
        public static void Main()
        {
            // Find the greatest common divisor of two numbers using recursion.

            int x = 50;
            int y = 40;
            Console.WriteLine(GCD(x, y));
        }

        public static int GCD(int n, int m)
        {
            if (n == 0 || m == 0)
            {
                return n;
            }
            else
            {
                return GCD(m, n % m);
            }
        }

    }
}
*/