namespace DecorationPattern
{
    using System;

    public class IndustrialBuilding : Building
    {
        public IndustrialBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }

        public override void Display()
        {
            Console.WriteLine("Industrial architecture is the design and construction of buildings serving industry. Such buildings rose in importance with the industrial revolution, and were some of the pioneering structures of modern architecture.");
        }
    }
}
