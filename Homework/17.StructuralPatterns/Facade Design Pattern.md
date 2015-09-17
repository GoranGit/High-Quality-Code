# Facade Design Pattern #

----------

## Intent ##
- Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
- Wrap a complicated subsystem with a simpler interface.

## Problem ##
A segment of the client community needs a simplified interface to the overall functionality of a complex subsystem.

## Discussion ##
Facade discusses encapsulating a complex subsystem within a single interface object. This reduces the learning curve necessary to successfully leverage the subsystem. It also promotes decoupling the subsystem from its potentially many clients. On the other hand, if the Facade is the only access point for the subsystem, it will limit the features and flexibility that "power users" may need.

The Facade object should be a fairly simple advocate or facilitator. It should not become an all-knowing oracle or "god" object.
## Structure ##
![](https://sourcemaking.com/files/v2/content/patterns/Facade1-2x.png)

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
            Console.WriteLine("COMMERCIAL BUILDING CONSTRUCTED - A commercial building is a building that is used for commercial use. Types can include office buildings, warehouses, or retail (i.e. convenience stores, 'big box' stores, shopping malls, etc.).");
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
            Console.WriteLine("EDUCATIONAL BUILDING CONSTRUCTED- Nursery and primary schools are usually single storey buildings of simple construction, where easy access and space flexibility are key. Secondary schools are larger, and cater for a greater number of pupils than primary schools, and therefore are often 2 or 3 storeys.");
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
            Console.WriteLine("INDUSTRIAL BUILDING CONSTRUCTED - Industrial architecture is the design and construction of buildings serving industry. Such buildings rose in importance with the industrial revolution, and were some of the pioneering structures of modern architecture.");
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

	public class Facade
    {
        private IList<Building> buildings;

        public Facade()
        {
            this.buildings = new List<Building>();
        }

        public void ConstructSchoolWithFlatRoof()
        {
            EducationalBuilding school = new EducationalBuilding(700, 10);
            FlatRoof schoolWithFlatRoof = new FlatRoof(school);
            buildings.Add(schoolWithFlatRoof);
        }

        public void ConstructCompanyWithPyramidalRoof()
        {
            IndustrialBuilding company = new IndustrialBuilding(1200, 15);
            PyramidalRoof companyWithPyramidalRoof = new PyramidalRoof(company);
            buildings.Add(companyWithPyramidalRoof);
        }

        public void ConstructMall()
        {
            CommercialBuilding mall = new CommercialBuilding(5000, 20);
            buildings.Add(mall);
        }

        public void ListAllConstructedBuildings()
        {
            for (var i = 0; i < buildings.Count; i++)
            {
                buildings[i].Display();
                Console.WriteLine();
            }
        }
    }

	public class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.ConstructCompanyWithPyramidalRoof();
            facade.ConstructMall();
            facade.ConstructSchoolWithFlatRoof();

            facade.ListAllConstructedBuildings();

            Console.ReadKey();
        }
    }