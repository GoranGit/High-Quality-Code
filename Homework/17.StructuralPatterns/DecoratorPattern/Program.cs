namespace DecorationPattern
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            CommercialBuilding cityCenter = new CommercialBuilding(1000,20);
            cityCenter.Display();
            Console.WriteLine();
            EducationalBuilding school = new EducationalBuilding(500, 10);
            school.Display();
            Console.WriteLine();
            Console.WriteLine();
            // Commerfial building with different type  of roof
            FlatRoof cityCenterWithFlatRoof = new FlatRoof(cityCenter);
            cityCenterWithFlatRoof.Display();
            Console.WriteLine();
            PyramidalRoof cityCenteWithPyramidalRoof = new PyramidalRoof(cityCenter);
            cityCenteWithPyramidalRoof.Display();
            Console.WriteLine();
            //Educational building with different type of roof
            FlatRoof schoolWithFlatRoof = new FlatRoof(school);
            schoolWithFlatRoof.Display();
            Console.WriteLine();
            PyramidalRoof schoolWithPyramidalRoof = new PyramidalRoof(school);
            schoolWithPyramidalRoof.Display();
        }
    }
}
