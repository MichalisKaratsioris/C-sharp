/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };

            // "Saturn" is missing from the planetList
            // Insert it into the correct position
            // Create a method called "putSaturn()" which has a list parameter and returns
            // the list of planets in the correct order

            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"
            Console.WriteLine(PutSaturn(planetList));
        }

        public static string PutSaturn(List<string> list)
        {
            list.Insert(5, "Saturn");
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (string planet in list)
            {
                if (count < list.Count - 1)
                {
                    sb.Append($"\"{planet}\", ");
                    count++;
                }
                else
                {
                    sb.Append($"\"{planet}\"");
                    count++;
                }
            }
            string result = Convert.ToString(sb);
            return result;
        }

    }
}
*/