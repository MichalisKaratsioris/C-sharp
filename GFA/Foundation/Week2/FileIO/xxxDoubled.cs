/*

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foundation.Week2.FileIO
{
    internal class Doubled
    {
        public static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt

            string file = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/duplicated-chars.txt";
            decryptDouble(file);

        }

        private static void decryptDouble(string cipher)
        {
            // Read lines from file and store them in a List
            string[] encryptedLines = File.ReadAllLines(cipher);

            // Analyzing the input file:
            // (i) line by line,
            // (j) word by word
            // and storing the resulting string-lines into a new List.


            List<string> decryptedLines = new List<string>();
            foreach (string line in encryptedLines)
            {
                string[] encryptedLine = line.Split(" ");
                foreach (string s in encryptedLine)
                {
                    decryptedLines.Add($"{decryptWord(s)} ");
                }
                decryptedLines.Add("\n");
            }

            foreach (string line in decryptedLines)
            {
                Console.WriteLine(line);
            }

            //Take the decrypted list and write it into an output file
            string output = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/decrypted-duplicated-chars.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(output))
                {
                    foreach (string line in decryptedLines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not found");
            }
        }

        public static string decryptWord(string s)
        {
            string[] encryptedWord = new string[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                encryptedWord[i] = $"{s[i]}";
            }

            for (int i = 0; i < encryptedWord.Length - 1; i++)
            {
                if (encryptedWord[i].Equals(encryptedWord[i + 1]))
                {
                    encryptedWord[i + 1] = "";
                }
            }

            string decryptedWord = String.Empty;
            foreach (string c in encryptedWord)
            {
                if (!Object.Equals(c, " "))
                {
                    decryptedWord += s;
                }
            }
            return decryptedWord;
        }
    }
}
*/