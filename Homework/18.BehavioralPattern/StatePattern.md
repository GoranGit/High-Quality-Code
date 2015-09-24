# State Design Pattern #

## Intent ##
- Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
- An object-oriented state machine
- wrapper + polymorphic wrappee + collaboration
## Structure ##
![](https://sourcemaking.com/files/v2/content/patterns/State1-2x.png)
## Example ##

    public abstract class State
    {
        public abstract void Change(Context context);
    }

	 public class StateA:State
    {
        public override void Change(Context context)
        {
            context.State = new StateB();
            Console.WriteLine("Changed state from A to B!");
        }
    }

	public class StateB:State
    {
        public override void Change(Context context)
        {
            context.State = new StateC();
            Console.WriteLine("State changet from B to C!");
        }
    }

	public class StateC:State
    {
        public override void Change(Context context)
        {
            context.State = new StateA();
            Console.WriteLine("State chenged from C to A");
        }
    }

	
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