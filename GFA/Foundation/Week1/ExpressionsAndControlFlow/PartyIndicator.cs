/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class PartyIndicator
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to
            // a party, the second represents the number of boys
            //
            // If the number of girls and boys are equal and 20 or more people
            // are coming to the party, it should print: The party is excellent!
            //
            // If there are 20 or more people coming to the party but
            // the girl - boy ratio is not 1-1,
            // it should print: Quite a cool party!
            //
            // If there are fewer than 20 people coming,
            // it should print: Average party...
            //
            // If no girls are coming, regardless the count of the people,
            // it should print: Sausage party
            //
            // Please enter the number of girls: 15
            // Please enter the number of boys: 25
            // Quite a cool party!

            Console.Write("Please enter a number of girls: ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number of boys: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int total = g + b;

            if (g == b && total >= 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (g == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if (g != b && total >= 20)
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if (total < 20)
            {
                Console.WriteLine("Average party...");
            }
        }
    }
}
*/