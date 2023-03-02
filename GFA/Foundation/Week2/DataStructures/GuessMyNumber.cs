/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class GuessMyNumber
    {
        public static void Main(string[] args)
        {
            // Write a program that stores a number and the user has to figure it out
            // The user can input guesses
            // After each guess the program would tell one of the following:
            //
            // The stored number is higher
            // The stored number is lower
            // You found the number: 8


            /*
            // Expected Input/Output

            int number = 5;
            Console.WriteLine("Guess my number!");
            int guess = 0;
            
            do
            {
                guess = Int32.Parse(Console.ReadLine());
                if (guess != number)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("The stored number is lower");
                    }
                    else
                    {
                        Console.WriteLine("The stored number is higher");
                    }
                }
                else
                {
                    Console.WriteLine($"You found the number: {guess}");
                }
            } while (guess != number);
            */
            /*
            // Expected Input/Output - Customizable Range

            Console.Write("Please enter the min of the guess range: ");
            int min = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter the max of the guess range: ");
            int max = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Guess a number between {min} and {max}");
            Random rnd = new Random();
            int number = rnd.Next(min - 1, max + 1);
            int guess = 0;

            do
            {
                guess = Int32.Parse(Console.ReadLine());
                if (guess != number)
                {
                    if (guess > number)
                    {
                        Console.WriteLine("Too high. Try again:");
                    }
                    else
                    {
                        Console.WriteLine("Too low. Try again:");
                    }
                }
                else
                {
                    Console.WriteLine($"Congratulations. You've won!");
                }
            } while (guess != number);
            */
            /*
            // Expected Input/Output - Customizable Range & Lives

            Console.Write("Please enter the min of the guess range: ");
            int min = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter the max of the guess range: ");
            int max = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Guess a number between {min} and {max}");

            Random rnd = new Random();
            int lives = rnd.Next((int) (2 * Math.Log(max)), (int)(3 * Math.Log(max)));
            Console.WriteLine($"You start with {lives} lives!");

            int number = rnd.Next(min - 1, max + 1);
            int guess = 0;

            do
            {
                if (lives == 0)
                {
                    Console.WriteLine($"Sorry, but you have no more lives. Thank you for playing!");
                    break;
                }
                else
                {
                    guess = Int32.Parse(Console.ReadLine());
                    if (guess != number)
                    {
                        lives--;
                        if (guess > number)
                        {
                            Console.WriteLine($"Too high. You have {lives} lives. Try again:");
                        }
                        else
                        {
                            Console.WriteLine($"Too low. You have {lives} lives. Try again:");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations. You've won!");
                    }
                }
            } while (guess != number);

        }
    }
}
*/