using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class Customers_CLS
    {
        private enum Enmode { add=0, update=1 }
        private Enmode _enmode= Enmode.update;
        public int CustomerID {  get; set; }
        public int PersonID { get; set; }
        public string DriverLicenseNumber { get; set; }

        public Persons_CLS PersonInfo { get; set; }

        public  Customers_CLS() 
        
        {
            this.CustomerID = -1;
            this.PersonID = -1;
            this.DriverLicenseNumber = "";
            _enmode = Enmode.add;
        }
        public Customers_CLS(int customerID, int personID, string driverLicenseNumber)
        {
            this.CustomerID = customerID;
            this.PersonID = personID;
            this.DriverLicenseNumber = driverLicenseNumber;
            _enmode = Enmode.update;
        }
        public static string NumberOfCustomers()
        {
            string customerCount = "";

            if (Customers_SQL.NumberOfCustomersSQL(ref customerCount))
            {
                return customerCount;
            }

            return null;
        }
        private bool _Update()
        {
            return (Customers_SQL.Update(this.CustomerID,this.PersonID,this.DriverLicenseNumber));
        }


        private bool _ADD()
        {
             
                
             this.PersonID=(Customers_SQL.ADD(this.PersonID, this.DriverLicenseNumber));

            return (this.PersonID!=-1);
        }

        public bool SAVE()
        {
            switch (this._enmode)
            {
                case Enmode.add: if (_ADD())
                    {
                        return true;
                    }
                else return false;
                case Enmode.update: return(_Update());

            }

            return false;

        }

        public static Customers_CLS FindByCustomerID(int CustomerID)
        {
            int personID = -1; string NumberLicenceDrive = "";

            if(Customers_SQL.FindByID(CustomerID,ref personID,ref NumberLicenceDrive))
            {
                return new Customers_CLS(CustomerID, personID, NumberLicenceDrive);
            }

            return null;
        }

        public static Customers_CLS FindByPersonID(int PersonID)
        {
            int CustomerID = -1; string NumberLicenceDrive = "";

            if (Customers_SQL.FindByPersonID(PersonID, ref CustomerID, ref NumberLicenceDrive))
            {
                return new Customers_CLS(CustomerID, PersonID, NumberLicenceDrive);
            }

            return null;
        }


        public static bool Delete(int CustomerID)
        {
            return Customers_SQL.Delete(CustomerID);
        }

        public static DataTable List()
        {
            return Customers_SQL.DatatablePerson();
        }

        public static bool IsExistByCustomerID(int CustomerID)
        {
            return (Customers_SQL.IsExistByIDCUSTOMER(CustomerID));
        }

        public static bool IsExistByPersonID(int PersonID)
        {
            return (Customers_SQL.IsExistByPersonID(PersonID));
        }

        public static bool IsDriverlicenceNumberExist(string Number)
        {
            return (Customers_SQL.IsalreadyExistthisDriverlocal(Number));
        }


    }
}
