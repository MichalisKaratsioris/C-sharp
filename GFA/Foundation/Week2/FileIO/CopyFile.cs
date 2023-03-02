/*

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Foundation.Week2.FileIO
{
    internal class CopyFile
    {
        public static void Main(string[] args)
        {
            // Write a function that copies the contents of a file into another file
            // It should take two filenames (string) as parameters:
            //  - path and name of the source file
            //  - path and name of the target file
            // It should return a boolean that shows if the copy was successful

            string sourceFile = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file.txt";
            //string destFile = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileIO/my-file1.txt";
            string destFile = @"C:/Users/mkara/Desktop/GitHub/C-sharp/GFA/Foundation/Week2/FileI0/my-file1.txt";
            Console.WriteLine(copyFile(sourceFile, destFile));
        }
        public static bool copyFile(string s, string d)
        {
            try
            {
                File.Copy(s, d, true);
                return true;
            }
            catch (IOException e)
            {
                return false;
            }
        }
    }
}
*/