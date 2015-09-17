# Adapter Design Pattern #

----------

## Intent ##

- Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
- Wrap an existing class with a new interface.
- Impedance match an old component to a new system

## Problem ##
An "off the shelf" component offers compelling functionality that you would like to reuse, but its "view of the world" is not compatible with the philosophy and architecture of the system currently being developed.

## Discussion ##
Reuse has always been painful and elusive. One reason has been the tribulation of designing something new, while reusing something old. There is always something not quite right between the old and the new. It may be physical dimensions or misalignment. It may be timing or synchronization. It may be unfortunate assumptions or competing standards.

It is like the problem of inserting a new three-prong electrical plug in an old two-prong wall outlet – some kind of adapter or intermediary is necessary. 	
Adapter is about creating an intermediary abstraction that translates, or maps, the old component to the new system. Clients call methods on the Adapter object which redirects them into calls to the legacy component. This strategy can be implemented either with inheritance or with aggregation.

Adapter functions as a wrapper or modifier of an existing class. It provides a different or translated view of that class.
## Structure ##
![](https://upload.wikimedia.org/wikipedia/commons/thumb/d/d7/ObjectAdapter.png/300px-ObjectAdapter.png)
## Example ##
	interface IAdvancedCalculator
    {
        decimal AddNumbers(params decimal[] parameters);

        decimal MultiplyNumbers(params decimal[] parameters);

        decimal SquareRoot(decimal x);

        decimal SubtractNumbers(params decimal[] parameters);

        decimal DivideNumbers(params decimal[] parameters);

        decimal Sin(decimal x);

        decimal Cos(decimal x);

        decimal Tan(decimal x);
    }

	public class AdvancedCalculator:IAdvancedCalculator
    {
        public decimal AddNumbers(params decimal[] parameters)
        {
            decimal sum = 0;
            foreach(decimal p in parameters)
            {
                sum += p;
            }
            return sum;
        }

        public decimal MultiplyNumbers(params decimal[] parameters)
        {
            decimal prod = 1;
            foreach (decimal p in parameters)
            {
                prod *= p;
            }
            return prod;
        }

        public decimal SquareRoot(decimal x)
        {
            throw new System.NotImplementedException();
        }

        public decimal SubtractNumbers(params decimal[] parameters)
        {
            throw new System.NotImplementedException();
        }

        public decimal DivideNumbers(params decimal[] parameters)
        {
            throw new System.NotImplementedException();
        }

        public decimal Sin(decimal x)
        {
            throw new System.NotImplementedException();
        }

        public decimal Cos(decimal x)
        {
            throw new System.NotImplementedException();
        }

        public decimal Tan(decimal x)
        {
            throw new System.NotImplementedException();
        }
    }

	 interface ISimpleCalculator
    {
        decimal AddNumbers(params decimal[] parameters);

        decimal MultiplyNumbers(params decimal[] parameters);
    }

	 public class SimpleCalculatorAdapter:ISimpleCalculator
    {
        private IAdvancedCalculator calc;
        public SimpleCalculatorAdapter()
        {
            calc = new AdvancedCalculator();
        }

        public decimal AddNumbers(params decimal[] parameters)
        {
            return calc.AddNumbers(parameters);
        }

        public decimal MultiplyNumbers(params decimal[] parameters)
        {
            return calc.MultiplyNumbers(parameters);
        }
    }

	public class Program
    {
        static void Main()
        {
           ISimpleCalculator calc = new SimpleCalculatorAdapter();

           var sum =  calc.AddNumbers(2.5m, 3.5m,3m);
           var prod = calc.MultiplyNumbers(2.5m, 3.5m, 3m);

           Console.WriteLine("Sum is:" + sum);
           Console.WriteLine("Product is:" + prod);
        }
    }