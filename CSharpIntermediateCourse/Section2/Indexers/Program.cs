using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Blake";
            System.Console.WriteLine(cookie["name"]);
        }
    }
}
