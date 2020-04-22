using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Logging
    {
        public static string message;
        public static void logg(string m)
        {
            message = m;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            string path = @"D:\Folder1\sample.txt";
            try
            {
                Console.WriteLine(File.ReadAllText(path));
                //  Console.WriteLine("Deleting the File");
            }
          
            catch(Exception ex)
            {
               
                Console.WriteLine("Exception");
                Logging.logg(ex.Message);
                //int a = 0;                                     //Error
                //int c = 5 / a;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
         

            finally
            {

                Console.WriteLine("Deleting the file");
            }
           




        }
    }
}
