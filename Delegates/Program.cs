using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void AddDelegate(int a, int b);
        public delegate string SayhiDelegate(string a);
        
     
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static string Sayhi(string a)
        {
            return "hi " + a;
        }

       
        
        static void Main(string[] args)
        {
            //Calling methods normally..
            Program p = new Program();
           
            p.AddNums(100, 25);
            Console.WriteLine(Sayhi("nagesh"));

           
            
            //Calling methods by using delegates..
            AddDelegate ad = new AddDelegate(p.AddNums);
            SayhiDelegate Sh = new SayhiDelegate(Sayhi);
          
            ad(100, 20);
            ad.Invoke(150, 20);      //simply works like a method
            string str=  Sh("Rakesh");
            Console.WriteLine(str);
           



        }
    }
}
