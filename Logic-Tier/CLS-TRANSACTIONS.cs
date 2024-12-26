using Data_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Tier
{
    public class CLS_TRANSACTIONS
    {
        public int TransactionID { get; set; }
        public int BookingID { get; set; }
        public int ReturnID { get; set; }
        public decimal PaidInitialTotalDueAmount { get; set; }
        public decimal ActualTotalDueAmount { get; set; }
        public decimal TotalRemaining { get; set; }
        public decimal TotalRefundedAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime UpdatedTransactionDate { get; set; }
        public string TransactionType { get; set; }
        public bool IsDone { get; set; }



        public CLS_TRANSACTIONS(int transactionID, int bookingID, int returnID, decimal paidInitialTotalDueAmount,
                            decimal actualTotalDueAmount, decimal totalRemaining, decimal totalRefundedAmount,
                            DateTime transactionDate, DateTime updatedTransactionDate, string transactionType, bool isDone)
        {
            this.TransactionID = transactionID;
            this.BookingID = bookingID;
            this.ReturnID = returnID;
            this.PaidInitialTotalDueAmount = paidInitialTotalDueAmount;
            this.ActualTotalDueAmount = actualTotalDueAmount;
            this.TotalRemaining = totalRemaining;
            this.TotalRefundedAmount = totalRefundedAmount;
            this.TransactionDate = transactionDate;
            this.UpdatedTransactionDate = updatedTransactionDate;
            this.TransactionType = transactionType;
            this.IsDone = isDone;
        }

        public CLS_TRANSACTIONS()

        {

            this.BookingID = -1;
            this.PaidInitialTotalDueAmount = -1;
            this.TransactionDate = DateTime.Now;
            this.TransactionType = "";
            this.IsDone = false;

        }

        public static CLS_TRANSACTIONS FindByID(int id)
        {
            int bookingID = -1;
            int returnID = -1;
            decimal paidInitialTotalDueAmount = 0m;
            decimal actualTotalDueAmount = 0m;
            decimal totalRemaining = 0m;
            decimal totalRefundedAmount = 0m;
            DateTime transactionDate = DateTime.MinValue;
            DateTime updatedTransactionDate = DateTime.MinValue;
            string transactionType = string.Empty;
            bool isDone = false;

            bool isFound = sqlTransactions.FindByID(
                id,
                ref bookingID,
                ref returnID,
                ref paidInitialTotalDueAmount,
                ref actualTotalDueAmount,
                ref totalRemaining,
                ref totalRefundedAmount,
                ref transactionDate,
                ref updatedTransactionDate,
                ref transactionType,
                ref isDone
            );

            if (isFound)
            {
                return new CLS_TRANSACTIONS(
                    id,
                    bookingID,
                    returnID,
                    paidInitialTotalDueAmount,
                    actualTotalDueAmount,
                    totalRemaining,
                    totalRefundedAmount,
                    transactionDate,
                    updatedTransactionDate,
                    transactionType,
                    isDone
                );
            }

            // Return null if no transaction is found
            return null;
        }
    

    public static DataTable Transactions()
        {
            return (sqlTransactions.Datatablebooking());
        }
        public static DataTable top5()
        {
            return (sqlTransactions.top5());
        }


        public static bool IsExistByBookingID(int BookingID)
        {
            
            return sqlTransactions.IsExistByBookingID(BookingID);
        }
        public bool UpdateDone()
        {
            return sqlTransactions.UpdateDONE(this.TotalRemaining,this.TransactionID);
        }
        public static bool Isdone(int TransactionID)
        {
            return sqlTransactions.IsDone(TransactionID);
        }

    }
}
