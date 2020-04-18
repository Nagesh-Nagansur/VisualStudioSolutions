using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{   public class Person
    {
         public int age;
       

    }
   class Program

    {
        static void Square1(Person a,Person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age+" "+b.age);
        }
        static void Square(int a, int b)
        {
            a = a * a;

            b = b * b;
            Console.WriteLine(a + " " + b);
        }

        static void Main(string[] args)

        {
            //value Types

            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2);

            //Reference Type
            Person p1 = new Person();
            Person p2 = new Person();
            p1.age = 2;
            p2.age = 5;
            Console.WriteLine(p1.age+" "+p2.age);
            Square1(p1, p2);
            Console.WriteLine(p1.age+" "+p2.age);


            int[] arry = new int[] { 1, 2, 3, 4 };
            var arry2 = arry;
            arry2[3] = 9;
          foreach(var content in arry)
            {
                Console.WriteLine(content);
            }
            foreach (var content in arry2)
            {
                Console.WriteLine(content);
            }

        }

    }
}
