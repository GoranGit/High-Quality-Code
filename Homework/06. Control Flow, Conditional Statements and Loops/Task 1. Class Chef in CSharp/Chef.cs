namespace Task_1.Class_Chef_in_CSharp
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl;
            this.Peel(potato);
            this.Peel(carrot);
            bowl = this.GetBowl();
            this.Cut(potato);
            this.Cut(carrot);
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            Console.WriteLine("Chef get patato!");
            return new Potato();
        }

        private void Peel(IPeelable vegetable)
        {
            Console.WriteLine("Chef peel " + vegetable.GetType().Name);
            vegetable.IsPilled = true;
        }

        private Bowl GetBowl()
        {
            Console.WriteLine("Chef get new bowl!");
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            Console.WriteLine("Chef get carrot!");
            return new Carrot();
        }

        private void Cut(ICutable vegetable)
        {
            Console.WriteLine("Chef cut " + vegetable.GetType().Name);
            vegetable.IsCutted = true;
        }
    }
}
