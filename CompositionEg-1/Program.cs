using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionEg_1
{

   public class Animal                                                //parent class
    {
       public int age;
       protected  void Eat(string a)
        {
            Console.WriteLine(a+" Is Eating");
        }
      public  void Sleep(string a)
        {
            Console.WriteLine(a+" Is Sleeping");
        }
    }
   
    public class Walkable
    {
     public  void walk(string a)
        {
            Console.WriteLine(a+" Is walkable");
        }
    }

    public class Swimmable
    {
        public string aa;
        
        public void Swim(string a)
        {
            Console.WriteLine(a+" Is swimming");
        }
    
    }
   
    
    
    public class Human :Animal
    {
        private readonly Walkable w;
        private readonly Swimmable s;
        public Human(Walkable w,Swimmable s)
        {
            this.s = s;
            this.w = w;

        }
     public void Features()
        {
           
            age = 21;
            Console.WriteLine(age);
            Eat("Human");
            Sleep("Human");
            w.walk("Human");
            s.Swim("Human");
         
        }

    }
    public class Dog :Animal
    {
    public void Features()
        {
            age = 5;
            Console.WriteLine(age);
            Eat("Dog");
            Sleep("Dog");
        }
    
    }
    public class GoldFish:Animal
    {
       private  Swimmable sw;
     
       public GoldFish(Swimmable s)
        {
            sw = s;
           
        }
       public void Features()
        {
            age = 10;
            Console.WriteLine(age);
            Eat("Goldfish");
            Sleep("GoldFish");
            sw.Swim("GoldFish");
            sw.aa = "asdfasfsad";
        
          
        }

    }


    public class Duck : Animal
    {
        private readonly Walkable w;
        private readonly Swimmable s;

   
        public Duck(Swimmable s, Walkable w)
        {
          this.s = s;
          this.w = w;
        }

        public void Features()
        {
            age = 4;
            Console.WriteLine(age);
            Eat("Duck");
            Sleep("Duck");
            s.Swim("Duck");
            w.walk("Duck");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Human p = new Human(new Walkable(),new Swimmable());
            p.Features();
           
            
            Console.WriteLine();

        
            GoldFish g = new GoldFish(new Swimmable());
            g.Features();
            //  g.wa;

            Console.WriteLine();

            Duck d = new Duck(new Swimmable(),new Walkable());
            d.Features();
         
         


        }
    }
}
