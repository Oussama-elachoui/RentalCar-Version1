using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public  class Users_SQL
    {
        public static int ADDNEWUSER(int PersonID, string UserName, string Password, bool IsActive,int permissions)
        {
            int UserID = -1;

            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "insert into Users (PersonID,Username,Password,IsActive,Permission) values (@PersonID,@Username,@Password,@IsActive,@Permissions) SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@Permissions", permissions);


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
        public static bool Update(int UserID,int PersonID, string UserName, string Password, bool IsActive, int Permission)
 
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Users SET PersonID = @PersonID, Username = @Username, Password = @Password, IsActive = @IsActive , Permission =@Permission " +
                               " WHERE IDUsers = @UserID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Permission", Permission);



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
        public static bool Delete(int UserID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete from Users where IDUsers = @UserID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@UserID", UserID);


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
        public static bool FindByUsernamePassword(string UserName, string Password, ref int UserID, ref int PersonID, ref bool IsActive,ref int Permissions)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Users WHERE Username = @Username and Password = @Password ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Username", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    PersonID = (int)reader["PersonID"];
                    PersonID = (int)reader["IDUsers"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permission"];


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

        public static bool FindByID(int UserID, ref int PersonID,ref string UserName,ref string Password,ref bool IsActive, ref int Permissions)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Users WHERE IDUsers = @UserID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permission"];


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
        public static bool FindByPersonID(int PersonID,ref int UserID, ref string UserName, ref string Password, ref bool IsActive, ref int Permissions)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    UserID = (int)reader["IDUsers"];
                    UserName = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permission"];


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
            DataTable dt = new DataTable();

            // Use 'using' statements for automatic resource management
            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                // SQL query to select all persons
                string query = "select Users.IDUsers , Fullname=FistName+' '+LastName ,Users.Username ,Email ,NationalityID,Users.IsActive from Persons inner join Users on Persons.IDPerson=Users.PersonID;";
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
            }

            return dt;
        }

        public static bool NumberOfUsers(ref string NumberOfUsers)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = "SELECT COUNT(*) AS NumberOfUsers FROM dbo.Users";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int num = -1;
                    IsExist = true;
                    num = (int)reader["NumberOfUsers"];
                    NumberOfUsers = num.ToString();

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


        public static bool IsExistByPersonID(int PersonID)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select IDPerson from Persons inner join Users on Persons.IDPerson=Users.PersonID where PersonID=@PersonID;";

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

        public static bool IsExistByUsername(string Username)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Users where Username=@Username";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Username", Username);


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
        public static bool IsExistByUsernameAndPassword(string Username, string Password)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Users where Username=@Username";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Username", Username);


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
        public static bool IsExistByIDUser(int IDUser)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Users where IDUsers=@IDUsers ";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.AddWithValue("@IDUsers", IDUser);


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


    }
}
