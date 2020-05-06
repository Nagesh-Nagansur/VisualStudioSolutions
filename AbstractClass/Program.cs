using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Parent 
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);
    }
    public class Child : Parent
    {
       
        public override void Div(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public override void Mul(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

           // Parent p = new Parent();      //Cannot create instance of abstract class.   

            Child c = new Child();
          
            c.Add(10, 20);
            c.Sub(20, 25);
            c.Mul(10, 20);
            c.Div(20, 10);
           
            

        }
    }
}
