using System;

namespace Exercise1
{
    public class StopWatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }

        public void Start(DateTime startTime)
        {
            StartTime = startTime;
        }

        public void Stop(DateTime stopTime)
        {
            StopTime = stopTime;
        }

        public TimeSpan Elapsed
        { get { var timeSpan = StopTime - StartTime; return timeSpan; }}
        
        public TimeSpan ElapsedDifference
        { get { var timeSpan = StopTime - Convert.ToDateTime(Elapsed); return timeSpan; }}
    }
}
