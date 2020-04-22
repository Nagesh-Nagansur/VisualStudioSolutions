using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyWords
{
    class Program
    {
        public static void AddToList(params int[] l)
        {
            int[] a = new int[25];
            a = l;
            foreach (var content in a)
            {
                Console.WriteLine(content);
            }
        }
        public static void Minimum(params int[] a)
        {
            Console.WriteLine(a.Min());
        }

        static void Main(String[] args)
        {

            int[] array = new int[] { 10, 25, 58, 45 };

            AddToList(array);
            Console.WriteLine("\n");
            AddToList(25, 45, 89, 48, 52, 56);
            Console.WriteLine("\n");
            Minimum(68, 52, 47, 56, 35);

        }
    }
}
