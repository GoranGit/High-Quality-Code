using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StateA());

            context.Request();
            context.Request();
            context.Request();
        }
    }
}
