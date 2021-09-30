using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Assignment3
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri u) 
        {
            return u.Scheme == Uri.UriSchemeHttps;
        }

        public static int WordCount(this string s) 
        {
            var counter = 0;
            var words = s.Split(" ");
            var unicodeLetters = new Regex("[a-z]+"); 
            foreach (var w in words) 
            {
                if (unicodeLetters.IsMatch(w)) {
                    counter++;
                }
            }
            return counter;
        }

        public static void Print<T>(this IEnumerable<T> items){
            foreach(var item in items){
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(this T item) => Console.WriteLine(item);
    }
}
