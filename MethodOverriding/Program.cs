
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace MethodOverriding
    {
        public class ParentClass
        {
            public void Show()
            {
                Console.WriteLine("Parent show method called");
            }
            public virtual void Test()
            {
                Console.WriteLine("Parent test method called");
            }

        }
        public class ChildClass : ParentClass
        {
            public override void Test()
            {
                Console.WriteLine("Child's test method called");
            }

        }


        class Program
        {
            static void Main(string[] args)
            {
                ChildClass c = new ChildClass();
                c.Show();
                c.Test();


            }
        }
    }

