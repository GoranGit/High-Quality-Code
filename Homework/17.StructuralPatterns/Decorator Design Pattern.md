# Decorator Design Pattern #

----------
## Intent ##
- Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
- Client-specified embellishment of a core object by recursively wrapping it.
- Wrapping a gift, putting it in a box, and wrapping the box.
## Problem ##
You want to add behavior or state to individual objects at run-time. Inheritance is not feasible because it is static and applies to an entire class.
## Structure ##
![](https://sourcemaking.com/files/v2/content/patterns/Decorator__1-2x.png)
## Example ##

    public abstract class Building
    {
        public int Area { get; set; }
        public float Height { get; set; }

        public abstract void Display();
    }


    public class CommercialBuilding:Building
    {
        public CommercialBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }
        public override void Display()
        {
            Console.WriteLine("A commercial building is a building that is used for commercial use. Types can include office buildings, warehouses, or retail (i.e. convenience stores, 'big box' stores, shopping malls, etc.).");
        }
    }

	public class EducationalBuilding : Building
    {
        public EducationalBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }

        public override void Display()
        {
            Console.WriteLine("Nursery and primary schools are usually single storey buildings of simple construction, where easy access and space flexibility are key. Secondary schools are larger, and cater for a greater number of pupils than primary schools, and therefore are often 2 or 3 storeys.");
        }
    }

	 public class IndustrialBuilding : Building
    {
        public IndustrialBuilding(int area, float height)
        {
            this.Area = area;
            this.Height = height;
        }

        public override void Display()
        {
            Console.WriteLine("Industrial architecture is the design and construction of buildings serving industry. Such buildings rose in importance with the industrial revolution, and were some of the pioneering structures of modern architecture.");
        }
    }

	public abstract class Decorator:Building
    {
        protected Decorator(Building building)
        {
            this.BuildingType = building;
        }

        public Building BuildingType { get; set; }

        public override void Display()
        {
            this.BuildingType.Display();
        }
    }

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
	
	public class PyramidalRoof:Decorator
    {
        public PyramidalRoof(Building building)
            : base(building)
        {
        }
    
        public void ConstructPyramidalRof()
        {
            Console.WriteLine("Pyramidal roof constructed!");
        }

        public override void Display()
        {
            base.Display();
            ConstructPyramidalRof();
        }
    }

	public class Program
    {
        static void Main(string[] args)
        {
            CommercialBuilding cityCenter = new CommercialBuilding(1000,20);
            cityCenter.Display();
            Console.WriteLine();
            EducationalBuilding school = new EducationalBuilding(500, 10);
            school.Display();
            Console.WriteLine();
            Console.WriteLine();
            // Commerfial building with different type  of roof
            FlatRoof cityCenterWithFlatRoof = new FlatRoof(cityCenter);
            cityCenterWithFlatRoof.Display();
            Console.WriteLine();
            PyramidalRoof cityCenteWithPyramidalRoof = new PyramidalRoof(cityCenter);
            cityCenteWithPyramidalRoof.Display();
            Console.WriteLine();
            //Educational building with different type of roof
            FlatRoof schoolWithFlatRoof = new FlatRoof(school);
            schoolWithFlatRoof.Display();
            Console.WriteLine();
            PyramidalRoof schoolWithPyramidalRoof = new PyramidalRoof(school);
            schoolWithPyramidalRoof.Display();
        }
    }