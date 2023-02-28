/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Arrays
{
    internal class AppendA
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content:
            //   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr",
            //     "gorill", "hyen", "hydr", "iguan", "impal", "pum",
            //     "tarantul", "piranh"]`
            //
            // - Add an `"a"` at the end of all elements (use a loop!)
            // - Print the 'fixed' array to the console:
            //   [koala, panda, zebra, anaconda, boa, ..., tarantula, piranha]

            string[] animals = { "koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "piranh" };
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] += "a";
            }
            for (int i = 0; i< animals.Length; i++)
            {
                if (i < animals.Length - 1)
                {
                    Console.Write($"{animals[i]}, ");
                }
                else
                {
                    Console.Write($"{animals[i]}");
                }
            }
        }
    }
}
*/