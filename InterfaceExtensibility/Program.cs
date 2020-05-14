using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{

    class Program
    {
        static void Main(string[] args)
        {
            DBmigrator d = new DBmigrator(new FIleLogging());
            d.Migrate();

          
        }
    }
}
