using System;

namespace StopWatch
{
    public class StopWatch
    {
        DateTime end = new DateTime();
        TimeSpan timespan = new TimeSpan();
        DateTime start = new DateTime();
        int flag1 = 0;
        int flag2 = 0;

        public void Start()
        {
            start = DateTime.Now;
            Console.WriteLine("StopWatch Started-->");
            Console.WriteLine(start.ToString("HH:mm:ss"));
        

        }
        public void Stop()
        {


            end = DateTime.Now;
            timespan = (end - start);

            Console.WriteLine("TimeLap-->{0}", timespan.ToString());
            Console.WriteLine("CurrentTime-->{0}", end.ToString("HH:mm:ss"));
           

        }


    }

}
