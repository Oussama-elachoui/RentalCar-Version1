using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class Booking_SQL
    {
        public static int ADD(int CustomerID, int VehicleId, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay, decimal InitialTotalDueAmount, string InitialCheckNotes)
        {
            int BookingID = -1;

            string query = @"
                          INSERT INTO Booking (CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes)
                         VALUES (@CustomerID, @VehicleId, @RentalStartDate, @RentalEndDate, @PickupLocation, @DropoffLocation, @InitialRentalDays, @RentalPricePerDay, @InitialTotalDueAmount, @InitialCheckNotes);
                         SELECT SCOPE_IDENTITY();";

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, sqlConnection);

                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@VehicleId", VehicleId);
                cmd.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
                cmd.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
                cmd.Parameters.AddWithValue("@PickupLocation", PickupLocation);
                cmd.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
                cmd.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
                cmd.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
                cmd.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
                cmd.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);

                try
                {
                    sqlConnection.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int insertedBookingID))
                    {
                        BookingID = insertedBookingID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return BookingID;
        }

        public static bool Update(int BookingID,int CustomerID, int VehicleId, DateTime RentalStartDate, DateTime RentalEndDate, string PickupLocation, string DropoffLocation, byte InitialRentalDays, decimal RentalPricePerDay, decimal InitialTotalDueAmount, string InitialCheckNotes)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Booking SET CustomerID = @CustomerID, VehicleId = @VehicleId," +
                "RentalStartDate = @RentalStartDate,RentalEndDate = @RentalEndDate,PickupLocation = @PickupLocation,DropoffLocation = @DropoffLocation," +
                "InitialRentalDays = @InitialRentalDays,RentalPricePerDay = @RentalPricePerDay,InitialTotalDueAmount = @InitialTotalDueAmount,InitialCheckNotes = @InitialCheckNotes" +
                " WHERE BookingID = @BookingID";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@BookingID", BookingID);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@VehicleId", VehicleId);
            cmd.Parameters.AddWithValue("@RentalStartDate", RentalStartDate);
            cmd.Parameters.AddWithValue("@RentalEndDate", RentalEndDate);
            cmd.Parameters.AddWithValue("@PickupLocation", PickupLocation);
            cmd.Parameters.AddWithValue("@DropoffLocation", DropoffLocation);
            cmd.Parameters.AddWithValue("@InitialRentalDays", InitialRentalDays);
            cmd.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            cmd.Parameters.AddWithValue("@InitialTotalDueAmount", InitialTotalDueAmount);
            cmd.Parameters.AddWithValue("@InitialCheckNotes", InitialCheckNotes);


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
        public static bool Delete(int BookingID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete from Booking where BookingID = @BookingID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@BookingID", BookingID);


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

        public static bool FindByID(int BookingID, ref int CustomerID, ref int VehicleId, ref DateTime RentalStartDate, ref DateTime RentalEndDate, ref string PickupLocation, ref string DropoffLocation, ref byte InitialRentalDays, ref decimal RentalPricePerDay, ref decimal InitialTotalDueAmount, ref string InitialCheckNotes)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Booking WHERE BookingID = @BookingID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@BookingID", BookingID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //ref string PickupLocation, ref string DropoffLocation, ref byte InitialRentalDays, ref decimal RentalPricePerDay,
                    //    ref decimal InitialTotalDueAmount, ref string InitialCheckNotes

                    IsExist = true;
                    CustomerID = (int)reader["CustomerID"];
                    VehicleId = (int)reader["VehicleId"];
                    RentalStartDate = (DateTime)reader["RentalStartDate"];
                    RentalEndDate = (DateTime)reader["RentalEndDate"];
                    PickupLocation = (string)reader["PickupLocation"];
                    DropoffLocation = (string)reader["DropoffLocation"];
                    InitialRentalDays = (byte)reader["InitialRentalDays"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    InitialTotalDueAmount = (decimal)reader["InitialTotalDueAmount"];
                    InitialCheckNotes = (string)reader["InitialCheckNotes"];




                    reader.Close();

                }

            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                sqlConnection.Close();
            }

            return IsExist;
        }
        public static bool NumberOfBookings(ref string NumberOfBookings) 
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumberOfBookings FROM dbo.Booking;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int Num = -1;
                    IsExist = true;
                    Num = (int)reader["NumberOfBookings"];

                    reader.Close();

                    NumberOfBookings = Num.ToString();
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

        public static DataTable Datatablebooking()
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "SELECT Booking.BookingID, PersonInfo.Fullname, PersonInfo.NationalityID, Vehicle.Make,    Vehicle.Model,    Booking.InitialRentalDays,    Booking.InitialTotalDueAmount FROM     (SELECT Fullname = FistName + ' ' + LastName,NationalityID,     DriverLicenseNumber, Customers.CustomerID FROM Persons INNER JOIN Customers ON Persons.IDPerson = Customers.PersonID    ) AS PersonInfo INNER JOIN Booking  ON Booking.CustomerID = PersonInfo.CustomerID INNER JOIN Vehicle  ON Booking.VehicleID = Vehicle.VehicleID";
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
