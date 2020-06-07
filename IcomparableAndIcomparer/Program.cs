using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableAndIcomparer
{
   public class Student:IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
            
        }
    }
   public  class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Class > y.Class)
                return 1;
            else if (x.Class < y.Class)
                return -1;
            else
                return 0;
        }
    }
    class TestStuednt
    {
        static void Main(string[] args)
        {

             List<Student> students = new List<Student> { new Student { Sid = 102, Name = "Raju", Class = 10 } ,
                                                          new Student { Sid = 101, Name = "Faran", Class = 12 } ,
                                                          new Student { Sid=103,Name="raka",Class=11}
                                                        };
         

            CompareStudents obj = new CompareStudents();
            students.Sort(obj);      //   can't implement without Icomparable



            foreach (var i in students)
            {
                Console.WriteLine(i.Sid+" "+i.Name+" "+i.Class);
            }

        }

    }
}
