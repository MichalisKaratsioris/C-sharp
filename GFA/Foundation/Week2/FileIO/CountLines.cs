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
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            string path = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file.txt";
            //string path = "C:\\Users\\mkara\\Desktop\\GitHub\\C-sharp\\GFA\\Foundation\\Week2\\FileIO\\my-file.txt";
            //string path = "C:\\Users\\mkara\\Desktop\\GitHub\\C-sharp\\GFA\\Foundation\\Week2\\FileIO\\my-file1.txt";

            try
            {
                // Reads the content from `lorem-psum.txt` in the `assets` folder line by line to a string List
                string[] content = File.ReadAllLines(path);
                // Prints the first line of the file
                int count = 0;
                foreach (string line in content)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
            catch (Exception)
            {
                Console.WriteLine(0);
            }
        }
    }
}
*/