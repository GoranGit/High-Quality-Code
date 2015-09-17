namespace FacadePattern
{
    using System;

    public class CommercialBuilding:Building
    {
        public CommercialBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }
        public override void Display()
        {
            Console.WriteLine("COMMERCIAL BUILDING CONSTRUCTED - A commercial building is a building that is used for commercial use. Types can include office buildings, warehouses, or retail (i.e. convenience stores, 'big box' stores, shopping malls, etc.).");
        }
    }
}
