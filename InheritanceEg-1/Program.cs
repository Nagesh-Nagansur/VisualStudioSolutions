using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg_1
{
    class Employee
    {
        public string FullName;
        public int Id;
        public string Email;

    }
    class FullTimeEmployee :Employee
    {
      public  int YearlySalary;
        
    }
    class PartTimeEmployee :Employee
    {
      public   int HourlySalary;

    }

    class TempEmployee:PartTimeEmployee
    {

    
    }



    
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee e1 = new FullTimeEmployee();
            e1.FullName = "Raju Rastogi";
            e1.Email = "Rajurastogi";
            e1.Id = 100;

            e1.YearlySalary = 400000;

         

            TempEmployee t1 = new TempEmployee();
            t1.FullName = "";
            t1.Email = "";
            t1.Id = 0;

            t1.HourlySalary = 150;


          


        }
    }
}
