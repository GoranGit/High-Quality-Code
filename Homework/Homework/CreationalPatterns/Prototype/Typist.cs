namespace Prototype
{
    public class Typist : Employee
    {
        public int WordsPerMinute { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
