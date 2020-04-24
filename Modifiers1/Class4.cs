using Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers1
{
    class Class4:modifiers
    {
        Class4 c = new Class4();
        public void Print()
        {

            c.Public();
            c.Protected();
            c.ProtectedInternal();
          
          //  c.Private();
           // c.Internal();


        }



    }
}
