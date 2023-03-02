/*

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class MapIntro1
    {
        public static void Main(string[] args)
        {
            //Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> map = new Dictionary<int, char>();

            //Print out whether the map is empty or not
            // Expected Output: True
            Console.WriteLine(map.Count == 0);

            //Add the following key-value pairs to the map
            // Key Value
            //  97  a
            //  98  b
            //  99  c
            //  65  A
            //  66  B
            //  67  C
            map[97] = 'a';
            map[98] = 'b';
            map[99] = 'c';
            map[65] = 'A';
            map[66] = 'B';
            map[67] = 'C';

            int counter = 0;
            //Print all the keys
            // Expected Output: [97, 65, 98, 66, 99, 67]
            foreach (int key in map.Keys)
            {
                if (counter == 0)
                {
                    Console.Write($"[{key},");
                    counter += 1;
                }
                else if (counter == map.Count - 1)
                {
                    Console.WriteLine($" {key}]");
                }
                else
                {
                    Console.Write($" {key},");
                    counter += 1;
                }
            }

            counter = 0;
            //Print all the values
            // Expected Output: [a, A, b, B, c, C]
            foreach (char value in map.Values)
            {
                if (counter == 0)
                {
                    Console.Write($"[{value},");
                    counter += 1;
                }
                else if (counter == map.Count - 1)
                {
                    Console.WriteLine($" {value}]");
                }
                else
                {
                    Console.Write($" {value},");
                    counter += 1;
                }
            }

            //Add value D with the key 68
            map[68] = 'D';

            //Print how many key-value pairs are in the map
            // Expected Output: 7
            Console.WriteLine(map.Count);

            //Print the value that is associated with key 99
            // Expected Output: c
            Console.WriteLine(map[99]);

            //Remove the key-value pair with key 97 and print the associated value
            // Expected Output: a
            Console.WriteLine(map[97]);
            map.Remove(97);

            //Print whether there is an associated value with key 100 or not
            // Expected Output: 
            Console.WriteLine(map.ContainsKey(100));

            //Remove all the key-value pairs
            map.Clear();

            //Print how many key-value pairs are in the map
            // Expected Output: 
            Console.WriteLine(map.Count);

        }
    }
}
*/