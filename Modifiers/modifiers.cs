using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
 public   class modifiers
    {
       
        public void Public()
        {
            Console.WriteLine("Public Mehtod");
        }
        private void Private()
        {
            Console.WriteLine("Private Method");
        }
        protected void Protected()
        {
            Console.WriteLine("Protected");
        }
        internal void Internal()
        {
            Console.WriteLine("Internal Method");
        }
        protected internal void ProtectedInternal()
        {
            Console.WriteLine("Protected Internal Method");
        }

    }
}
