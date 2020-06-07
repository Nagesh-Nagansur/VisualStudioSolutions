using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() {EmployeeId = 1001, Name = "Rajwal", DepartmentId = 10 },
                new Employee() {EmployeeId = 1002, Name = "Jay", DepartmentId = 101},
                new Employee() {EmployeeId = 1003, Name = "Kumar", DepartmentId = 101},
                new Employee() {EmployeeId = 1004, Name = "Alok", DepartmentId = 102},
                new Employee() {EmployeeId = 1005, Name = "Shan", DepartmentId = 102},
                new Employee() {EmployeeId = 1006, Name = "Jmaes", DepartmentId = 103 }
            };

            Console.WriteLine("Select Operator");

            var result = from emp in employeeList
                         where (emp.EmployeeId < 1005)
                         select (emp.Name);



            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("OrderBy and select and where");

            var result1 = employeeList
                         .Where(b => b.EmployeeId <= 1005)                     //Linq Extention Methods
                         .OrderBy(b => b.EmployeeId)
                         .Select(b => b.Name);

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("OrderBy and select and where");

            var result2 = from emp2 in employeeList                             //LINQ Query Operators
                          where emp2.EmployeeId <= 1005
                          orderby emp2.EmployeeId
                          select emp2.Name;


            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }




            Console.WriteLine("OrderByDescenading");

            var OrderByDesending = employeeList.Skip(2).Take(3).OrderByDescending(b => b.Name).Select(b => b.Name);



            foreach (var item in OrderByDesending)
            {

                Console.WriteLine(item);
            }


            Console.WriteLine("Count");


            var Countt = employeeList.Count();
            Console.WriteLine(Countt);


            Console.WriteLine("Maxx");
            var Maxx = employeeList.Max(m => m.EmployeeId);
            Console.WriteLine(Maxx);

            Console.WriteLine("Total No");
            var total = employeeList.Sum(b => b.EmployeeId);
            Console.WriteLine(total);

        }
    }
}

