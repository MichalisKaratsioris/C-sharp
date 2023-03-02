/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Foundation.Week2.DataStructures
{
    internal class ShoppingList1
    {
        public static void Main(string[] args)
        {
            //Create a list with the following items: eggs, milk, fish, apples, bread and chicken
            List<string> buy = new List<string>();

            buy.Add("eggs");
            buy.Add("milk");
            buy.Add("fish");
            buy.Add("apples");
            buy.Add("bread");
            buy.Add("chicken");

            //Create an application which prints out the answers to the following questions:
            //   - Do we have milk in the shopping list? (yes/no)
            //   - Do we have bananas in the shopping list? (yes/no)
            shoppingList(buy, "milk");
            shoppingList(buy, "bananas");
        }
        public static void shoppingList(List<string> list, string s)
        {
            bool belongs = false;
            foreach (string item in list)
            {
                if (item == s)
                {
                    belongs = true;
                }
            }

            if (belongs)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
*/