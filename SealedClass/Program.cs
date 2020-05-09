using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
public  class SystemInformation
    {
        string DeviceName = "Acer Nitro 5";
      
        public virtual void Info()
        {
            Console.WriteLine(DeviceName);
          
        }
        

    }
    public  class System : SystemInformation
    {

        //public sealed override void Info()
        //{
        //    Console.WriteLine("System");
        //}

    }

    public class Subsystem : System
    {
        public override void Info()
        {
            Console.WriteLine("SubSystem");
        }



    }


    class Program
    {
        static void Main(string[] args)
        {

            SystemInformation s = new SystemInformation();
            s.Info();
            System s1 = new System();
            s1.Info();
            Subsystem s3 = new Subsystem();
            s3.Info();
        }
    }
}
