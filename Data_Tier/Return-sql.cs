using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class Return_sql
    {
        public static int ADD(DateTime ActualReturnDate, int ActualRentalDays,int Mileage,int ConsumedMileage,string FinalCheckNotes,decimal AdditionalCharges, decimal ActualTotalDueAmount)
        {
            int ReturnID = -1;

            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "insert into Returns (ActualReturnDate,ActualRentalDays,Mileage,ConsumedMileage,FinalCheckNotes,AdditionalCharges,ActualTotalDueAmount) values (@ActualReturnDate,@ActualRentalDays,@Mileage,@ConsumedMileage,@FinalCheckNotes,@AdditionalCharges,@ActualTotalDueAmount) SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            cmd.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            cmd.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
            cmd.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            cmd.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InserID))
                {

                    ReturnID = InserID;
                }

            }
            catch (Exception ex) { }
            finally
            {
                sqlConnection.Close();
            }
            return ReturnID;
        }
        public static bool Update(int ReturnID,DateTime ActualReturnDate, int ActualRentalDays, int Mileage, int ConsumedMileage, string FinalCheckNotes, decimal AdditionalCharges, decimal ActualTotalDueAmount)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = @"
                             UPDATE Returns 
                             SET ActualReturnDate = @ActualReturnDate,
                             ActualRentalDays = @ActualRentalDays,
                             Mileage = @Mileage,
                             ConsumedMileage = @ConsumedMileage,
                             FinalCheckNotes = @FinalCheckNotes,
                             AdditionalCharges = @AdditionalCharges,
                             ActualTotalDueAmount = @ActualTotalDueAmount
                             WHERE ReturnID = @ReturnID;";


            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@ReturnID", ReturnID);
            cmd.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
            cmd.Parameters.AddWithValue("@ActualRentalDays", ActualRentalDays);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@ConsumedMileage", ConsumedMileage);
            cmd.Parameters.AddWithValue("@FinalCheckNotes", FinalCheckNotes);
            cmd.Parameters.AddWithValue("@AdditionalCharges", AdditionalCharges);
            cmd.Parameters.AddWithValue("@ActualTotalDueAmount", ActualTotalDueAmount);


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
        public static bool Delete(int ReturnID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete from Returns where ReturenID = @ReturenID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@ReturenID", ReturnID);


            try
            {
                sqlConnection.Open();
                RowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally { sqlConnection.Close(); }

            return (RowsAffected > 0);
        }

        public static bool FindByID(int ReturnID, ref DateTime ActualReturnDate, ref byte ActualRentalDays,
                            ref short Mileage, ref short ConsumedMileage, ref string FinalCheckNotes,
                            ref decimal AdditionalCharges, ref decimal ActualTotalDueAmount)
        {
            bool IsExist = false;
            string connectionString = StringConnectionSQL.connectionString;

            // Correct SQL query
            string query = "SELECT * FROM Returns WHERE ReturenID = @ReturnID";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@ReturnID", ReturnID);

                try
                {
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsExist = true;

                            // Safely retrieve data and convert to appropriate types
                            ActualReturnDate = reader.GetDateTime(reader.GetOrdinal("ActualReturnDate"));
                            ActualRentalDays = reader.GetByte(reader.GetOrdinal("ActualRentalDays")); // tinyint → byte
                            Mileage = reader.GetInt16(reader.GetOrdinal("Mileage")); // smallint → short
                            ConsumedMileage = reader.GetInt16(reader.GetOrdinal("ConsumedMileage")); // smallint → short
                            FinalCheckNotes = reader["FinalCheckNotes"] as string ?? string.Empty;
                            AdditionalCharges = reader.GetDecimal(reader.GetOrdinal("AdditionalCharges"));
                            ActualTotalDueAmount = reader.GetDecimal(reader.GetOrdinal("ActualTotalDueAmount"));
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Log SQL-specific errors
                    Console.WriteLine($"SQL error occurred: {sqlEx.Message}");
                }
                catch (Exception ex)
                {
                    // Log other exceptions
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return IsExist;
        }
        public static bool NumberOfReturns(ref string NumberOfReturns)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumberOfReturns FROM dbo.Returns";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    int num = -1;
                    IsExist = true;
                    num = (int)reader["NumberOfReturns"];
                    NumberOfReturns = num.ToString();

                    reader.Close();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

            return IsExist;
        }


        public static bool TransactionsUpdateReturn(int BookingID, int ReturnID, decimal ActualTotalDueAmount, decimal TotalRemaining, decimal Refunded, DateTime UpdateDatetime)
        {
            int rowsAffected = 0;
            string connectionString = StringConnectionSQL.connectionString;

            string query = @"
                         UPDATE Transactions 
                            SET 
                                 ReturnID = @ReturnID,
                                 ActualTotalDueAmount = @ActualTotalDueAmount,
                                 TotalRemaining = @TotalRemaining,
                                 TotalRefundedAmount = @Refunded,
                                 UpdatedTransactionDate = @UpdateDatetime
                             WHERE BookingID = @BookingID;";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    // Adding parameters
                    cmd.Parameters.Add(new SqlParameter("@BookingID", SqlDbType.Int) { Value = BookingID });
                    cmd.Parameters.Add(new SqlParameter("@ReturnID", SqlDbType.Int) { Value = ReturnID });
                    cmd.Parameters.Add(new SqlParameter("@ActualTotalDueAmount", SqlDbType.Decimal) { Value = ActualTotalDueAmount });
                    cmd.Parameters.Add(new SqlParameter("@TotalRemaining", SqlDbType.Decimal) { Value = TotalRemaining });
                    cmd.Parameters.Add(new SqlParameter("@Refunded", SqlDbType.Decimal) { Value = Refunded });
                    cmd.Parameters.Add(new SqlParameter("@UpdateDatetime", SqlDbType.DateTime) { Value = UpdateDatetime });

                    try
                    {
                        sqlConnection.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                        Console.WriteLine($"SQL Error: {sqlEx.Message}");
                        throw;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        throw;
                    }
                }
            }

            return rowsAffected > 0;
        }

        public static DataTable DatatableReturn()
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "SELECT ReturenID, CONVERT(DATE, ActualReturnDate) AS ActualReturnDate,     ActualRentalDays,     ActualTotalDueAmount FROM Returns;";
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





    }
}
