namespace DecorationPattern
{
    using System;

    public abstract class Building
    {
        public int Area { get; set; }
        public float Height { get; set; }

        public abstract void Display();
    }
}
