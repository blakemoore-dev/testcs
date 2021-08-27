using System;
using System.Collections.Generic;
// using System.Text;

namespace testcs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int>();
            while (true)
            {
                System.Console.WriteLine("Enter numbers separated by ',' : ");
                var input = Console.ReadLine();

                // Validate input. Feels clean enough.
                // Assuming that input does not contain non numerical characters.
                if (String.IsNullOrEmpty(input))
                {
                    System.Console.WriteLine("Invalid list. Try again...");
                    continue;
                }

                var numbers = input.Split(',');

                // Not sure if i'm happy with the following if/else statement with for loop.
                // Feels cluttered.
                if (numbers.Length < 5)
                {
                    System.Console.WriteLine("Invalid list. Try again...");
                    continue;
                }
                else if (numbers.Length >= 5)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numList.Add(Convert.ToInt32(numbers[i]));
                    }
                    break;
                }
            }
            numList.Sort();
            System.Console.WriteLine("The three smallest numbers are {0}, {1}, and {2}.", numList[0], numList[1], numList[2]);
        }
    }
}