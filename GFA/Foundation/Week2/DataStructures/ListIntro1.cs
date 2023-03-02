/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class ListIntro1
    {
        public static void Main(string[] args)
        {
            //Create an empty list which will contain names (strings)
            List<string> names = new List<string>();

            //Print out the number of elements in the list
            //Expected Output: 0
            Console.WriteLine(names.Count());

            //Add "William" to the list
            names.Add("William");

            //Print out whether the list is empty or not
            //Expected Output: False
            Console.WriteLine(names.Count == 0);

            //Add "John" to the list
            names.Add("John");

            //Add "Amanda" to the list
            names.Add("Amanda");

            //Print out the number of elements in the list
            //Expected Output: 3
            Console.WriteLine(names.Count);

            //Print out the 3rd element
            //Expected Output: Amanda
            Console.WriteLine(names[2]);

            //Iterate through the list and print out each name
            //Expected Output:
            //William
            //John
            //Amanda
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            //Iterate through the list and print each element with its position in the list.
            //Expected Output:
            //1. William
            //2. John
            //3. Amanda
            foreach (string s in names)
            {
                Console.WriteLine($"{names.IndexOf(s) + 1}. {s}");
            }

            //Remove the 2nd element
            names.RemoveAt(1);

            //Iterate through the list in a reversed order and print out each name
            //Expected Output:
            //Amanda
            //William
            for (int i = names.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            //Remove all elements
            names.Clear();

            //Print out the number of elements in the list
            //Expected: 0
            Console.WriteLine(names.Count);
            
        }
    }
}
*/