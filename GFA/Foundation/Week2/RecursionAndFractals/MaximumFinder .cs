/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class MaximumFinder
    {
        public static void Main(string[] args)
        {
            // Write a function which returns the largest element of an array using recursion.

            int[] nums = { 86432, 407, 45, 6, -50, -6410, 404 };
            Console.WriteLine(MaxFinder(nums, nums.Length));
        }

        public static int MaxFinder(int[] n, int nLength)
        {
            if (nLength == 0)
            {
                return -1;
            }
            else if (nLength == 1)
            {
                return n[0];
            }
            else
            {
                return Math.Max(n[nLength - 1], MaxFinder(n, nLength - 1));
            }
        }
    }
}
*/