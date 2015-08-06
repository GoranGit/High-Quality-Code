namespace Task_1.Class_Chef_in_CSharp
{
    public class Carrot : Vegetable, IPeelable
    {
        public bool IsPilled { get; set; }

        public Carrot()
        {
            this.IsPilled = false;
        }
    }
}
