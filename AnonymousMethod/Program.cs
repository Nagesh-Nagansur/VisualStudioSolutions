using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethod
    {
        public static string Greetings(string name)
        {
            return "hello" + name + "a very good morning!";
        } 
      static void Main()
        {


           
            //Normal Delegate
            GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            string str=obj.Invoke("scott");
            Console.WriteLine(str);



            //Anonymouse method
            GreetingsDelegate obj1 = delegate (string name)
             {
                 return "hello " + name + " a very good morning!";
             };


            GreetingsDelegate obj2 = (name)=>
            {
                return "Hello this is lambda expressin" + name + "ok";
            };


            string st= obj1("Naruto");
            Console.WriteLine(st);



        }
    }
} 


//1) we write a method and then bind it with the delagate.
//2) In Anonymous method we bind the method dirictly with the instance of a delegate.