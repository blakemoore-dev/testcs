using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            var array = new char[name.Length];
            // ----------------------------------------------------------------
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            // This bit ^^^^^^^^^^ here and ^^^^^^^^ here gave me a lot of trouble originally.
            // I knew that I wanted to decrement in my for loop however...
            // I had trouble iterating from array[0]towardsEndOfArray and
            //               iterating from name[endOfName]toBeginningOfName.
            // I think my problem was just trying to visualize the underlying math.
            // If there is a more efficient way to achieve this, that would be GREAT.
            // ----------------------------------------------------------------
            var reversed = new string(array);
            System.Console.WriteLine("Reversed name is: " + reversed);
        }
    }
}
