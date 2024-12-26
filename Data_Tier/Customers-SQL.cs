using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public  class Customers_SQL
    {
        public static int ADD(int PersonID, string DriverLicenseNumber)
        {
            int UserID = -1;

            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "insert into Customers (PersonID,DriverLicenseNumber) values (@PersonID,@DriverLicenseNumber) SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InserID))
                {

                    UserID = InserID;
                }

            }
            catch (Exception ex) { }
            finally
            {
                sqlConnection.Close();
            }
            return UserID;
        }
        public static bool Update(int CustumerID, int PersonID, string DriverLicenseNumber)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Customers SET PersonID = @PersonID, DriverLicenseNumber = @DriverLicenseNumber WHERE CustomerID = @CustomerID";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@DriverLicenseNumber", DriverLicenseNumber);
            cmd.Parameters.AddWithValue("@CustomerID", CustumerID);


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
        public static bool Delete(int CustumerID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete from Customers where CustomerID = @CustomerID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerID", CustumerID);


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

        public static bool FindByID(int CustumerID, ref int PersonID, ref string DriverLicenseNumber)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerID", CustumerID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    PersonID = (int)reader["PersonID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];


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
        public static bool FindByPersonID( int PersonID, ref int CustumerID,  ref string DriverLicenseNumber)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Customers WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    CustumerID = (int)reader["CustomerID"];
                    DriverLicenseNumber = (string)reader["DriverLicenseNumber"];

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
        public static DataTable DatatablePerson()
        {
            // Création d'une instance DataTable
            DataTable dt = new DataTable();

            // Utilisation de "using" pour gérer les ressources
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                // Requête SQL pour récupérer les données
                string query = @"SELECT 
                            Customers.CustomerID,
                            Customers.DriverLicenseNumber,
                            Fullname = Persons.FistName + ' ' + Persons.LastName,
                            Persons.Email,
                            Persons.NationalityID
                         FROM 
                            Persons 
                         INNER JOIN 
                            Customers 
                         ON 
                            Persons.IDPerson = Customers.PersonID;";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    try
                    {
                        // Ouvrir la connexion
                        sqlConnection.Open();

                        // Exécution de la commande et lecture des données
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Charger les données dans le DataTable
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Enregistrer ou afficher l'erreur
                        Console.WriteLine("Une erreur est survenue : " + ex.Message);
                    }
                }
            }

            return dt;
        }

        public static bool IsExistByPersonID(int PersonID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select IDPerson from Persons inner join Customers on Persons.IDPerson=Customers.PersonID where PersonID=@PersonID;";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsExistByIDCUSTOMER(int CustumerID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Customers where CustomerID=@CustomerID ";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@CustomerID", CustumerID);


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

        public static bool IsalreadyExistthisDriverlocal(string driverlicence)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Customers where DriverLicenseNumber=@DriverLicenseNumber ";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@DriverLicenseNumber", driverlicence);


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
        public static string NumberOfCustomers()
        {
            string customerCount = "";

            if (NumberOfCustomersSQL(ref customerCount))
            {
                return customerCount;
            }

            return null;
        }

        public static bool NumberOfCustomersSQL(ref string numberOfCustomers)
        {
            bool isExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumberOfCustomers FROM dbo.Customers;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isExist = true;

                    // Get the count as an integer and convert it to string
                    int count = (int)reader["NumberOfCustomers"];
                    numberOfCustomers = count.ToString();

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

            return isExist;
        }


    }
}
