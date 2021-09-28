using System;
using System.Text.RegularExpressions;

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
    }
}
