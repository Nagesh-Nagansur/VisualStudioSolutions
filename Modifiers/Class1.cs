using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Class1
    {
        modifiers m = new modifiers();
        public void print()
        {
            m.Public();
            m.Internal();
            m.ProtectedInternal();
            //m.protected();
            // m.Private();
        }


    }
  
}
