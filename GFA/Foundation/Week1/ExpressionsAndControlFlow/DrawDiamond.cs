/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawDiamond
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a diamond of the specified height
            //
            // Example:
            //
            // Please enter the diamond height: 4
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // Note: the height of the diamond is taken from its base
            // (where it is the widest) to the top.
            // The total number of lines produced is 2*height-1
            Console.Write("Please enter the diamond height: ");
            int h = Convert.ToInt32(Console.ReadLine());
            int lines = 2 * h - 1;

            DrawDiamondCLI(lines);
        }

        static void DrawDiamondCLI(int height)
        {
            // Write your code to draw the diamond here

            // Up part
            int upLines = (height + 1) / 2;

            for (int i = 0; i < upLines; i++)
            {

                // printing reduced number of spaces per row
                for (int j = i; j < upLines; j++)
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

            // Down part
            int downLines = (height - 1) / 2;


            for (int i = downLines; i > 0; i--)
            {

                // printing raising number of spaces per row
                for (int j = downLines + 2; j > i; j--)
                {
                    Console.Write(" ");
                }

                // printing reduced number of asterisks per row
                for (int k = 2 * (i - 1); k + 1 > 0; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
*/