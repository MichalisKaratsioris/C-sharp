/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawSquare
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a square of the specified size
            //
            // Example:
            //
            // Please enter the square size: 6
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
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
                DrawSquareCLI(size);
            }
        }

        static void DrawSquareCLI(int size)
        {
            // Write your code to draw the square here

            // First line
            for (int i = 0; i < size; i++)
            {
                Console.Write("%");
            }
            Console.WriteLine();

            // Side lines
            for (int i = 1; i <= size - 2; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j == 1)
                    {
                        // left side
                        Console.Write("%");
                    }
                    else if (j == size)
                    {
                        // right side
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