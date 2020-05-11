using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public  interface IInterface1
    {
        void Add(int a, int b);
    }
    interface IInterface2 : IInterface1
    {
        void Sub(int a, int b);
    }
    class Program :IInterface2
    {

      public void Add(int a, int b) 
        { 
            Console.WriteLine(a+b);
        }
       public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }

         static void Main(string[] args)
        {

            Program p = new Program();
     
            
            p.Sub(20,10);
            p.Add(10, 20);



            IInterface2 i = p;
            i.Add(10, 10);
            i.Sub(20, 10);




        }
    }
}
