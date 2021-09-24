using System;


namespace BDSA2020.Assignment02
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri u) 
        {
            return u.Scheme == Uri.UriSchemeHttps;
        }

    }
}
