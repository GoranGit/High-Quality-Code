namespace Prototype
{
    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
}
