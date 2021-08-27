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
            for (int i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            System.Console.WriteLine("Reversed name is: " + reversed);
        }
    }
}
