using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var likes = new List<string>();
            while (true)
            {
                System.Console.WriteLine("Who likes your Facebook post?");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                
                likes.Add(input);
            }
            if (likes.Count == 0)
                System.Console.WriteLine("Nobody likes you.");
            else if (likes.Count == 1)
                System.Console.WriteLine("{0} likes your post.", likes[0]);
            else if (likes.Count == 2)
                System.Console.WriteLine("{0} and {1} like your post.", likes[0], likes[1]);
            else if (likes.Count > 2)
                System.Console.WriteLine("{0], {1}, and {2} others like your post.", likes[0], likes[1], likes.Count - 2);
        }
    }
}
