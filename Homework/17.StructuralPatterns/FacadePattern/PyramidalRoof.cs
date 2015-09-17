namespace FacadePattern
{
    using System;

    public class PyramidalRoof:Decorator
    {
        public PyramidalRoof(Building building)
            : base(building)
        {
        }
    
        public void ConstructPyramidalRof()
        {
            Console.WriteLine("Pyramidal roof constructed!");
        }

        public override void Display()
        {
            base.Display();
            ConstructPyramidalRof();
        }
    }
}
