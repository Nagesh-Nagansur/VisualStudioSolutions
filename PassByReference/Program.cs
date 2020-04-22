using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByReference
{
    public class Calculator
    {
        public static void Squre(ref int a)
        {
            Console.WriteLine(a = a * a);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            Console.WriteLine("Values before passing through the method a={0}", x);
            Calculator.Squre(ref x);
            Console.WriteLine("Values After passing through the method a={0}", x);


        }

    }
}
