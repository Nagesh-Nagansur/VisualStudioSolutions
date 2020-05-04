using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;    //Value type

            object o;      //Reference type

            o = a;         //Implicite

            Console.WriteLine(o);
            ArrayList list = new ArrayList();
            list.Add(25);      //Boxing


           // float c = (float)o;
            //Console.WriteLine(c);
            double b = (double)(int)o;      //Unboxing
            Console.WriteLine(b);
        


        }
    }
}
