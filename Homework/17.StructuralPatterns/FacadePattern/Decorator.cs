namespace FacadePattern
{
    using System;

    public abstract class Decorator:Building
    {
        protected Decorator(Building building)
        {
            this.BuildingType = building;
        }

        public Building BuildingType { get; set; }

        public override void Display()
        {
            this.BuildingType.Display();
        }
    }
}
