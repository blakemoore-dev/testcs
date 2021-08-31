using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new StopWatch();
            
            System.Console.WriteLine("Press 'RETURN' to start/stop the stopwatch.");

            while (true)
            {
                var inputStart = Console.ReadLine();
                if (String.IsNullOrEmpty(inputStart))
                {
                    watch.Start(DateTime.Now);
                }

                var inputStop = Console.ReadLine();
                if (String.IsNullOrEmpty(inputStop))
                {
                    watch.Stop(DateTime.Now);
                    System.Console.WriteLine("Time elapsed is: {0}", watch.Elapsed);
                }
            }
        }
    }
}
