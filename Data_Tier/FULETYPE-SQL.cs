using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class FULETYPE_SQL
    {
         public static DataTable List()
        {
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                DataTable dt = new DataTable();
                // SQL query to select all persons
                string query = "select * from FuleTypes";
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Load the data into the DataTable if there are rows
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the exception (use your preferred logging mechanism)
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
                return dt;     
            }
        }

        public static bool FindByID(int ID, ref string FULETYPE)
        {
            bool IsFound = false; // Default to false
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "SELECT FuleType FROM FuleTypes WHERE ID = @ID";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ID", ID);

                try
                {
                    sqlConnection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;

                            FULETYPE = reader["FuleType"] != DBNull.Value ? reader["FuleType"].ToString() : string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return IsFound; 
        }
        public static int FindFuelTypeIdByName(string fuelType)
        {
            const string query = "SELECT ID FROM FuleTypes WHERE FuleType = @FuelType";

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.Parameters.Add("@FuelType", SqlDbType.NVarChar).Value = fuelType;

                try
                {
                    sqlConnection.Open();

                    // Use ExecuteScalar for a single value
                    object result = sqlCommand.ExecuteScalar();

                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return -1;
                }
            }
        }



    }
}
