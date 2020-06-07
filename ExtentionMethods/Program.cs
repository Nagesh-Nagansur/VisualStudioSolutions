using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string st = "this is big string which is to be used ";
            string sample = st.EndString();
            Console.WriteLine(sample);
         

        
        }
    }


    public static 
    public static class StringExtention
    {
        public static string EndString(this String str)
        {
          
            var s = str.TrimEnd();
            var statement = s.Split(' ');


            int len = statement.Length - 1;
            return statement[len];
        }


    }

}



