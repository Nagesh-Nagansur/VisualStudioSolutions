using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Private
    public class Private
    {
      private int _id;
      private void method()
        {
            Console.WriteLine("Private method");
        }

        public int ID
        {
            get
            {
                
                return _id;
            }
            set
            {
                if(value > 0 && value<=20 )  
                    this._id = value;
                else
                {
                    Console.WriteLine("Enter in range 1 to 20");
                }
             
            }
        }
    }
    //Protected
    public class Protected
    {
        protected string Name;
        protected void Msg(string a)
        {
            Console.WriteLine("Hello " + a);
        }


    }
    public class AnotherClass : Protected
    {
        public void Print()
        {
            this.Name = "raju";
            Console.WriteLine(this.Name);
            this.Msg("noname");

        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            //Private accessor
            Private p1 = new Private();
            p1.ID = 19;
            Console.WriteLine(p1.ID);
           
          

            //Proteted accessor
            AnotherClass a1 = new AnotherClass();
            a1.Print();


        }
    }
}
