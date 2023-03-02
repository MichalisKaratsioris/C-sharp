/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class Power
    {
        public static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            int b = 2;
            int n = 5;
            Console.WriteLine(Exponent(b, n));
        }

        public static int Exponent(int baseNumber, int exp)
        {
            if (baseNumber < 1 || exp <=0)
            {
                return 1;
            }
            else
            {
                return baseNumber * Exponent(baseNumber, exp - 1);
            }
        }

    }
}
*/