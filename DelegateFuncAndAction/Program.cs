using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFuncAndAction
{
   

    
    class MethodCollections
    {

        //Method which returns nothing.
        public static void PrintText()
        {
            Console.WriteLine("Printing Text");
        }
        public static void Square(int a)
        {
            Console.WriteLine(a*a);
        }
        public static void Mult(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        
        
        
        //Methods with return types..
        public static string Text()
        {
            return "Text";
        }
        public static int DisplayAddition(int a, int b)
        {
            return a + b;
        }
        public static string DisplayNames(string a,string b,string c)
        {
            return a + b + c;
        }

    }
    class Program
    {
      
         public static void Main(string[] args)
        {
            //Without return type.  Action<>
            Action Printtext =  MethodCollections.PrintText;
            Action<int> Square =  MethodCollections.Square;
            Action<int, int> Mult = MethodCollections.Mult;



            //With return type..
            Func<string>Text = new Func<string>(MethodCollections.Text);
            Func<int, int,int> DisplayAdd = new Func<int,int,int>(MethodCollections.DisplayAddition);


            //Invoking the methods
            Printtext();
            Square(5);
            Mult(2, 2); 


            string s=Text();
            Console.WriteLine(s);
            int a= DisplayAdd(25, 65);
            Console.WriteLine(a);

        }
    }
}
