using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                System.Console.WriteLine("Enter a number or type 'QUIT' to exit: ");
                var input = Console.ReadLine();
                if (input == "QUIT".ToLower())
                    break;
                else
                    numbers.Add(Convert.ToInt32(input));
            }
            numbers.Sort();
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                    System.Console.WriteLine(number);
                }
            }
        }
    }
}
