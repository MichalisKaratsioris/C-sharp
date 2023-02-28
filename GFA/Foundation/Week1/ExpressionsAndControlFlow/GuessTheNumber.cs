/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class GuessTheNumber
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number and the user has to
            // figure it out. The user can input guesses. After each guess
            // the program responds with a message indicating whether the stored
            // number is smaller or greater than the guess.
            // The program ends (exits) when the user finds the stored number.
            //
            // Example:
            //
            // Please enter your guess: 3
            // The stored number is greater than 3
            // Please enter your guess: 10
            // The stored number is smaller than 10
            // Please enter your guess: 8
            // You have found the stored number 8
            //
            Console.Write("Guess my number (1-100): ");
            int storedNumber = 5;
            int guess = 0;
            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess != storedNumber)
                {
                    if (guess < storedNumber)
                    {
                        Console.WriteLine($"The stored number is greater than {guess}");
                    }
                    else
                    {
                        Console.WriteLine($"The stored number is smaller than {guess}");
                    }
                }
                else
                {
                    Console.WriteLine($"You have found the stored number {storedNumber}");
                }
            } while (guess != storedNumber);




        }
    }
}
*/