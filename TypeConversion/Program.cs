using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Converison

            byte a = 255;
            int b = a;
            Console.WriteLine(b);
         
            //Explicit Converion
          
            float c =10.50f;
            int d = (int)c;
            Console.WriteLine(d);

            //Non compatible types


            string s = "123456";
            int k = int.Parse(s);
            Console.WriteLine(k);
            try
            {
                byte n = Convert.ToByte(s);
                Console.WriteLine(n);
            }
            catch (Exception)
            {
                Console.WriteLine(" too large ");
            }
          
            int l = Convert.ToInt32(s);   
            Console.WriteLine(l);
         
            try
            {
                var t ="true";
                bool o = Convert.ToBoolean(t);
                Console.WriteLine(o);

            }
            catch(Exception)
            {
                Console.WriteLine("Not possible");



            }




        }
    }
}
