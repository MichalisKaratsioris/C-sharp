/*

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1.Arrays
{
    internal class DiagonalMatrix
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer n,
            // then it creates a two-dimensional array (of integers)
            // of the specified size (nxn) with the value of 1
            // on the main diagonal and the value of 0 everywhere else.
            // Print the 2d array into the output
            //
            // Example:
            //
            // Please enter the array (matrix) size: 4
            // 1 0 0 0
            // 0 1 0 0
            // 0 0 1 0
            // 0 0 0 1

            Console.Write("Please enter the array (matrix) size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = CreateMatrix(size);
            Print(matrix);
        }

        private static int[,] CreateMatrix(int size)
        {
            // write your code to create an nxn matrix
            // of the given size here

            int[,] m = new int[size, size];
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        m[i,j] = 1;
                    }
                    else
                    {
                        m[i,j] = 0;
                    }
                }
            }
            return m;
        }

        static void Print(int[,] matrix)
        {
            // write your code to print the given matrix
            // into the (standard) output here
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/