using System;

namespace Exercise1
{
    public class StopWatch
    {
        public DateTime StartTime { get; private set; }

        public void Start(DateTime startTime)
        {
            StartTime = startTime;
        }

        public void Stop()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
