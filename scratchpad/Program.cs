using System;
using System.Diagnostics;

namespace Code_Coach_Challenge
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] seq = {1, 2, 3, 4, 5, 6, 7, 8};

            var oddOrEven = seq.Length%2;

            if (oddOrEven == 1)
                System.Console.WriteLine("Odd");
            else
                System.Console.WriteLine("Even");
        }
    }
}