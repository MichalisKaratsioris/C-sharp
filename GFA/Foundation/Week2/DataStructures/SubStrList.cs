/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class SubStrList
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string (`needle`) and a list of strings (`haystack`) as parameters
            //  and returns the index of the list element which contains the `needle` as a substring.
            //  You only need to find the first occurrence and return that index. The search should be case-sensitive!
            //  Return `-1` if none of the items in the list contain the `needle`.

            //  Example

            string[] haystack = { "this", "is", "what", "I'm", "searching", "in" };

            // Expected output: 4
            Console.WriteLine(FindIndex("ching", haystack));

            // Expected output: -1
            Console.WriteLine(FindIndex("not", haystack));
        }

        public static int FindIndex(string s, string[] sList)
        {
            int count = 0;
            foreach (string element in sList)
            {
                if (element.Contains(s))
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

    }
}
*/