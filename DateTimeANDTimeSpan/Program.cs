using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeANDTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime

            DateTime dt = new DateTime();
            Console.WriteLine(dt);


            DateTime date = new DateTime(2020, 04, 10);
            var today = DateTime.Now;
            Console.WriteLine(today);
            var tommorow = DateTime.Now.AddDays(1);
            Console.WriteLine(tommorow);

            var after2hour = DateTime.Now.AddHours(2);
            Console.WriteLine(after2hour);
            Console.WriteLine(today.ToString("mm/dd/yy"));
            Console.WriteLine(today.ToString("mm/dd/yy hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));






            //TimeSpan 

            DateTime start = DateTime.Now;
            DateTime end = new DateTime(2020, 04, 30);

            TimeSpan time = new TimeSpan();
            Console.WriteLine(time);
            time = end - start;

            Console.WriteLine(time.ToString());

            Console.WriteLine(time.Days);
            Console.WriteLine(time.TotalDays);
            Console.WriteLine(time.Hours);
            Console.WriteLine(time.TotalHours);
            Console.WriteLine(time.Minutes);
            Console.WriteLine(time.TotalMinutes);
            Console.WriteLine(time.Seconds);
            Console.WriteLine(time.TotalSeconds);

            //Static fields

            var t1 = TimeSpan.FromSeconds(300);
            var t2 = TimeSpan.FromMinutes(90);
            Console.WriteLine(TimeSpan.FromHours(1.25));
            Console.WriteLine(TimeSpan.Compare(t1, t2));
            Console.WriteLine(TimeSpan.Equals(t1, t2));









        }
    }
}
