using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndSDowncasting
{
    class Parent
    {  
        public int ParentProp1 { get; set; }
        public string ParentProp2 { get; set; }
        public int ParentProp3 { get; set; }
        public void ParentMethod1()
        {
            Console.WriteLine("ParentMethod1");
        }
    }
    class Child:Parent
    {
        public int ChildProp1{ get; set; }
        public int ChildProp2 { get; set; }
        public  void ChildMethod1()
        {
            Console.WriteLine("ChildMethod1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            //UpCasting-
           
        
            Parent a = new Child();
                a.ParentProp1 = 51;
                a.ParentProp2 = "fasfasdfsad";
                a.ParentProp3 = 15;
                a.ParentMethod1();


            //DownCasting-

            Child c = a;
                c.ChildProp1 = 10;
                c.ChildProp2 = 25;

                c.ParentProp1 = 10;
                c.ParentProp2 = "Raju";
                c.ParentProp3 = 10;
                c.ParentMethod1();
                c.ChildMethod1();


            Child d = a as Child;
            if (d != null)
            {
                Console.WriteLine("Casting is possible");
            }
            else
               Console.WriteLine("Not possible");

         
            if(d is Child)
            {
                Console.WriteLine("Casting is possible");
            }
            else
            {
                Console.WriteLine("not possible");
            }



       

      //      StreamReader reader = new StreamReader(new MemoryStream());                //upcasting


        
             









        }
    }
}
