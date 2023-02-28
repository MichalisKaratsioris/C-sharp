/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawChessTable
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a chess table of the specified size
            //
            // Example:
            //
            // Please enter the chess table size: 8
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %

            Console.Write("Please enter the chess table size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            DrawChessTableCLI(size);
        }

        static void DrawChessTableCLI(int lines)
        {
            // Write your code to draw the chess table here
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
*/