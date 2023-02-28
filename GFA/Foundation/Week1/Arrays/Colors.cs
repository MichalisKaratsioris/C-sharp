/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Arrays
{
    internal class Colors
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array (of strings)
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
            // - Print the array in the following format:
            //
            //   lime, forest green, oline, pale green, spring green
            //   orange red, red, tomato
            //   orchid, violet, pink, hot pink
            //

            string[][] colors = new string [][]{new string[] {"lime", "forest green", "olive", "pale green", "spring green"},
                new string[] {"orange red", "red", "tomato"},
                new string[] {"orchid", "violet", "pink", "hot pink"}};

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < colors[i].Length; j++)
                {
                    if (j != colors[i].Length - 1)
                    {
                        Console.Write($"{colors[i][j]}, ");
                    }
                    else
                    {
                        Console.Write($"{colors[i][j]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
*/