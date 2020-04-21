using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Directory

            string path = @"D:\New folder\AnotherFolder";
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(@"D:\Temp");
            Directory.Delete(@"D:\Temp", true);

            Console.WriteLine(Directory.Exists(path));
            Console.WriteLine(Directory.Equals(path,path));
            Console.WriteLine( Directory.GetCreationTime(path));
            string[] arry = new string[25];
            Console.WriteLine(  Directory.GetCurrentDirectory());




            //DirectoryInfo
            var path1 = @"D:\New folder\AnotherFolder";
            DirectoryInfo d = new DirectoryInfo(path1);
            d.Create();
            Console.WriteLine(d.FullName);
            Console.WriteLine(d.Name);
            Console.WriteLine(d.CreationTime);
            Console.WriteLine(d.Parent);
            Console.WriteLine(d.Exists);
            d.Delete();
            d.Refresh();
            Console.WriteLine(d.Exists);
        }
    }
}
