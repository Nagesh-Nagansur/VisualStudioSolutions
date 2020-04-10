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
            

            DateTime date = new DateTime(2020,04,10);
            var today = DateTime.Now;
            Console.WriteLine(today);

            var tommorow = DateTime.Now.AddDays(1);
            Console.WriteLine(tommorow);

            var after2hour= DateTime.Now.AddHours(2);
            Console.WriteLine(after2hour);
            Console.WriteLine(today.ToString("mm/dd/yy"));
            Console.WriteLine(today.ToString("mm/dd/yy hh:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

            DateTime start = new DateTime(2020, 04, 10);
            DateTime end = new DateTime(2020, 04, 14);

            //TimeSpan 
            TimeSpan time = new TimeSpan();
            time = end - start;
            
            Console.WriteLine(time.ToString());
           

   

          





        }
    }
}
