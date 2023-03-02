/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.RecursionAndFractals
{
    internal class Strings
    {
        public static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
            //string phrase = "XxXxX is a strange thing to writeXxXxX";
            //string phrase = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            string phrase = "No small x's here to change";
            //string phrase = "No small X's here to change";
            Console.WriteLine(ChangeXToY(phrase));
        }

        public static string ChangeXToY(string s)
        {
            if (s.Length <= 1)
            {
                return s.Replace("x", "y");
            }
            else
            {
                return $"{s[0]}".Replace("x", "y") + ChangeXToY(s.Substring(1));
            }
        }

    }
}
*/