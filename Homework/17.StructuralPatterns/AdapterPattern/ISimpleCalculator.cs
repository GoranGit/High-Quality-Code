namespace AdapterPattern
{
    interface ISimpleCalculator
    {
        decimal AddNumbers(params decimal[] parameters);

        decimal MultiplyNumbers(params decimal[] parameters);
    }
}
