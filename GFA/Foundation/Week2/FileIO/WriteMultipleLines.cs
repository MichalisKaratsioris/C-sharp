/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.FileIO
{
    internal class WriteMultipleLines
    {
        public static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // - The path parameter should be a string that describes the location (path & name)
            //    of the file you wish to modify.
            // - The word parameter should also be a string that will be written to the file as individual lines.
            // - The number parameter should describe how many lines the file should have.

            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'.
            // The function should not raise any errors if it could not write the file.

            string path = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file3.txt";
            //string path = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileI0/my-file3.txt"; //wrong path...
            int lines = 5;
            string word = "apple";
            writeFile(word, path, lines);
        }
        public static void writeFile(string fileContent, string filePath, int number)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int lines = 0;
                    while (lines < number)
                    {
                        writer.WriteLine($"{fileContent}");
                        lines++;
                    }
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }
    }
}
*/