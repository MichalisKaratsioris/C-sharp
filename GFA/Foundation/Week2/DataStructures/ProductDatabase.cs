/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Foundation.Week2.DataStructures
{
    internal class ProductDatabase
    {
        public static void Main(string[] args)
        {
            //Create a map with the following key - value pairs:
            //
            //            Product name (key)	Price (value)
            //                    Eggs	        200
            //                    Milk	        200
            //                    Fish	        400
            //                    Apples	    150
            //                    Bread	        50
            //                    Chicken	    550

            Dictionary<string, int> pricesMap = new Dictionary<string, int>();
            pricesMap["Eggs"] = 200;
            pricesMap["Milk"] = 200;
            pricesMap["Fish"] = 400;
            pricesMap["Apples"] = 150;
            pricesMap["Bread"] = 50;
            pricesMap["Chicken"] = 550;

            //Create an application which prints out the answers to the following questions:
            //  -  How much is the fish?
            costItem(pricesMap, "Fish");

            //  -  What is the most expensive product?
            compareItems(pricesMap, "most expensive");

            //  -  What is the average price?
            averagePrice(pricesMap);

            //  -  How many products' price is below 300?
            numProductsBelowLimit(pricesMap, 300);

            //  -  Is there anything we can buy for exactly 125?
            uniquePrice(pricesMap, 125);

            //  -  What is the cheapest product?
            compareItems(pricesMap, "cheapest");

            //  -----------------------------------------------------------

            //  - Which products cost less than 201? (just the name)
            compareItems(pricesMap, "less", 201);

            //  - Which products cost more than 150? (name + price)
            compareItems(pricesMap, "more", 150);
        }

        public static void costItem(Dictionary<string, int> priceMap, string s)
        {
            Console.WriteLine(priceMap[s]);
        }

        public static void compareItems(Dictionary<string, int> priceMap, string s)
        {
            bool boolean = false;
            SortedSet<string> keySet = new SortedSet<string> (priceMap.Keys);
            List<int> prices = new List<int>(priceMap.Values);
            prices.Sort();
            List<string> mostExpensiveItems = new List<string>();
            List<string> cheapestItems = new List<string>();
            int index = 0;

            if (s.Equals("most expensive"))
            {
                boolean = true;
                index = prices[prices.Count - 1];
            }
            else if (s.Equals("cheapest"))
            {
                index = prices[0];
            }
            else
            {
                Console.WriteLine("Please, specify if you need:");
                Console.WriteLine("   -  \"most expensive\"");
                Console.WriteLine("   -  \"cheapest\"");
            }

            // Store all items that has the max value
            foreach (string key in keySet)
            {
                if (priceMap[key] == index)
                {
                    mostExpensiveItems.Add(key);
                }
            }

            // Store all items that has the min value
            foreach (string key in keySet)
            {
                if (priceMap[key] == index)
                {
                    cheapestItems.Add(key);
                }
            }

            // Print the list
            if (boolean)
            {
                foreach (string item in mostExpensiveItems)
                {
                    Console.WriteLine($"{item}  ");
                }
            }
            else
            {
                foreach (string item in cheapestItems)
                {
                    Console.WriteLine($"{item}  ");
                }
            }
        }

        public static void averagePrice(Dictionary<string, int> priceMap)
        {
            SortedSet<string> keySet = new SortedSet<string>(priceMap.Keys);
            int sum = 0;

            foreach (string key in keySet)
            {
                sum += priceMap[key];
            }
            Console.WriteLine(sum / (float) keySet.Count);
        }

        public static void numProductsBelowLimit(Dictionary<string, int> priceMap, int upLimit)
        {
            SortedSet<string> keySet = new SortedSet<string>(priceMap.Keys);
            int count = 0;

            foreach (string key in keySet)
            {
                if (priceMap[key] < upLimit)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void uniquePrice(Dictionary<string, int> priceMap, int price)
        {
            SortedSet<string> keySet = new SortedSet<string>(priceMap.Keys);
            int count = 0;

            foreach (string key in keySet)
            {
                if (priceMap[key] == price)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }

        public static void compareItems(Dictionary<string, int> priceMap, string s, int limit)
        {
            bool boolean = false;

            SortedSet<string> keySet = new SortedSet<string>(priceMap.Keys);
            List<int> prices = new List<int>(priceMap.Values);
            prices.Sort();
            List<string> lessExpensiveItems = new List<string>();
            Dictionary<string, int> moreExpensiveItems = new Dictionary<string, int>();

            if (s.Equals("less"))
            {
                foreach (string key in keySet)
                {
                    if (priceMap[key] < limit)
                    {
                        lessExpensiveItems.Add(key);
                    }
                }
            }
            else if (s.Equals("more"))
            {
                boolean = true;
                foreach (string key in keySet)
                {
                    if (priceMap[key] > limit)
                    {
                        moreExpensiveItems.Add(key, priceMap[key]);
                    }
                }
            }
            else
            {
                Console.WriteLine("In comparison to the the provided price, please specify if you need to search for items that cost:");
                Console.WriteLine("   -  \"more\"");
                Console.WriteLine("   -  \"less\"");
            }

            SortedSet<string> keySetExpensive = new SortedSet<string>(moreExpensiveItems.Keys);

            // Print the list
            if (boolean)
            {
                foreach (string key in keySetExpensive)
                {
                    int value = moreExpensiveItems[key];
                    Console.WriteLine($"{key}  {value}");
                }
            }
            else
            {
                foreach (string item in lessExpensiveItems)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
*/