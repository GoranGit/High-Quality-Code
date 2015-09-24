using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class StateA:State
    {
        public override void Change(Context context)
        {
            context.State = new StateB();
            Console.WriteLine("Changed state from A to B!");
        }
    }
}
