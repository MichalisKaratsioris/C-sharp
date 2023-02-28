/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Functions
{
    internal class PalindromeSearcher
    {
        public static void Main(string[] args)
        {
            // Create a function named searchPalindrome() following your current language's style guide.
            // It should take a string, search for palindromes that are at least 3 characters long and
            // return a list with the found palindromes.

            string phrase = "dog goat dad duck doodle never";
            solution(phrase);
        }
        public static void solution(string s)
        {
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 3; j <= s.Length; j++)
                {
                    // i -> starting point of substring, j-> ending point of substring
                    if (isPalindrome(s.Substring(i, j - i)))
                    {
                        index++;
                    }
                }
            }

            string[] solution = new string[index];
            index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 3; j <= s.Length; j++)
                {
                    // i -> starting point of substring, j-> ending point of substring
                    if (isPalindrome(s.Substring(i, j - i)))
                    {
                        solution[index] = s.Substring(i, j - i);
                        index++;
                    }
                }
            }
            Console.WriteLine(string.Join(string.Empty, solution));
        }
        public static bool isPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
*/