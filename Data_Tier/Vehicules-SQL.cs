using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace Data_Tier
{
    public class Vehicules_SQL
    {
        public static int ADD(string Make, string Model,int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay,bool IsAvailableForRent)
        {
            int VehicleID = -1;

            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "insert into Vehicle (Make,Model,Year,Mileage,FuelTypeID,PlateNumber,CarCategoryID,RentalPricePerDay,IsAvailableForRent) values (@Make,@Model,@Year,@Mileage,@FuelTypeID,@PlateNumber,@CarCategoryID,@RentalPricePerDay,@IsAvailableForRent) SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Make", Make);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            cmd.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
            cmd.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            cmd.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InserID))
                {

                    VehicleID = InserID;
                }

            }
            catch (Exception ex) { }
            finally
            {
                sqlConnection.Close();
            }
            return VehicleID;
        }
        public static bool Update(int VehicleID, string Make, string Model, int Year, int Mileage, int FuelTypeID, string PlateNumber, int CarCategoryID, decimal RentalPricePerDay, bool IsAvailableForRent)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Vehicle SET Make = @Make, Model = @Model , Year = @Year , Mileage = @Mileage , FuelTypeID = @FuelTypeID , PlateNumber = @PlateNumber , CarCategoryID = @CarCategoryID , RentalPricePerDay = @RentalPricePerDay ,IsAvailableForRent=@IsAvailableForRent WHERE VehicleID = @VehicleID";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@Make", Make);
            cmd.Parameters.AddWithValue("@Model", Model);
            cmd.Parameters.AddWithValue("@Year", Year);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);
            cmd.Parameters.AddWithValue("@FuelTypeID", FuelTypeID);
            cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);
            cmd.Parameters.AddWithValue("@CarCategoryID", CarCategoryID);
            cmd.Parameters.AddWithValue("@RentalPricePerDay", RentalPricePerDay);
            cmd.Parameters.AddWithValue("@IsAvailableForRent", IsAvailableForRent);


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
        public static bool Delete(int VehicleID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete from Vehicle where VehicleID = @VehicleID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);


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

        public static bool FindByID(int VehicleID, ref string Make, ref string Model, ref int Year, ref int Mileage, ref int FuelTypeID, ref string PlateNumber, ref int CarCategoryID, ref decimal RentalPricePerDay, ref bool IsAvailableForRent)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Vehicle WHERE VehicleID = @VehicleID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    PlateNumber = (string)reader["PlateNumber"];
                    CarCategoryID = (int)reader["CarCategoryID"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    IsAvailableForRent = (bool)reader["IsAvailableForRent"];


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
        public static bool FindByPlateNumber(string PlateNumber, ref string Make, ref string Model, ref int Year, ref int Mileage, ref int FuelTypeID, ref int VehicleID, ref int CarCategoryID, ref decimal RentalPricePerDay, ref bool IsAvailableForRent)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Vehicle WHERE PlateNumber = @PlateNumber";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PlateNumber", PlateNumber);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    Make = (string)reader["Make"];
                    Model = (string)reader["Model"];
                    Year = (int)reader["Year"];
                    Mileage = (int)reader["Mileage"];
                    FuelTypeID = (int)reader["FuelTypeID"];
                    VehicleID = (int)reader["VehicleID"];
                    CarCategoryID = (int)reader["CarCategoryID"];
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];
                    IsAvailableForRent = (bool)reader["IsAvailableForRent"];


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

        public static bool IsExistByPlateNumber(string PlateNumber)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Vehicle where PlateNumber=@PlateNumber;";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PlateNumber", PlateNumber);

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

        public static bool VehiculeIsDisponibleOrNotByID(int VehicleID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select 1 from Vehicle where VehicleID=@VehicleID and IsAvailableForRent=1;";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@VehicleID", VehicleID);

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
        public static bool VehiculeIsDisponibleOrNotByPlateNumber(string PlateNumber)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select 1 from Vehicle where PlateNumber=@PlateNumber and IsAvailableForRent=1;";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PlateNumber", PlateNumber);

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
        public static bool UpdateDisponibility(int VehicleID,int Disponibility)
        {
            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Vehicle SET IsAvailableForRent = @IsAvailableForRent WHERE VehicleID = @VehicleID";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@IsAvailableForRent", Disponibility);


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
        public static bool ADDMileage(int VehicleID, int Mileage)
        {
            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Vehicle SET Mileage = Mileage + @Mileage WHERE VehicleID = @VehicleID";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);
            cmd.Parameters.AddWithValue("@Mileage", Mileage);


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
        public static bool PricePerDay(int VehicleID,ref decimal RentalPricePerDay)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Vehicle WHERE VehicleID = @VehicleID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@VehicleID", VehicleID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    RentalPricePerDay = (decimal)reader["RentalPricePerDay"];


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

        public static DataTable Datatable()
        {
            DataTable dt = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = @"SELECT                                         
                                        Vehicle.VehicleID,
                                        Vehicle.Make, 
                                        Vehicle.Model, 
                                        Vehicle.Mileage, 
                                        Vehicle.PlateNumber, 
                                        Vehicle.IsAvailableForRent as IsAvailable
                                    FROM 
                                        Vehicle 
                                    INNER JOIN 
                                        vehicleCategories 
                                        ON Vehicle.CarCategoryID = vehicleCategories.CategoryID
                                    INNER JOIN 
                                        FuleTypes 
                                        ON Vehicle.FuelTypeID = FuleTypes.ID;";
                                     

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
                        Console.WriteLine("Une erreur est survenue : " + ex.Message);
                    }
                }
            }

            return dt;
        }

        public static bool VehicleAvailible(ref string VehicleAvailible)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumbersVehiclesAvailible FROM dbo.Vehicle where IsAvailableForRent=1";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int num = -1;
                    IsExist = true;
                    num = (int)reader["NumbersVehiclesAvailible"];
                    VehicleAvailible= num.ToString();

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
        public static bool VehicleUNAVALAIBLE(ref string VehicleUNAVALAIBLE)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumbersVehiclesUNAVALAIBLE FROM dbo.Vehicle where IsAvailableForRent=0";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    int num = -1;
                    IsExist = true;
                    num = (int)reader["NumbersVehiclesUNAVALAIBLE"];
                    VehicleUNAVALAIBLE = num.ToString();

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


    }
}
