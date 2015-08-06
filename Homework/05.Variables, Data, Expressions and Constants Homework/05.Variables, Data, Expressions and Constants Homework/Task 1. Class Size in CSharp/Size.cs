namespace SizeApplication
{
    using System;

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotaed)
        {
            double cosOfAngle = Math.Cos(angleOfTheFigureThatWillBeRotaed);

            double sinOfAngle = Math.Sin(angleOfTheFigureThatWillBeRotaed);

            double newWidth = (Math.Abs(cosOfAngle) * size.Width) +
                (Math.Abs(sinOfAngle) * size.Height);

            double newHeight = (Math.Abs(sinOfAngle) * size.Width) +
                   (Math.Abs(cosOfAngle) * size.Height);

            Size rotatedSize = new Size(newWidth, newHeight);

            return rotatedSize;
        }
    }
}