namespace FacadePattern
{
    using System;
    using System.Collections.Generic;

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
}
