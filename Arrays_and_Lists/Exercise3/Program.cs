using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                System.Console.WriteLine("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (!numbers.Contains(input))
                    numbers.Add(input);
                else
                    System.Console.WriteLine("Number already exists. Try again...");
            }
            numbers.Sort();
            foreach (var number in numbers)
                System.Console.WriteLine(number);
        }
    }
}
