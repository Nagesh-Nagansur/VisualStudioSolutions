using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndConstructor
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Akash");
            Person p3 = new Person("Akash", 250);
            Person p4 = new Person("Rakesh", 255, "Solapur");
            p1.GetInfo();
            p2.GetInfo();
            p3.GetInfo();
            p4.GetInfo();


        }
    }
}
    
