namespace Task_1.Class_Chef_in_CSharp
{
    public abstract class Vegetable : ICutable
    {
        public bool IsCutted { get; set; }

        public Vegetable()
        {
            this.IsCutted = false;
        }
    }
}
