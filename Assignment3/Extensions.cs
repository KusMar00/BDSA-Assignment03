using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Assignment3
{
    public static class Extensions
    {
        public static void Print<T>(this IEnumerable<T> items) {
            foreach(var item in items) {
                Console.WriteLine(item);
            } 
        }

        public static bool IsSecure(this Uri uri) {
            string pattern = @"^https:\/\/";
            Regex reg = new Regex(pattern);
            Match match = reg.Match(uri.ToString());
            if (match.Success) {
                return true;
            }
            return false;
        }

        public static int WordCount(this string msg) 
        {
            string pattern = @"[\p{L}-]+";
            MatchCollection matches = Regex.Matches(msg, pattern);
            return matches.Count;
        }
    }
}
