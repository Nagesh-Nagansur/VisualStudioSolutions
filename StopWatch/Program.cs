using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watch
{
    partial class program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("<<-To Start The StopWatch Enter start->>");
            Console.WriteLine("<<-To Stop The StopWatch Enter stop->>");

            Console.WriteLine("1)start\n2)stop\n3)reset\n4)lap\n5)AllLaps");
            var v = new watch();
            while (true)
            {


                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        v.start();
                        break;
                    case "2":
                        v.stop();
                        break;
                    case "3":
                        v.reset();
                        break;
                    case "4":
                        v.Lap();
                        break;
                    case "5":
                        v.ShowLaps();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
               



            }




        }
    }
}
