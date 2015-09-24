using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StateC:State
    {
        public override void Change(Context context)
        {
            context.State = new StateA();
            Console.WriteLine("State chenged from C to A");
        }
    }
}
