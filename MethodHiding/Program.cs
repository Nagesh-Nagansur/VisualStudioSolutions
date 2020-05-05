using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{  
    public class Parent
    {
    public virtual void test1()      //Overridable
        {
            Console.WriteLine("Parent's test1 method called");
        }
    public void test2()
        {
            Console.WriteLine("Parent's test2 method called");
        }
    
    }
    public class Child :Parent
    {
        
        public override void test1()
        {
            Console.WriteLine("Child's test1 method called");
        }
        public new  void test2()  //method hiding
        { 
            Console.WriteLine("child's test2 method called");
        }
        public void  ptest1()                //2)
        {
            base.test1();
        }
        public void ptest2()
        {
            base.test2();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.test1();
            c.test2();


            //if you want to call parent method too then.1),2)
            
            Parent p= new Parent();     //  1)
            p.test1();
            p.test2();





        }
    }
}
