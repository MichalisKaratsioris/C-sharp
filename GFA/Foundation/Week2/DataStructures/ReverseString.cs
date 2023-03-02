/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a string which is passed as a parameter
            // The method should return the reversed string
            // Pass the `toBeReversed` variable to this method to check if it works well
            // At first, solve this task using the `String.Chars[Int32]` property, e.g. `toBeReversed[0]`
            // Try other solutions when you are done

            Console.WriteLine(Reverse(toBeReversed));
        }

        public static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
*/