using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Program
    {
       public class Operation
        {
           public static void Add(int a,int b)
            {
                Console.WriteLine("Addition{0}-",a+b);
            }
           public static void Mul(int a, int b)
            {
                Console.WriteLine("Multiplication{0}-",a*b);
            }

        }

        public delegate void OperationDelegate(int a, int b);

        static void Main(string[] args)
        {
         
            OperationDelegate OD = Operation.Add;
            OD += Operation.Mul;

            OD(10, 20);
          


        }
    }
}
