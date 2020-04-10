using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "This is the example";
            var b = "Nagesh";
            string[] list = b.Split();
            foreach(var content in list)
            {
                Console.WriteLine(content);
            }


            
        }
    }
}
