/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class Bubble
    {
        public static void Main(string[] args)
        {
            //  Create a function that takes an array of numbers as parameter
            //  and returns an array where the elements are sorted in ascending numerical order
            //  When you are done, add a second boolean parameter to the function
            //  If it is `true` sort the array descending, otherwise ascending

            //  Example:
            //  System.out.println(bubble(new int[] {34, 12, 24, 9, 5}));
            //  should print [5, 9, 12, 24, 34]
            //  System.out.println(advancedBubble(new int[] {34, 12, 24, 9, 5}, true));
            //  should print [34, 24, 12, 9, 5]

            int[] integers = { 1, 105, 34, 12, 24, 9, 5 };
            bubble(integers);
            //bubble(integers, false);
            //bubble(integers, true);

        }
        public static void bubble(int[] arrayInt)
        {
            Array.Sort(arrayInt);
            Console.WriteLine(string.Join(" ", arrayInt));
        }

        public static void bubble(int[] arrayInt, bool b)
        {
            if (!b)
            {
                Array.Sort(arrayInt);
            }
            else
            {
                int[] swapNumbers = new int[arrayInt.Length];
                Array.Copy(arrayInt, 0, swapNumbers, 0, arrayInt.Length);
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    for (int j = 0; j < arrayInt.Length - i; j++)
                    {
                        arrayInt[i] = swapNumbers[j];
                    }
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(string.Join(" ", arrayInt));
        }
    }
}
*/