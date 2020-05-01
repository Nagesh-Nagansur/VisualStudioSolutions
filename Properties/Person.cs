using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        private String _name;
        private int _id=100;
        private int _value;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }                  //readonly
        }
        public int Value
        {
            set { _value = value; }               //writeonly
        }


     
    }
        class Program

        {
            static void Main(string[] args)
            {
                Person p1 = new Person();
               
                p1.Name = "Raju";
                Console.WriteLine(p1.Name);


                // p1.Id = 25;
                Console.WriteLine(p1.Id);

                p1.Value = 1000;
                //Console.WriteLine(p1.Value);
                
                
            }






        

    }
}
