namespace CohesionAndCoupling
{
    using System;

    public class RectangularPrism
    {
        private IDistanceCalculator distanceCalculator;

        public RectangularPrism(IDistanceCalculator d)
            : this(d, 0, 0, 0)
        {
        }

        public RectangularPrism(IDistanceCalculator distanceCalc, double width, double height, double depth)
        {
            this.distanceCalculator = distanceCalc;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = this.distanceCalculator.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = this.distanceCalculator.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
