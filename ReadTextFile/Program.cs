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
            var example = Console.ReadLine();
            File.WriteAllText(path,example);
            StreamReader read = new StreamReader(path);
            var line = read.ReadToEnd();
            var newline= line.Split(' ').ToList();
            var list = new List<string>();
            var list1 = new List<int>();
           foreach(var content in newline)
            {
                list.Add(content);
                list1.Add(content.Length);
            }
            Console.WriteLine("Contents of the File:-");
           foreach(var content in list)
            {
                Console.WriteLine(content);
            }
            Console.WriteLine("\n");
            var max = list1.Max();
            Console.WriteLine("The Largest Word in the file is:-");
            Console.WriteLine(list[list1.IndexOf(max)]);
        }   

    }
}
