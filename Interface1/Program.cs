using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{


    public class Parent 
    {
      public  void Method()
        {
            Console.WriteLine("Parent method called");
        }
    }
    interface Interface1
    {
        void test();
        void show();
    }
    interface Interface2
    {
        void test();
       
    }
    



    class Program : Parent,Interface2,Interface1
    {
        void Interface1.show()
        {
            Console.WriteLine("Show method is implemented");
        }

        public void test()
        {
            Console.WriteLine("Test method is implemented");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method();
            p.test1();



            Interface1 i1 = new Program();

            i1.show();
           



        }

      
   
    }
}
