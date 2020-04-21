using System;
using System.IO;

namespace FileAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //File 

            string path = @"D:\File.txt";
            string txt = "THis is the demo text" +
                        " this is 2nd line";
            File.Delete(path);
            File.AppendAllLines(path, txt.Split(' '));   // takes only multiple lines
            File.AppendAllText(path, "This is also the demo text");
            File.WriteAllText(path, "new data");     //overwites the file if data already exits

            string[] stringlines = new string[] { "nagesh", "Rakesh", "Akaash" };
            File.AppendAllLines(path, stringlines);
            File.WriteAllLines(path, stringlines);                   //Takes only Array of string
            File.WriteAllText(path, txt);

            Console.WriteLine("ReadAllLines");
            Console.WriteLine(File.ReadAllText(path));
            string[] lines = new string[25];
            lines=File.ReadAllLines(path);
            Console.WriteLine(lines[0]);


            //WriteallLines and ReadAlLines
            string[] gg = new string[] { "This is the first line", "This is the second line" };
            File.WriteAllLines(path, gg);
            string[] gg1 = new string[20];
            gg1 = File.ReadAllLines(path);  //Returns the string array of words
            Console.WriteLine("ReadAlltext");
            Console.WriteLine(File.ReadAllText(path));   //Returns string
            Console.WriteLine(gg1[0]);
            Console.WriteLine(gg1[1]);


            //operatinos

            string path1 = @"D:\File1.txt";
            string path2 = @"D:\Apps\File2.txt";
            File.Delete(path1);
            File.Copy(path, path1);
            Console.WriteLine(File.Exists(path));
            File.Delete(path2);
            File.Move(path, path2);



            //Fileinfo


            //Properties 
            string path4 = "D:\\Apps\\sample.txt";
            File.WriteAllText(path4, "data");


            FileInfo a = new FileInfo(path4);

            Console.WriteLine(a.FullName);
            Console.WriteLine(a.Name);
            Console.WriteLine(a.Directory);
            Console.WriteLine(a.DirectoryName);
            Console.WriteLine(a.Exists);
            Console.WriteLine(a.Extension);
            Console.WriteLine(a.LastAccessTime);
            Console.WriteLine(a.LastWriteTime);


        }
    }
}
