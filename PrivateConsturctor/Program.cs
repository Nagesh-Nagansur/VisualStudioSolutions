using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConsturctor
{
   public class Conversion 
    {
         static float pi=3.412f;

        private Conversion()
        {
           
        }
        public static void INRToUSD(float inr)
        {

            inr = inr / 75.39f;
            Console.WriteLine("INRToUSD-"+inr);

        }
        public static void USDToINR(float usd)
        {
            usd = usd * 75.39f;
            Console.WriteLine("USDToINR-"+usd);
        }
        public static void AreaOFCircle(float r)
        {
            Console.WriteLine(2*r*pi);
        }

    }



    class Program
    {
        public static void Main()
        {
            // Conversion a = new Conversion();
            Conversion.AreaOFCircle(42);
            Conversion.INRToUSD(150);
            Conversion.USDToINR(1000);



        }



    }

}
