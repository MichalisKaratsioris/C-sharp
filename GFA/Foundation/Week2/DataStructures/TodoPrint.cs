/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the `todoText`
            // Add " - Download games" to the end of the `todoText`
            // Add " - Diablo" to the end of the `todoText` applying indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            string todo = $"My todo:\n{todoText} - Download games\n\t- Diablo";
            Console.WriteLine(todo);

        }
    }
}
*/