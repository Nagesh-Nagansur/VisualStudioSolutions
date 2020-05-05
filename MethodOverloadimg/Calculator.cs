using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadimg
{
    public class Calculator
    {
        public static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public static void Addition(int a, int b, int c)
        {

            Console.WriteLine(a + b + c);
        }
        public static void Addition(params int[] numbers)
         {
            int sum = 0;
            foreach(var content in numbers)
            {
                sum = sum + content;
            }
            Console.WriteLine(sum);
            

         }

        static void Main(string[] args)
        {
           
            Calculator.Addition(10,54);
            Calculator.Addition(12, 25, 45);
            Calculator.Addition(1,2,4,4,8,6,5,4);




        }
    }
}
