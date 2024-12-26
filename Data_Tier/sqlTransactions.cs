using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class sqlTransactions
    {
            
        public static DataTable Datatablebooking()
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "   SELECT TransactionID , BookingID , PaidInitialTotalDueAmount, TransactionDate  ,ReturnID , ActualTotalDueAmount , TotalRefundedAmount,TotalRemaining  ,UpdatedTransactionDate,PaymentDetails, IsDone from Transactions";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return dt;
        }
        public static DataTable top5() 

        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = @"
    SELECT TOP 5 
        dbo.Booking.VehicleID, 
        Vehicle.Make, 
        Vehicle.Model, 
        Vehicle.PlateNumber, 
        SUM(dbo.Transactions.ActualTotalDueAmount) AS TotalRevenue
    FROM 
        dbo.Booking 
    INNER JOIN 
        dbo.Transactions ON dbo.Booking.BookingID = dbo.Transactions.BookingID
    INNER JOIN 
        Vehicle ON dbo.Booking.VehicleID = Vehicle.VehicleID
    GROUP BY 
        dbo.Booking.VehicleID, 
        Vehicle.Make, 
        Vehicle.Model, 
        Vehicle.PlateNumber
    ORDER BY 
        SUM(dbo.Transactions.ActualTotalDueAmount) DESC;
";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return dt;
        }


        public static bool IsExistByBookingID(int BookingID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = @"
                             SELECT * 
                             FROM Transactions 
                                 WHERE BookingID = @BookingID 
                                   AND ActualTotalDueAmount IS NOT NULL 
                                   AND TotalRemaining IS NOT NULL 
                                   AND TotalRefundedAmount IS NOT NULL 
                                   AND UpdatedTransactionDate IS NOT NULL";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
                else
                {
                    IsExist = false;
                }

            }
            catch (Exception ex) { }
            finally
            {
                sqlConnection.Close();
            }
            return IsExist;

        }
        public static bool IsDone(int TransactionID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "SELECT * FROM Transactions WHERE TransactionID = @TransactionID AND IsDone = 1";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    IsExist = true;
                }
                else
                {
                    IsExist = false;
                }

            }
            catch (Exception ex) { }
            finally
            {
                sqlConnection.Close();
            }
            return IsExist;

        }

        public static bool UpdateDONE(decimal TotalRemaining, int TransactionID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Transactions SET TotalRemaining = 0, TotalRefundedAmount = @TotalRemaining , PaymentDetails='Done' , IsDone = 1 WHERE TransactionID = @TransactionID ";





            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@TransactionID", TransactionID);
            cmd.Parameters.AddWithValue("@TotalRemaining", TotalRemaining);


            try
            {
                sqlConnection.Open();

                RowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }

            return (RowsAffected > 0);
        }
        public static bool FindByID(
    int transactionID,
    ref int bookingID,
    ref int returnID,
    ref decimal paidInitialTotalDueAmount,
    ref decimal actualTotalDueAmount,
    ref decimal totalRemaining,
    ref decimal totalRefundedAmount,
    ref DateTime transactionDate,
    ref DateTime updatedTransactionDate,
    ref string transactionType,
    ref bool isDone)
        {
            bool isExist = false;
            string connectionString = StringConnectionSQL.connectionString;

            // Correct SQL query to fetch data by transactionID
            string query = "SELECT * FROM Transactions WHERE TransactionID = @TransactionID";  // Make sure 'Transactions' is the correct table name

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@TransactionID", transactionID); // Correct parameter name

                try
                {
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isExist = true;

                            // Populate the 'ref' variables with the data from the database
                            returnID = reader.GetInt32(reader.GetOrdinal("ReturnID"));
                            bookingID = reader.GetInt32(reader.GetOrdinal("BookingID"));
                            paidInitialTotalDueAmount = reader.GetDecimal(reader.GetOrdinal("PaidInitialTotalDueAmount"));
                            actualTotalDueAmount = reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount"));
                            totalRemaining = reader.GetDecimal(reader.GetOrdinal("TotalRemaining"));
                            totalRefundedAmount = reader.GetDecimal(reader.GetOrdinal("TotalRefundedAmount"));
                            transactionDate = reader.GetDateTime(reader.GetOrdinal("TransactionDate"));
                            updatedTransactionDate = reader.GetDateTime(reader.GetOrdinal("UpdatedTransactionDate"));
                            transactionType = reader["TransactionType"] as string ?? string.Empty;
                            isDone = reader.GetBoolean(reader.GetOrdinal("IsDone"));
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    Console.WriteLine($"SQL error occurred: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return isExist;
        }




    }
}
