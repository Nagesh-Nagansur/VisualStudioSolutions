using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{

   static class Logger
    {
        public static void Log(string msg)
        {
            Console.WriteLine(msg);
        }

    }

    class Program
    {
        static string content;
        static Program()
        {
            var path = @"D:\Videos\TextFile.txt";
            Logger.Log("Loading the File");
            content = File.ReadAllText(path);                 //loaded once
    
        }
  
        static void Main(string[] args)
        {
            Console.WriteLine(content);
       
         

        }
    }
}
