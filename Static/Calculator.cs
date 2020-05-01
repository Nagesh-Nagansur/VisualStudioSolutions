using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
  
    public static class Calculator
    {
        public static string Name = "Calculator";    //Static field
        public static void Addition(int a, int b)
        {
            Console.WriteLine("Additioni->{0}", a + b);
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication->{0}", a * b);
        }

    }

}
