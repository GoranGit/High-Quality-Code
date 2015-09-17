namespace FacadePattern
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.ConstructCompanyWithPyramidalRoof();
            facade.ConstructMall();
            facade.ConstructSchoolWithFlatRoof();

            facade.ListAllConstructedBuildings();

            Console.ReadKey();
        }
    }
}
