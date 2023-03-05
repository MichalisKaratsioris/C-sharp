using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonCharacters
{
    class MostCommonCharacter
    {
        /*Write a function named getTwoMostCommonCharacters that takes a filename as a parameter, 
         * and returns the 2 most common characters and their occurrences in the file's content.
         * C#: return a Dictionary
         * If the file does not exist throw an exception with the following message: "File does not exist!"
         * Note: If there is more than one character with the same occurrence, you can return any one of those.
         * For example, if 'a', 'b', and 'c' each occur 8-times, you can return any two combination of them,
         * i.e. (a,b), (a,c), or (b,c).
         */

        public static void Main(string[] args)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\countchar.txt");
            string path = Path.GetFullPath(sFile);
            //string path = @"C:\Users\mkara\Desktop\GitHub\huli-csharp-trial-exam\countchar.txt";
            StringBuilder sb = new StringBuilder();

            // Reads the content from `countchar.txt` in the line by line to a string List
            try
            {
                string[] content = File.ReadAllLines(path);

                // Create one single string.
                foreach (string line in content)
                {
                    sb.Append(line);
                }
            }
            catch (Exception) // In case the file does not exist
            {
                throw new ArgumentException("File does not exist!");
            }
            //Console.WriteLine(sb.ToString());
            Dictionary<char, int> results = CommonalityAgain(sb.ToString());

            // Print the results
            foreach (KeyValuePair<char, int> pair in results)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static Dictionary<char, int> CommonalityAgain(string file)
        {
            /*  -   params:     string file
             *  -   returns:    Dictionary<char, int>
             * 
             * The function goes through the following steps:
             * 1.   Creates a dictionary (charCounts) with the frequency of occurence for 
             *      each character present in "file".
             * 2.   Creates a list (sortedCharCounts) in which the key-value pairs from
             *      charCounts are sorted (descending order) according to their Values.
             * 3.   Creates another dictionary (result) to save the most occuring characters among
             *      their frequencies.
             * 4.   Returns the dictionary "result".
             */

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in file)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            List<KeyValuePair<char, int>> sortedCharCounts = charCounts.ToList();
            sortedCharCounts.Sort((x, y) => y.Value.CompareTo(x.Value));

            Dictionary<char, int> result = new Dictionary<char, int>();

            int count = 0;
            foreach (KeyValuePair<char, int> pair in sortedCharCounts)
            {
                result[pair.Key] = pair.Value;
                count++;

                if (count >= 2)
                {
                    break;
                }
            }
            return result;
        }
    }
}











































































































































































































































































// Created by Michalis Karatsioris