namespace Task_1.Class_Chef_in_CSharp
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Bowl
    {
        private IList vegetablesInBowl;

        public Bowl()
        {
            this.vegetablesInBowl = new List<Vegetable>();
        }

        public void Add(Vegetable vegetable)
        {
            this.vegetablesInBowl.Add(vegetable);
        }
    }
}
