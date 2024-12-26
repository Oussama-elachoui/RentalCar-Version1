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

    public class Return_CLS
    {
        private enum ENMODE { add = 2, update = 1 }
        private ENMODE _enENMODE = ENMODE.add;
        public int ReturenID { get; set; }                
        public DateTime ActualReturnDate { get; set; }     
        public byte ActualRentalDays { get; set; }        
        public short Mileage { get; set; }                
        public short ConsumedMileage { get; set; }         
        public string FinalCheckNotes { get; set; }        
        public decimal AdditionalCharges { get; set; }     
        public decimal ActualTotalDueAmount { get; set; } 

        public Return_CLS(int returnID, DateTime actualReturnDate, byte actualRentalDays, short mileage,
                          short consumedMileage, string finalCheckNotes, decimal additionalCharges,
                          decimal actualTotalDueAmount)
        {
            this.ReturenID = returnID;
            this.ActualReturnDate = actualReturnDate;
            this.ActualRentalDays = actualRentalDays;
            this.Mileage = mileage;
            this.ConsumedMileage = consumedMileage;
            this.FinalCheckNotes = finalCheckNotes;
            this.AdditionalCharges = additionalCharges;
            this.ActualTotalDueAmount = actualTotalDueAmount;
            _enENMODE = ENMODE.update;
        }
        public Return_CLS()
        {
            this.ReturenID = -1;
            this.ActualReturnDate = DateTime.Now;
            this.ActualRentalDays = 0;
            this.Mileage = -1;
            this.ConsumedMileage = -1;
            this.FinalCheckNotes = "";
            this.AdditionalCharges = 0;
            this.ActualTotalDueAmount = 0;
            _enENMODE = ENMODE.add;
        }
        public static string NumberOfbooking()
        {

            string NumberOfreturn = "";


            if (Return_sql.NumberOfReturns(ref NumberOfreturn))
            {
                return NumberOfreturn;
            }

            return null;
        }

        public static Return_CLS FindByID(int id)
        {
            DateTime actualReturnDate = DateTime.Now ;
            byte actualRentalDays = 0; short mileage = -1, consumedMileage = -1;
            string finalCheckNotes = "";
            decimal additionalCharges = -1, actualTotalDueAmount = -1;

            if (Return_sql.FindByID(id, ref actualReturnDate, ref actualRentalDays, ref mileage, ref consumedMileage,
                                    ref finalCheckNotes, ref additionalCharges, ref actualTotalDueAmount))
            {
                return new Return_CLS(id, actualReturnDate,actualRentalDays, mileage, consumedMileage,
                                      finalCheckNotes, additionalCharges, actualTotalDueAmount);
            }
            else
            {
                return null;
            }
        }

        private bool _ADD()
        {
            this.ReturenID = Return_sql.ADD(this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMileage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);
            if(this.ReturenID != -1)
            {
                return true;
            }
            else return false;
        }
        private bool _Update()
        {
            return Return_sql.Update(this.ReturenID, this.ActualReturnDate, this.ActualRentalDays, this.Mileage, this.ConsumedMileage, this.FinalCheckNotes, this.AdditionalCharges, this.ActualTotalDueAmount);
        }

        public bool save()
        {
            switch (this._enENMODE)
            {
                case ENMODE.add:
                    if (_ADD())
                    {
                        return true;
                        _enENMODE = ENMODE.update;
                    }
                    else
                    {
                        return false;
                    }

                case ENMODE.update: return (_Update());

            }

            return false;

        }
        public static bool Delete(int Id)
        {
            return Return_sql.Delete(Id);
        }
        private decimal CALUCULTOTOLREMAINIG(decimal ActualTotalDueAmount , decimal FinalTotalDueAmount)
        {
            decimal Result = ActualTotalDueAmount - FinalTotalDueAmount;

            return Result;

        }
        public bool TransactionUpdateByreturn(int BookingID)
        {
            Booking_CLS bookingInfo = Booking_CLS.FindByid(BookingID);
            decimal TotalRemaining = CALUCULTOTOLREMAINIG(bookingInfo.InitialTotalDueAmount, this.ActualTotalDueAmount);
            return Return_sql.TransactionsUpdateReturn(BookingID, this.ReturenID, this.ActualTotalDueAmount, TotalRemaining, 0, DateTime.Now);
        }
        public static DataTable TableReturn()
        {
            return Return_sql.DatatableReturn();
        }

    }
}

