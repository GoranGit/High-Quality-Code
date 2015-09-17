namespace FacadePattern
{
    using System;

    public class EducationalBuilding : Building
    {
        public EducationalBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }

        public override void Display()
        {
            Console.WriteLine("EDUCATIONAL BUILDING CONSTRUCTED- Nursery and primary schools are usually single storey buildings of simple construction, where easy access and space flexibility are key. Secondary schools are larger, and cater for a greater number of pupils than primary schools, and therefore are often 2 or 3 storeys.");
        }
    }
}
