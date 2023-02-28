/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class Unique
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an array of integers as a parameter
            //  and returns an array of integers where every integer is unique (occurs only once)

            //  Example
            //Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
            //  should print: `[1, 11, 34, 52, 61]`

            //int[] numbers = { 1, 11, 34, 11, 52, 61 };
            int[] numbers = { 1, 11, 34, 11, 52, 61, 1, 34, 11, 55, 52 };

            for (int i = 0; i < FindUniqueItems(numbers).Length; i++)
            {
                if (i < FindUniqueItems(numbers).Length - 1)
                {
                    Console.Write($"{FindUniqueItems(numbers)[i]}, ");
                }
                else
                {
                    Console.Write($"{FindUniqueItems(numbers)[i]}");
                }
            }
        }

        public static int[] FindUniqueItems(int[] n)
        {
            int indices = 0;
            Array.Sort(n);
            for (int i = 0; i < n.Length - 1; i++)
            {
                if (n[i] != n[i + 1])
                {
                    indices++;
                }
            }
            if (n[n.Length - 2] != n[n.Length - 1])
            {
                indices++;
            }


            int[] uniqueArray = new int[indices];
            int index = 0;
            for (int i = 0; i < n.Length - 1; i++)
            {
                if (n[i] != n[i + 1])
                {
                    uniqueArray[index] = n[i];
                    index++;
                }
            }
            if (n[n.Length - 2] != n[n.Length - 1])
            {
                uniqueArray[uniqueArray.Length - 1] = n[n.Length - 1];
            }
            return uniqueArray;
        }

    }
}
*/