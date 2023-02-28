/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class DrawTriangle
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input and
            // then draws a triangle of the specified height
            //
            // Example:
            //
            // Please enter the triangle height: 4
            // *
            // **
            // ***
            // ****
            Console.Write("Please enter the triangle height: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            DrawTriangleCLI(lines);


        }

        static void DrawTriangleCLI(int height)
        {
            // Write your code to draw the triangle here
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
*/