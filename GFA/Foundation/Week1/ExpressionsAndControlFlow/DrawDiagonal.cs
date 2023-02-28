/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawDiagonal
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a square with the main diagonal of the specified size
            //
            // Example:
            //
            // Please enter the square size: 6
            // %%%%%%
            // %%   %
            // % %  %
            // %  % %
            // %   %%
            // %%%%%%
            //

            Console.Write("Please enter the square size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size < 1)
            {
                Console.WriteLine("Invalid size.");
            }
            else if (size == 1)
            {
                Console.WriteLine("%");
            }
            else
            {
                DrawDiagonalCLI(size);
            }

        }

        static void DrawDiagonalCLI(int size)
        {
            // Write your code to draw a square with the main diagonal here

            // First line
            for (int i = 0; i < size; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();


            // Side lines with diagonal line
            for (int i = 3; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j == 1)
                    {
                        // Left side
                        Console.Write("%");
                    }
                    else if (j == size)
                    {
                        // Right side
                        Console.Write("%");
                    }
                    else if (j == i - 1)
                    {
                        // Diagonal
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Last line
            for (int i = 0; i < size; i++)
            {
                Console.Write("%");
            }
        }
    }
}
*/ 