using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class CategoryVehicule_CLS
    {
        public int IdCategoryVehicule { get; set; }
        public string CategoryVehicule { get; set; }

        public CategoryVehicule_CLS()

        {
            this.IdCategoryVehicule = -1;
            this.CategoryVehicule = string.Empty;
        }
        public CategoryVehicule_CLS(int ID, string Vehicule)

        {
            this.IdCategoryVehicule = ID;
            this.CategoryVehicule = Vehicule;
        }

        public static DataTable List()
        {
            return VehiculeCategory_SQL.List();
        }

        public static CategoryVehicule_CLS FindByid(int ID)
        {
            string Name = "";

            if (VehiculeCategory_SQL.FindByID(ID, ref Name))
            {
                return new CategoryVehicule_CLS(ID, Name);
            }
            return null;
        }
        public static CategoryVehicule_CLS FindByName(string name)
        {
            int categoryId = VehiculeCategory_SQL.FindCategoryIdByName(name);

            if (categoryId != -1)
            {
                return new CategoryVehicule_CLS(categoryId, name);
            }

            return null;
        }
    }
}
