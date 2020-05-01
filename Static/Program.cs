using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    

        class Program
        {

            static void Main(string[] args)
            {
             
                Console.WriteLine(Calculator.Name);
                Calculator.Addition(10, 25);
                Calculator.Multiplication(10, 10);
              
            }
        }
    }

