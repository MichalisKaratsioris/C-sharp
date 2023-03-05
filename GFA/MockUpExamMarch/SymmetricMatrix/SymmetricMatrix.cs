using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricMatrix
{
    class SymmetricMatrix
    {

        /* Create a function named isSymmetric that takes an n×n integer matrix (two dimensional array) as 
         * a parameter and returns true if the matrix is symmetric or false if it is not.
         * Symmetric means it has identical values along its diagonal axis from top-left to bottom-right
        */

        public static void Main(string[] args)
        {
            // Example 1: Expected Output: True
            //int[,] matrix = { { 1, 0, 1 }, { 0, 2, 2 }, { 1, 2, 5 } };

            // Example 2: Expected Output: False
            //int[,] matrix = { { 7, 7, 7 }, { 6, 5, 7 }, { 1, 2, 1 } };

            // Example 3: Expected Output: True
            //int[,] matrix = { { 1, 2, 3 }, { 2, 4, 5 }, { 3, 5, 6 } };

            // Example 4: Expected Output: False
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(IsSymmetricOrNotThisIsTheQuestion(matrix));
        }

        private static bool IsSymmetricOrNotThisIsTheQuestion(int[,] m)
        {
            /*  -   params:     int[,] m
             *  -   returns:    boolean
             *  
             * The method goes through the upper half of the nxn matrix
             * and compare it with the lower half, i.e. when
             * i = 0, j will start from 1 and the first comparison
             * will be m[0, 1] != m[1, 0]. If this element is not
             * equal, then immediately the function will return
             * false. If the 2 for-loops go through all the n*(n-1)/2
             * elements without returning false, then will exit
             * the for-loops and return true.
             */
        int n = m.GetLength(0);
            for (int i = 0; i < n; i++) // going through each row
            {
                for (int j = i + 1; j < n; j++) // checking only the elements above the diagonal
                {
                    if (m[i, j] != m[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}



















































































































































































































































































































// Created by Michalis Karatsioris