using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Use       //Extending the existing freamwork Utility class by adding Cube and EvenOROdd methods without disturbing the framework
{
    public class Utility
    {
        public delegate void Function(int a);
        public static void FunctionExe(int a,Function b)       //Here b is instance of delgate Function
        {
            b(a);
        }


        public static void Square(int a)    //Utility class has Only one method
        {
            Console.WriteLine(a * a);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Utility.Square(a);
            Utility.FunctionExe(a, Cube);    //Pluging the cube method.


        }
    

            public static void Cube(int a)
            {
                Console.WriteLine(a * a * a);
            }
            public static void EvenOROdd(int a)
            {
                if (a % 2 == 0)
                    Console.WriteLine("even");
                Console.WriteLine("False");
            }

        }
    
}
