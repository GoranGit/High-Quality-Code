namespace AdapterPattern
{
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
}
