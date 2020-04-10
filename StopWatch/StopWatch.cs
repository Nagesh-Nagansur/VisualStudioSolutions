using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace watch
{
    partial class program
    {
        public class watch
        {
            Stopwatch mywatch = new Stopwatch();
            List<TimeSpan> laps = new List<TimeSpan>();



            public void start()
            {
                mywatch.Start();
                Console.WriteLine(mywatch.Elapsed);
            }

            public void stop()
            {
                mywatch.Stop();
                Console.WriteLine(mywatch.Elapsed);
            }
            public void reset()
            {
                mywatch.Reset();
                Console.WriteLine(mywatch.Elapsed);
                laps.Clear();
            }
            public void Lap()
            {
                if (mywatch.IsRunning)
                {
                    laps.Add(mywatch.Elapsed);
                    Console.WriteLine(mywatch.Elapsed);
                }
                else
                {
                    Console.WriteLine("Stopwatch is stopped");
                }
        
            }
            public void ShowLaps()
            {

                if (laps.Count == 0)
                {
                    Console.WriteLine("No laps");
                }
                else
                {
                    foreach (var content in laps)
                    {
                        Console.WriteLine(content);
                    }

                }
            }


        }
    }
}
