using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClass
{
    public class demo
    {
    public    string sample= "This is an example string to demostrate operations on string";
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Example = "This is an example string to demostrate operations on string";

            Console.WriteLine(Example.Length);              //inclusive of spaces
            Console.WriteLine(Example.Substring(11));
            Console.WriteLine(Example.Substring(11, 7));     //example


            Console.WriteLine(Example.ToUpper());
            Console.WriteLine(Example.ToLower());


            var d = new demo();
            string Example1 = "This is an example string to demostrate operations on string";
            Console.WriteLine(Example.Equals(Example1));
            Console.WriteLine(Example.Equals(d.sample));
            Console.WriteLine(Example.Replace('i', 'I'));    //character replace
            Console.WriteLine(Example.Replace(" ", ""));     //word replace
            Console.WriteLine(Example.Replace("This", "That"));//.....


            string Example2 = "   This is an example string to demostrate operations on string    ";
            Console.WriteLine(Example2.Trim());
            Console.WriteLine(Example2.TrimEnd());
            Console.WriteLine(Example2.TrimStart());
            Console.WriteLine(Example.Remove(4));
            Console.WriteLine(Example.Remove(1, 1));         //Tis .....
            Console.WriteLine(Example.Insert(4, " added"));




            string d1 = (string)Example.Clone();
            //    Console.WriteLine(Object.ReferenceEquals(d1, Example));
            string d2 = string.Copy(d1);
            //   Console.WriteLine(Object.ReferenceEquals(d2,d1));


            Console.WriteLine(Example.IndexOf('a'));                //char
            Console.WriteLine(Example.IndexOf('a', 10));
            Console.WriteLine(Example.IndexOf("xam"));              //string
            Console.WriteLine(Example.IndexOf("an", 0, 25));
            Console.WriteLine(Example.IndexOf("an", 0, 2));  //if not prints -1;
            Console.WriteLine(Example.Contains('z'));    //False
            Console.WriteLine(Example.Contains("xam"));  //True
            Console.WriteLine(Example.EndsWith("ing"));  //ture


            List<char> list= Example.ToList();   //doubut 
            Console.WriteLine(list[0].GetType());
            foreach(var content in list)
            {
                
                Console.WriteLine(content);
            }

            var array = Example.Split('-');
            foreach (var content in array)
            {

                Console.WriteLine(content);
            }






            Console.WriteLine("Comapre");
            Console.WriteLine(string.Compare("nagesh", "Rakesh"));
            Console.WriteLine(string.Compare(Example,Example2));
            Console.WriteLine(string.Compare("b","b"));

            Console.WriteLine("Join");
            string[] arr = new string[] {"naegsh","Akash" };
            var joined = string.Join("-",arr);  //takes array
            Console.WriteLine(joined);

            var emt = " ";
            if (string.IsNullOrEmpty(emt))
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine("");
            }


        }
    }
}
