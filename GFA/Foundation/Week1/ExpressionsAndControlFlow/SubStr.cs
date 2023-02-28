/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class SubStr
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one
            
            Console.Write("Please enter the first string: ");
            string s1 = Console.ReadLine();

            Console.Write("Please enter the second string: ");
            string s2 = Console.ReadLine();

            Console.WriteLine(Substr(s1, s2));
            
            //  Example:

            //  should print: `17`
            //Console.WriteLine(Substr("this is what I'm searching in", "searching"));

            //  should print: `-1`
            //Console.WriteLine(Substr("this is what I'm searching in", "not"));
        }

        static int Substr(string input, string q)
        {
            int indexSubstring = input.IndexOf(q);
            return indexSubstring;
        }
    }
}
*/