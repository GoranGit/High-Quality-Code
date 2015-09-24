using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class Context
    {
        public Context(State state)
        {
            this.State = state;
            Console.WriteLine("Initial state!");
        }

        public State State { get; set; }

        public void Request()
        {
            State.Change(this);
        }
    }
}
