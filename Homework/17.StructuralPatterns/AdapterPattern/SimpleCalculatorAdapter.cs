namespace AdapterPattern
{
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
}
