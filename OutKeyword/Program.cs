using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Multiplication(out x);
            Console.WriteLine("x={0}", x);
        }
        public static void Multiplication(out int a)
        {
            a = 10;
            a = a * a;
            Console.WriteLine("Multiplication {0}", a);
        }

    }
}
