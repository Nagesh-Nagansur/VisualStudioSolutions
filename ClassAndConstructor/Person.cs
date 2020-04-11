namespace ClassAndConstructor
{
    partial class Program
    {
        public class Person
        {
            public string Name;
            public int Id;
            public string Address;
            //Constructor overloads
            public Person()
            {
                this.Name = "no name";
                this.Id = 0;
                this.Address = "no address";
            }
            public Person(string name)
            {
                Name = name;
            }
            public Person(string name, int id) : this(name)     //constructor chaining

            {

               // this.Name = name;
                  this.Id = id;

            }
            public Person(string name, int id, string address) : this(name, id)

            {
                //  this.Name = name;
                // this.Id = id;
                this.Address = address;
             
            }
            public void GetInfo()
            {
                System.Console.WriteLine(this.Id);
                System.Console.WriteLine(this.Name);
                System.Console.WriteLine(this.Address);
            }


           


        }
    } 
}
    
