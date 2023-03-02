/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.FileIO
{
    internal class PrintEachLine
    {
        public static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string path = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file.txt";
            //string path = "C:\\Users\\mkara\\Desktop\\GitHub\\C-sharp\\GFA\\Foundation\\Week2\\FileIO\\my-file.txt";
            //string path = "C:\\Users\\mkara\\Desktop\\GitHub\\C-sharp\\GFA\\Foundation\\Week2\\FileIO\\my-file1.txt";

            try
            {
                // Reads the content from `lorem-psum.txt` in the `assets` folder line by line to a string List
                string[] content = File.ReadAllLines(path);
                // Prints the first line of the file
                foreach (string line in content)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}
*/