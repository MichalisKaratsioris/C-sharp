/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class JosephusProblem
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the number of players: ");
            int numberOfPlayers = Int32.Parse(Console.ReadLine());

            Console.WriteLine(getWinningSeat(numberOfPlayers));
        }

        public static int getWinningSeat(int n)
        {
            // N = 2^(a) + b  ==>  W(N) = 2*b + 1

            int a = 0;

            // Find the greatest power of 2 that fits inside the given number
            for (int i = 0; i < n; i++)
            {
                if (n < Math.Pow(2.0, i + 1))
                {
                    a = i;
                    break;
                }
            }

            // The winning seat
            int b = (int)(2 * (n - Math.Pow(2, a)) + 1);

            return b;
        }
    }
}
*/