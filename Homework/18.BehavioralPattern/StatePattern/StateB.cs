using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class StateB:State
    {
        public override void Change(Context context)
        {
            context.State = new StateC();
            Console.WriteLine("State changet from B to C!");
        }
    }
}
