/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads parameters from the prompt and prints the result back.
            // The calculator should support the following operators: +, -, *, /, %
            // The format of the input expressions must be: {operator} {operand} {operand}
            // Input examples:
            //    "+ 3 3" (the result will be 6)
            //    "* 4 4" (the result will be 16)
            //    "/ 4 3" (the result will be 1)
            //
            // In the division (/) case, the result should be a whole number, e.g. 20 / 8 = 2, 10 / 3 = 3, etc.

            // To make it work use `Console.ReadLine` to get input from the user. Create a method named `Calculate()`
            // and pass the input as a parameter into it. The method should return a result of the calculation as an
            // integer.
            //
            // The process should work like this:
            // - Start the program
            // - Print: "Please type in the expression:" using Console.WriteLine
            //   (Wait for the user input)
            // - After receiving the input print the result number to the prompt
            // - Exit the program

            // Input & Output
            //
            // Please type in the expression:
            // + 10 3
            // 13

            Console.WriteLine("The format of an expression should be:\n - First enter the operation " +
                "(+, -, *, /, %)\n - Then add the two numbers separated by space, i.e. + 1 10");
            Console.Write("Please type in the expression: ");
            string input = Convert.ToString(Console.ReadLine());

            string[] expression = input.Split(" ");
            string nums = "1234567890";
            string opers = "+-*\/% ";

            if (expression.Length != 3 
                || !opers.Contains(expression[0]) 
                || !nums.Contains(expression[1])
                || !nums.Contains(expression[2]))
            {
                Console.WriteLine("Input invalid. Try again.");
            }
            else
            {
                Console.WriteLine(Calculate(expression));
                //Calculate(expression);
            }
        }

        public static int Calculate(string[] input)
        {
            // extracting the elements of input
            string operation = input[0];
            int numA = Convert.ToInt32(input[1]);
            int numB = Convert.ToInt32(input[2]);

            // calculating the result
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
                case "%":
                    result = numA % numB;
                    break;
            }
            return result;
        }
    }
}
*/