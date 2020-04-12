using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFile
{
    class Program
    {
        static void Main(string[] args)
        { 
            var path = @"D:\Roof_Work\text.txt";
            Console.WriteLine("Write the text");
            var Read = Console.ReadLine();
            File.WriteAllText(path, Read);

         
            var lines =File.ReadAllText(path);
            Console.WriteLine(lines);

       
            string[] newline = lines.Split();
            var list1 = new List<int>();
            foreach (var content in newline)
            {
                //list.Add(content);
                list1.Add(content.Length);
            }
            Console.WriteLine("Contents of the File:-");
            foreach (var content in )
            {
                Console.WriteLine(content);
            }
            Console.WriteLine("\n");
            var max = list1.Max();
            Console.WriteLine("The Largest Word in the file is:-");
            Console.WriteLine(newline[list1.IndexOf(max)]);
        }   

    }
}
