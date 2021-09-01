using System;

namespace Methods
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");
            
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(number);
            else
                System.Console.WriteLine("Conversion failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5}));
        }

        static void usePoints()
        {
            try
            {
            var point = new Point(10, 20);
            point.Move(null);
            System.Console.WriteLine("Point is at {0}, {1}", point.x, point.y);

            point.Move(100, 200);
            System.Console.WriteLine("Point is at {0}, {1}", point.x, point.y);
                
            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occurred.");
            }
 
        }
    }
}
