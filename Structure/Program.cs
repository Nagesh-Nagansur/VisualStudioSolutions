using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Employee
    {
        public int EmpId;
        public string FirstName;
        public string LastName;
        public Employee(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname;
        }
        public void GetInfo()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp.EmpId = 100;
            emp.FirstName = "rakesh";
            emp.LastName = "Nagansur";
            emp.GetInfo();

            var emp1 = new Employee(200,"Akash","Nagansur");
           emp1.GetInfo();

            Employee emp2; //create object without using new keyword
            emp2.FirstName = "raj";
            Console.WriteLine(emp2.FirstName);


          

        }
    }
}
