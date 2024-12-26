using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class FuleTypes_CLS
    {

        public int IdFuleType {  get; set; }
        public string NameFuleType { get; set; }

        public FuleTypes_CLS() 
        
        {
        this.IdFuleType = -1;
        this.NameFuleType = string.Empty;
        }
        public FuleTypes_CLS(int ID , string Namefuletype)

        {
            this.IdFuleType = ID;
            this.NameFuleType = Namefuletype;
        }

        public static DataTable List()
        {
            return FULETYPE_SQL.List();
        }

         public static FuleTypes_CLS FindByid(int ID)
        {
            string Name = "";

            if (FULETYPE_SQL.FindByID(ID, ref Name))
            {
                return new FuleTypes_CLS(ID, Name);
            }
            return null;
        }
        public static FuleTypes_CLS FindByName(string name)
        {
            int id = FULETYPE_SQL.FindFuelTypeIdByName(name);

            return id != -1 ? new FuleTypes_CLS(id, name) : null;
        }
    }
}
