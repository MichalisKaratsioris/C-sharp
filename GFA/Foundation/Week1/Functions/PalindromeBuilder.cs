/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class PalindromeBuilder
    {
        public static void Main(string[] args)
        {
            //Create a function named createPalindrome() following your current language's style guide.
            // It should take a string, create a palindrome from it and then return it.

            string number = "123";
            Console.WriteLine(createPalindrome(number));

        }

        public static string createPalindrome(string s)
        {

            // here I add the initial string and the its reverse to create the palindrome.
            return s + reverseString(s);
        }

        public static string reverseString(string s)
        {
            char[] chars = new char[s.Length];
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                temp += s[s.Length - 1 - i];
            }
            return temp;
        }
    }
}
*/