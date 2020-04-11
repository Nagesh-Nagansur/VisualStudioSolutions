using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            int[] number = new int[] {8,6,5,4,5,6};
            int[] nums = { 1, 2, 3, 4, 5 };
            number[0] = 10;
            number[1] = 20;

            foreach (var content in number)
            {
                Console.WriteLine(content);
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }

            string[] names = new string[] { "Rakesh", "Shashi", "Akash" ,"Vinayak"};
          
            foreach (var content in names)
            {
                Console.WriteLine(content);
            }
            Console.WriteLine(names.Length);

            Console.WriteLine("Copy");
            string[] anotherName = new string[10];
           
            Array.Copy(names,anotherName,2);
            foreach (var content in anotherName)
            {
                Console.WriteLine(content);
            }

            Console.WriteLine("Binery Search");
            Array.Sort(number);
            var result= Array.BinarySearch(number, 4);
            Console.WriteLine(result);
            Console.WriteLine("\n");

           



            int[] number1 = new int[] { 8, 6, 5, 4, 5, 6 };
            Array.Clear(number1,3,3);
            foreach (var content in number1)
            {
                Console.WriteLine(content);
            }
            var ans=Array.IndexOf(number1, 5);
            Console.WriteLine(ans);
            Console.WriteLine("\n");



            int[] number2 = new int[] { 8, 6, 5, 4, 5, 6 };
            Array.Reverse(number2);
            foreach (var content in number2)
            {
                Console.WriteLine(content);
            }
            Console.WriteLine("\n");

            int[] number3 = new int[] { 8, 6, 5, 4, 5, 6 };
            Array.Reverse(number3, 3, 3);
            foreach (var content in number3)
            {
                Console.WriteLine(content);
            }
            Console.WriteLine("\n");

            //Lists
            Console.WriteLine("Lists\n");
            List<int> list = new List<int> {5,4,9,6,8,5,3};
            list[0] = 1;
            list[1] = 2;
            foreach(var contet in list)
            {
                Console.WriteLine(contet);
            }
            Console.WriteLine("\n");

            List<int> list1 = new List<int> {9,8,7,6,5,4};
            list.Add(25);
            list.AddRange(list1);
         
            foreach (var contet in list)
            {
                Console.WriteLine(contet);
            }
            Console.WriteLine("\n");

            list.Remove(25);

            list.RemoveAt(0);

          
            Console.WriteLine(list.Count());

            Console.WriteLine(list.IndexOf(4));

            Console.WriteLine(list.Contains(9));

            list.Min();//4

            list.Max();//9

            list.Insert(0, 25);

            list.InsertRange(0, list1);



        }
    }
}
