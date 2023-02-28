/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class Anagram
    {
        static void Main(string[] args)
        {
            //    Create a function named isAnagram() following your current language's style guide.
            //    It should take two strings and return a boolean value depending on whether it's an anagram or not.

            string str1 = "now";
            string str2 = "own";

            if (isAnagram(str1, str2))
            {
                Console.WriteLine("They are anagrams!");
            }
            else
            {
                Console.WriteLine("They are not anagrams.");
            }

        }

        public static bool isAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                char[] char1Array = str1.ToLower().ToCharArray();
                Array.Sort(char1Array);
                char[] char2Array = str2.ToLower().ToCharArray();
                Array.Sort(char2Array);

                return new string(char1Array) == new string(char2Array);
            }
        }
    }
}
*/