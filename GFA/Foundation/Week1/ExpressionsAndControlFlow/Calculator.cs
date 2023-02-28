/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.Write("Please provide the first number: ");

            // Get the first number:
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please provide the second number: ");

            // Get the second number:
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please provide the operation (add, subtract, multiply or divide): ");

            // Get the operation from standard input:
            string operation = Console.ReadLine();

            // use the `switch` statement and the corresponding calculation
            // store the result of the calculation in the `result` variable

            double result = 0.0;

            switch (operation) {
                case "add":
                    result = number1 + number2;
                    break;
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Invalid denominator. Try again!");
                        return;
                    }
                    result = number1 / (double) number2;
                    break;
                default:
                    Console.WriteLine("Invalid operation. Try again!");
                    return;
            }

            Console.WriteLine($"The result of the calculation is {result}");
        }
    }
}
*/