using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class FlatRoof : Decorator
    {
        public FlatRoof(Building building)
            : base(building)
        {
        }
        public void ConstructFlatRoof()
        {
            Console.WriteLine("Flat roof constructed!");
        }

        public override void Display()
        {
            base.Display();
            ConstructFlatRoof();
        }
    }
}
