/*

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.FileIO
{
    internal class WriteSingleLine
    {
        public static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // by writing your name into it as a single line.
            // The file should be named "my-file.txt".
            // In case the program is unable to write the file,
            // it should print the following error message: "Unable to write file: my-file.txt".


            string path = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file2.txt";
            string[] words = { "Michalis", "Karatsioris" };
            writeFile(words, path);
        }
        public static void writeFile(string[] s, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string w in s)
                    {
                        writer.WriteLine(w);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to write file: my-file2.txt");
            }
        }
    }
}
*/