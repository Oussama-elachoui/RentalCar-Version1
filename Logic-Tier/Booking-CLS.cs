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
    public class Booking_CLS
    {
        private enum ENMODE { ADD=1, Update=2}
        private ENMODE _enENMODE=ENMODE.ADD;
            
        public int BookingID {  get; set; }
        public int CustomerID { get; set; }
        public int VehicleId {  get; set; }
        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate {  get; set; }

        public string PickupLocation {  get; set; }
        public string  DropoffLocation {  get; set; }

        public byte InitialRentalDays {  get; set; }

        public decimal RentalPricePerDay {  get; set; }

        public decimal InitialTotalDueAmount {  get; set; }

        public string InitialCheckNotes {  get; set; }
        public Vehicules_CLS VehiculesInfo {  get; set; }

        public Customers_CLS Customers { get; set; }

        public bool _ADD()
        {
            int id;
            id =Booking_SQL.ADD(this.CustomerID,  this.VehicleId, this.RentalStartDate, this.RentalEndDate, this.PickupLocation, this.DropoffLocation, this.InitialRentalDays, this.RentalPricePerDay, this.InitialTotalDueAmount, this.InitialCheckNotes);
            return (id != -1);
        }
        public bool _UPDATE()
        {
            return (Booking_SQL.Update(this.BookingID, this.CustomerID, this.VehicleId, this.RentalStartDate, this.RentalEndDate, this.PickupLocation, this.DropoffLocation, this.InitialRentalDays, this.RentalPricePerDay, this.InitialTotalDueAmount, this.InitialCheckNotes));
        }

        public Booking_CLS() 

        {

            this.BookingID = -1;
            this.CustomerID = -1;
            this.VehicleId = -1;
            this.RentalStartDate = DateTime.Now;
            this.RentalEndDate = DateTime.Now;
            this.PickupLocation = "";
            this.DropoffLocation = "";
            this.InitialRentalDays = 0;
            this.RentalPricePerDay = -1;
            this.InitialTotalDueAmount = -1;
            this.InitialCheckNotes = "";
            _enENMODE = ENMODE.ADD;
        }
        public Booking_CLS(int BookingiD, int CustomeriD, int VehicleID, DateTime rentalStartDate, DateTime rentalEndDate, string pickupLocation, string dropoffLocation , byte initialRentalDays, decimal rentalPricePerDay, decimal initialTotalDueAmount, string initialCheckNotes) 
        {
            this.BookingID = BookingiD;
            this.CustomerID = CustomeriD;
            this.VehicleId = VehicleID;
            this.RentalStartDate = rentalStartDate;
            this.RentalEndDate= rentalEndDate;
            this.PickupLocation = pickupLocation;
            this.DropoffLocation = dropoffLocation;
            this.InitialRentalDays = initialRentalDays;
            this.RentalPricePerDay = rentalPricePerDay;
            this.InitialTotalDueAmount = initialTotalDueAmount;
            this.InitialCheckNotes = initialCheckNotes;
            _enENMODE = ENMODE.Update;
            this.Customers= Customers_CLS.FindByCustomerID(CustomeriD);
            this.VehiculesInfo = Vehicules_CLS.FindByID(this.VehicleId);


        }



        public bool save()
        {
            switch (this._enENMODE)
            {
                case ENMODE.ADD:
                    if (_ADD())
                    {  
                            return true;
                            _enENMODE = ENMODE.Update; 
                    }
                    else
                    {
                        return false;
                    }

                case ENMODE.Update: return (_UPDATE());

            }

            return false;

        }

        public static Booking_CLS FindByid(int BookingiD)
        {
            int customerID = -1;
            int vehicleId = -1;
            DateTime rentalStartDate = DateTime.Now;
            DateTime rentalEndDate = DateTime.Now;
            string pickupLocation = "";
            string dropoffLocation = "";
            byte initialRentalDays = 0;
            decimal rentalPricePerDay = -1;
            decimal initialTotalDueAmount = -1;
            string initialCheckNotes = "";

            if (Booking_SQL.FindByID(BookingiD, ref customerID, ref vehicleId, ref rentalStartDate, ref rentalEndDate, ref pickupLocation, ref dropoffLocation, ref initialRentalDays, ref rentalPricePerDay, ref initialTotalDueAmount, ref initialCheckNotes))
            {
                return new Booking_CLS(BookingiD, customerID, vehicleId, rentalStartDate, rentalEndDate, pickupLocation, dropoffLocation, initialRentalDays, rentalPricePerDay, initialTotalDueAmount, initialCheckNotes);
            }

            return null;
        }
        public static string NumberOfbooking()
        {

            string NumberOfbooking = "";
            

            if (Booking_SQL.NumberOfBookings(ref NumberOfbooking))
            {
                return NumberOfbooking;
            }

            return null;
        }

        public static DataTable List()
        {
            return Booking_SQL.Datatablebooking();
        }

        public static bool Delete(int delete)
        {
            return (Booking_SQL.Delete(delete));

        }
    }
}
