using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic_Tier.Persons_CLS;

namespace Logic_Tier
{
    public class Vehicules_CLS
    {
        private enum Enmode { add = 0, update = 1 }
        private Enmode _enmode = Enmode.update;
        public int VehiculeId {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int FuelTypeID { get; set; }
        public string PlateNumber { get; set; }
        public int CarCategoryID { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public bool IsAvailableForRent { get; set; }
        public CategoryVehicule_CLS CategoryVehicule { get; set; }
        public FuleTypes_CLS FuleType { get; set; }


        public static string NumberOfVehiclesAv()
        {

            string NumberOfVehiclesAv = "";


            if (Vehicules_SQL.VehicleAvailible(ref NumberOfVehiclesAv))
            {
                return NumberOfVehiclesAv;
            }

            return null;
        }
        public static string NumberOfVehiclesUnAv()
        {

            string NumberOfVehiclesUnAv = "";


            if (Vehicules_SQL.VehicleUNAVALAIBLE(ref NumberOfVehiclesUnAv))
            {
                return NumberOfVehiclesUnAv;
            }

            return null;
        }
        public Vehicules_CLS() 

        {
            this.VehiculeId = -1;
            this.Make = string.Empty;
            this.Model = string.Empty;
            this.Year = 0;
            this.Mileage = 0;
            this.FuelTypeID = 0;
            this.PlateNumber = string.Empty;
            this.CarCategoryID = 0;
            this.RentalPricePerDay =-1;
            this.IsAvailableForRent = false;
            this._enmode = Enmode.add;

        }
        public Vehicules_CLS(int VehiculeId, string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay, bool IsAvailableForRent) 
        {
            this.VehiculeId = VehiculeId;
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
            this.FuelTypeID = FuelTypeID;
            this.PlateNumber = PlateNumber;
            this.CarCategoryID = CarCategoryID;
            this.RentalPricePerDay= RentalPricePerDay;
            this.IsAvailableForRent = IsAvailableForRent;
            this.CategoryVehicule = CategoryVehicule_CLS.FindByid(CarCategoryID);
            this.FuleType = FuleTypes_CLS.FindByid(FuelTypeID);
            this._enmode = Enmode.update;
        }
        public static Vehicules_CLS FindByID(int ID)
        {
            string Make="";
            string Model = "";
            int Year=-1;
            int Mileage = -1;
            int FuelTypeID = -1;
            string PlateNumber = "";
            int CarCategoryID = -1;
            decimal RentalPricePerDay = -1;
            bool IsAvailableForRent=false;

            if (Vehicules_SQL.FindByID(ID, ref Make, ref Model, ref Year,ref Mileage, ref FuelTypeID, ref PlateNumber, ref CarCategoryID, ref RentalPricePerDay, ref IsAvailableForRent))
            {
                return new Vehicules_CLS(ID, Make, Model, Year, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent);
            }

            return null;
        }

        public static Vehicules_CLS FindByPlateNumber(string PlateNumber)
        {
            string Make = "";
            string Model = "";
            int Year = -1;
            int Mileage = -1;
            int FuelTypeID = -1;
            int VehiculeId = -1;
            int CarCategoryID = -1;
            decimal RentalPricePerDay1 = -1;
            bool IsAvailableForRent = false;

            if (Vehicules_SQL.FindByPlateNumber(PlateNumber, ref Make, ref Model, ref Year, ref Mileage, ref FuelTypeID, ref VehiculeId, ref CarCategoryID, ref RentalPricePerDay1, ref IsAvailableForRent))
            {
                return new Vehicules_CLS(VehiculeId, Make, Model, Year, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay1, IsAvailableForRent);
            }

            return null;
        }
        private static decimal _CalculTotalPricePerDay(decimal RentalPricePerDay, int days)
        {
            decimal total = RentalPricePerDay * days;
            return total;
        }

        private bool _Update()
        {
            return (Vehicules_SQL.Update(this.VehiculeId, this.Make, this.Model, this.Year, this.Mileage, this.FuelTypeID, this.PlateNumber, this.CarCategoryID, this.RentalPricePerDay, this.IsAvailableForRent));
        }


        private bool _ADD()
        {


            this.VehiculeId = (Vehicules_SQL.ADD(this.Make, this.Model, this.Year, this.Mileage, this.FuelTypeID, this.PlateNumber, this.CarCategoryID, this.RentalPricePerDay, this.IsAvailableForRent));

            return (this.VehiculeId != -1);
        }

        public bool SAVE()
        {
            switch (this._enmode)
            {
                case Enmode.add:
                    if (_ADD())
                    {
                        return true;
                    }
                    else return false;
                case Enmode.update: return (_Update());

            }

            return false;

        }
        public static bool Delete(int id)
        {
            return (Vehicules_SQL.Delete(id));
        }


        public static DataTable DataTable()
        {
            return (Vehicules_SQL.Datatable());
        }

        public static bool IsExistByPlateNumber(string Number)
        {
            return (Vehicules_SQL.IsExistByPlateNumber(Number));
        }

        public static bool VehiculeIsDisponibleOrNotByID(int id)
        {
            return (Vehicules_SQL.VehiculeIsDisponibleOrNotByID(id));
        }

        public bool VehiculeIsDisponibleOrNotByID()
        {
            return VehiculeIsDisponibleOrNotByID(this.VehiculeId);
        }

        public static bool VehiculeIsDisponibleOrNotByPlateNumber(string PlateNumber)
        {
            return (Vehicules_SQL.VehiculeIsDisponibleOrNotByPlateNumber(PlateNumber));
        }

        public bool VehiculeIsDisponibleOrNotByPlateNumber()
        {
            return VehiculeIsDisponibleOrNotByPlateNumber(this.PlateNumber);
        }



        public static bool UpdateDisponibility(int id , int Disbonibility)
        {
            return (Vehicules_SQL.UpdateDisponibility(id, Disbonibility));
        }

        public bool UpdateDisponibility(int Disbonibility)
        {
            return UpdateDisponibility(this.VehiculeId, Disbonibility);
        }




        public static bool ADDMileage(int id, int Mileage)
        {
            return (Vehicules_SQL.ADDMileage(id, Mileage));
        }

        public bool ADDMileage(int Mileage)
        {
            return ADDMileage(this.VehiculeId, Mileage);
        }



        public static decimal TotalPricePerDay(int ID, int Days)
            {
            decimal RentalPricePerDay = -1;

                if (Vehicules_SQL.PricePerDay(ID, ref RentalPricePerDay))
                {
                    return _CalculTotalPricePerDay(RentalPricePerDay, Days);
                }

                return 0;
            }

        public decimal TotalPricePerDay(int Days)
        {
            return TotalPricePerDay(this.VehiculeId, Days);
        }







    }
}
