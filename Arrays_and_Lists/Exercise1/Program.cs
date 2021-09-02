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
                if (String.IsNullOrWhiteSpace(input))
                    break;
                
                likes.Add(input);
            }

            if (likes.Count > 2)
                System.Console.WriteLine("{0}, {1} and {2} others like your post.", likes[0], likes[1], likes.Count - 2);
            else if (likes.Count == 2)
                System.Console.WriteLine("{0} and {1} like your post.", likes[0], likes[1]);
            else if (likes.Count == 1)
                System.Console.WriteLine("{0} likes your post.", likes[0]);
            else
                System.Console.WriteLine("Nobody likes your!");

            // My original code threw an error. I'm including it below for reference. Need a little help on the specifics of why the ORDER of the IF/ELSE statement matters.
            
            // if (likes.Count == 0)
            //     System.Console.WriteLine("Nobody likes you!");
            // else if (likes.Count == 1)
            //     System.Console.WriteLine("{0} likes your post.", likes[0]);
            // else if (likes.Count == 2)
            //     System.Console.WriteLine("{0} and {1} like your post.", likes[0], likes[1]);
            // else
            //     System.Console.WriteLine("{0}, {1} and {2} others like your post.", likes[0], likes[1], likes.Count - 2);

            // !!UPDATE!! ---- For some reason I can comment out the code above and uncomment this code and it works now. I'm a bit lost. I'm not sure about how to debug this.
            // I'm starting to think that the .dll was still the old version or something like that. If you have any insights on how the dotnet debugging/compiling works, I'd like to discuss this in further detail.
        }
    }
}
