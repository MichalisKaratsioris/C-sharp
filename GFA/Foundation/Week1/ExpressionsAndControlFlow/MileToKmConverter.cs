/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week1
{
    internal class MileToKmConverter
    {
        static void Main(string[] args)
        {
            // Write a program which prompts the user for a double value
            // specifying a distance in miles, converts that value
            // to kilometers and prints it
            //
            // Example:
            //
            // Please enter a distance in miles: 1.8
            // The distance in km: 2.88
            //

            Console.Write("Please provide the distance in miles:");
            string miles = Console.ReadLine();
            double milesToKm = 1.60934 * Convert.ToDouble(miles);

            Console.WriteLine($"{miles} miles equals to {milesToKm} km.");
        }
    }
}
*/