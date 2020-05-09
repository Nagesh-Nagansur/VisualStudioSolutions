using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassEg_1
{
    public abstract class Parent
    {
        public abstract void Function(int x);
    
    }
    public class Child1 : Parent
    {
        public override void Function(int a)
        {
            Console.WriteLine("SQR-{0}",a*a);
        }

    }
    public class Child2 : Parent
    
    {
        public override void Function(int x)
        {
            Console.WriteLine("Cube-{0}",x*x*x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         //   Parent p1 = new Parent();

            Child1 c1 = new Child1();
            c1.Function(10);
            Child2 c2 = new Child2();
            c2.Function(2);

        }
    }
}
