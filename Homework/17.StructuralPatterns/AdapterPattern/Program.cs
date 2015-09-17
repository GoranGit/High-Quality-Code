using System;
namespace AdapterPattern
{
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
}
