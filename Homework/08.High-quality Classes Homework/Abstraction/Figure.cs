namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("I am a " + this.GetType().Name + " My perimeter is {0:f2}. My surface is {1:f2}.", this.CalculatePerimeter(), this.CalculateSurface());
        }
    }
}
