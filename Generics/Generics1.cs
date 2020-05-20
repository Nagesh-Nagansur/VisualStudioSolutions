using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Generics1
    {

        public bool Compare<t>(t a, t b)
        {
            if (a.Equals(b))
                return true;
            return false;

        }

        static void Main(string[] args)
        {

            //Generic on method
            Generics1 g1 = new Generics1();
            bool result = g1.Compare<int>(10, 25);

            Console.WriteLine(result);

           
           
            Generics2 g2 = new Generics2();
            g2.Add<float>(10.4f, 20.50f);
            g2.Sub<float>(12.25f, 65.0f);

           
            //Generic on Class
            Generics3<float> g3 = new Generics3<float>();
            g3.Add(10.6f, 2.2f);
            g3.Sub(25f, 25.4f);

        }  
    }

}
