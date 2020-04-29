using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Logger
    {
    
        public void log(string msg)
        {
         
            Console.WriteLine(msg);

        }
       

        
    }
    public class Dbmigrator:Logger
    {
       public void Migrate()
        {
            log("Migrating");
        }

    }
    public class Installer:Logger
    {
        public void installer()
        {
            log("Installing tha application");
        }

    }


    class Program
    {
        static void Main(string[] args)    
        {
            var db = new Dbmigrator();
            db.Migrate();
            var install = new Installer();
            install.installer();
          


        }
    }
}
