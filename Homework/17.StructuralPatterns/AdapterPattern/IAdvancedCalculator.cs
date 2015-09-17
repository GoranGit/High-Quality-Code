namespace AdapterPattern
{
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
}
