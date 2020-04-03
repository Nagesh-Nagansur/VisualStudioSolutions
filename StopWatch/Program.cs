using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http.Headers;
using System.Threading;

namespace StopWatch
{
   
    class Program
    {

        static void Main(string[] args)
        {   
         
            Console.WriteLine("<<-To Start The StopWatch Enter start->>");
            Console.WriteLine("<<-To Stop The StopWatch Enter stop->>");

    
            var flag1 = 0;
            var flag2 = 0;
        here:
            while (true)
            {
                var a = new StopWatch();
                var input = Console.ReadLine();

                if (input == "start")
                {
                    flag1 = 1;
                    a.Start();
                }
                else if (input == "stop" && flag2==1 || input=="stop")
                {
                    throw new InvalidOperationException("Invalid input please try again");
                }

                
                
                
                var input1 = Console.ReadLine();
                if (input1 == "stop")
                {
                    flag2 = 1;
                    a.Stop();

                } else if(input1 == "start" && flag1 == 1)
                {
                    throw new InvalidOperationException("Invalid input please try again");
                  
                }
              
                goto here;

            }
     
            

        }

    }

}
