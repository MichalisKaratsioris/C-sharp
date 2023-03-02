/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class Strings2
    {
        public static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            string phrase = "xxxxTxxhxxixsxxxx xxxpxxxxxxxxxxxxxxxxxxxxhxxxxrxxxaxsxexxxxxx xixsxxxx xxxXxx xxxxfxrxexxexxxxxxxxxxxxxx";
            Console.WriteLine(RemoveX(phrase));
        }

        public static string RemoveX(string s)
        {
            if (s.Length <= 1)
            {
                return s.Replace("x", "");
            }
            else
            {
                return $"{s[0]}".Replace("x", "") + RemoveX(s.Substring(1));
            }
        }
    }
}
*/