namespace CohesionAndCoupling
{
    using System;

   public class UtilsExamples
    {
       public static void Main()
        {
            FileNameExtractor fileNameExtractor = new FileNameExtractor();

            Console.WriteLine(fileNameExtractor.GetFileExtension("example"));
            Console.WriteLine(fileNameExtractor.GetFileExtension("example.pdf"));
            Console.WriteLine(fileNameExtractor.GetFileExtension("example.new.pdf"));
            Console.WriteLine(fileNameExtractor.GetFileNameWithoutExtension("example"));
            Console.WriteLine(fileNameExtractor.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(fileNameExtractor.GetFileNameWithoutExtension("example.new.pdf"));

            DistanceCalculator distanceCalculator = new DistanceCalculator();

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                distanceCalculator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                distanceCalculator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            RectangularPrism prism = new RectangularPrism(distanceCalculator, 3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", prism.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", prism.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", prism.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", prism.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", prism.CalcDiagonalYZ());
        }
    }
}
