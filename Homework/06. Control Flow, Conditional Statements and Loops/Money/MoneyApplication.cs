namespace Money
{
    using System;

    public class MoneyApplication
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            decimal pricePerRealm = decimal.Parse(Console.ReadLine());

            decimal realms = (decimal)(numberOfStudents * sheetsPerStudent) / 400;
            int integerNumberOfRealms = (int)realms;
            decimal restOfRealms = realms - integerNumberOfRealms;
            decimal result = (decimal)(integerNumberOfRealms * pricePerRealm) + (restOfRealms * pricePerRealm);
           
            Console.WriteLine("{0:F3}", result);
        }
    }
}
