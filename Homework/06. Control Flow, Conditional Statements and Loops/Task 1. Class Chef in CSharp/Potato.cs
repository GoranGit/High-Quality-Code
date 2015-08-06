namespace Task_1.Class_Chef_in_CSharp
{
    public class Potato : Vegetable, IPeelable
    {
        public bool IsPilled { get; set; }

        public bool IsRotten { get; set; }

        public Potato()
        {
            this.IsPilled = false;
            this.IsRotten = false;
        }
    }
}
