/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawPyramid
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a pyramid of the specified height
            //
            // Example:
            //
            // Please enter the pyramid height: 4
            //    *
            //   ***
            //  *****
            // *******
            Console.Write("Please enter the pyramid height: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            DrawPyramidCLI(lines);

        }

        static void DrawPyramidCLI(int height)
        {
            // Write your code to draw the pyramid here
            for (int i = 0; i < height; i++)
            {
                // printing reduced number of spaces per row
                for (int j = i; j < height; j++)
                {
                    Console.Write(" ");
                }

                // printing raising number of asterisks per row
                for (int k = 1; k < 2 * (i + 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

*/