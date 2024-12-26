using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class VehiculeCategory_SQL
    {
        public static DataTable List()
        {
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                DataTable dt = new DataTable();
                // SQL query to select all persons
                string query = "select * from vehicleCategories";
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
        public static bool FindByID(int ID, ref string CategoryName)
        {
            bool IsFound = false; // Default to false
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "SELECT CategoryName FROM vehicleCategories WHERE CategoryID = @CategoryID";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@CategoryID", ID);

                try
                {
                    sqlConnection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            CategoryName = reader["CategoryName"] != DBNull.Value ? reader["CategoryName"].ToString() : string.Empty; // Safely convert to string
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle or log the exception for debugging
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
            return IsFound; // Return the result indicating if the category was found
        }
        public static int FindCategoryIdByName(string categoryName)
        {
            const string query = "SELECT CategoryID FROM vehicleCategories WHERE CategoryName = @CategoryName";

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                sqlCommand.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = categoryName;

                try
                {
                    sqlConnection.Open();

                    object result = sqlCommand.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return -1;
                }
            }
        }




    }
}
