using System.IO;
using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new StopWatch();
            
            System.Console.WriteLine("Press 's' to start stopwatch.");
            var inputStart = Convert.ToChar(Console.ReadLine());
            if (inputStart == 's')
            {
                watch.Start(DateTime.Now);
            }

            System.Console.WriteLine("Press 'Return' again to stop stopwatch.");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                watch.Stop(DateTime.Now);
                System.Console.WriteLine("Time elapsed is: {0}", watch.Elapsed.TotalSeconds);
            }
        }
    }
}
