/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class SubInt
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number (a digit) and an array
            // of integers as parameters and returns the indices of the integers
            // in the array which contain the given digit or returns an empty
            // array (if no number in the array contains the given digit)

            //  Example:
            //Console.WriteLine(FindMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            //Console.WriteLine(FindMatchingIndexes(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            //int[] numbers = { 1, 11, 34, 52, 61 };
            //int target = 1;

            int[] numbers = { 1, 11, 34, 52, 61 };
            int target = 9;


            hasTheDigit(numbers, target);

        }

        public static void hasTheDigit(int[] n, int t)
        {
            int indices = 0;

            // Check all numbers one by one to find out how big will be the final array.

            for (int i = 0; i < n.Length; i++)
            {
                // checking for digit
                if (n[i] == t || isDigitPresent(n[i], t))
                {
                    indices++;
                }
            }

            if (indices == 0)
            {
                Console.WriteLine("[]");
            }

            // Save the elements from the original array to the final array.
            int[] matchingIndices = new int[indices];
            int index = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == t || isDigitPresent(n[i], t))
                {
                    matchingIndices[index] = n[i];
                    index++;
                }
            }

            // Shifting the values inside the final array, to their indices in the original array.
            for (int i = 0; i < matchingIndices.Length; i++)
            {
                for (int j = 0; j < n.Length; j++)
                {
                    if (matchingIndices[i] == n[j])
                    {
                        matchingIndices[i] = j;
                    }
                }
            }

            for (int i = 0; i < matchingIndices.Length; i++)
            {
                if (i < matchingIndices.Length - 1)
                {
                    Console.Write($"{matchingIndices[i]}, ");
                }
                else
                {
                    Console.Write($"{matchingIndices[i]}");
                }
            }
        }

        public static bool isDigitPresent(int x, int d)
        {
            // Break loop if d is present as digit
            while (x > 0)
            {
                if (x % 10 == d)
                {
                    break;
                }
                x /= 10;
            }
            return (x > 0);
        }

    }
}
*/