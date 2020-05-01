using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Class2 :modifiers
    {

       Class2 c = new Class2();

        public void Print()
        {
          
            c.Public();
            c.Internal();
            c.ProtectedInternal();
            c.Protected();
            //c.private();
         
            

        }
    }
}
