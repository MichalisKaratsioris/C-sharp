/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Week2.DataStructures
{
    internal class UrlFixer
    {
        public static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it in more than one way using different string functions!

            // adding the missing ":"

            string newURL = String.Empty;

            if (url.IndexOf("/") != 6)
            {
                string http = url.Substring(0, 5);
                string www = url.Substring(5);
                newURL = $"{http}:{www}";
            }

            // substituting "bots" with "odds"
            int index = newURL.IndexOf('b');
            string finalURL = newURL.Replace(newURL.Substring(index), "odds");
            Console.WriteLine($"Corrected url: {finalURL}");

            bool isCorrect = "https://www.reddit.com/r/nevertellmetheodds" == finalURL;
            Console.WriteLine($"The changed url is correct: {isCorrect}");
        }
    }
}
*/