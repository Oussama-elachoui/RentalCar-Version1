using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Tier
{
    public class PeronsSQL
    {
        public static int ADDPERSON(string Firstname, string Lastname, int NationalityID, DateTime Dateofbirth, string Phone, string EMAIL, string Address, string ImagePath)
        {
            int PersonID = -1;

            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            string query = @"INSERT INTO Persons (FistName, LastName, NationalityID, DateOfBirth, Phone, Email, Address, ImagePath) VALUES (@FirstName, @LastName, @NationalityID, @DateOfBirth, @Phone, @Email, @Address, @ImagePath)  SELECT SCOPE_IDENTITY();";



            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@FirstName", Firstname);
            cmd.Parameters.AddWithValue("@LastName", Lastname);
            cmd.Parameters.AddWithValue("@NationalityID", NationalityID);
            cmd.Parameters.AddWithValue("@DateOfBirth", Dateofbirth);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", EMAIL);
            cmd.Parameters.AddWithValue("@Address", Address);

            if (ImagePath != "" && ImagePath != null)
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                sqlConnection.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
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


            return PersonID;
        }
        public static bool Update(int PersonID, string Firstname, string Lastname, int NationalityID, DateTime Dateofbirth, string Phone, string EMAIL, string Address, string ImagePath)
        {
            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "UPDATE Persons SET FistName = @FirstName, LastName = @LastName, NationalityID = @NationalityID, DateOfBirth = @DateOfBirth, " +
                               "Phone = @Phone, Email = @Email, Address = @Address, ImagePath = @ImagePath WHERE IDPerson = @PersonID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@FirstName", Firstname);
            cmd.Parameters.AddWithValue("@LastName", Lastname);
            cmd.Parameters.AddWithValue("@NationalityID", NationalityID);
            cmd.Parameters.AddWithValue("@DateOfBirth", Dateofbirth);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@Email", EMAIL);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static bool Delete(int PersonID)
        {

            int RowsAffected = 0;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "Delete  from Persons where IDPerson = @PersonID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static bool FindByID(int PersonID, ref string Firstname, ref string Lastname, ref int NationalityID, ref DateTime Dateofbirth, ref string Phone, ref string EMAIL, ref string Address, ref string ImagePath)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Persons WHERE IDPerson = @PersonID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsExist = true;
                    Firstname = (string)reader["FistName"];
                    Lastname = (string)reader["LastName"];
                    NationalityID = (int)reader["NationalityID"];
                    Dateofbirth = (DateTime)reader["DateOfBirth"];
                    Phone = (string)reader["Phone"];
                    EMAIL = (string)reader["Email"];
                    Address = (string)reader["Address"];

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
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

        public static bool FindByNationalityID(int NationalityID, ref int PersonID, ref string Firstname, ref string Lastname, ref DateTime Dateofbirth, ref string Phone, ref string EMAIL, ref string Address, ref string ImagePath)
        {
            bool IsExist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);

            // Correct SQL query
            string query = "SELECT * FROM Persons WHERE NationalityID = @NationalityID";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@NationalityID", NationalityID);

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    Firstname = (string)reader["FirstName"];
                    Lastname = (string)reader["LastName"];
                    Dateofbirth = (DateTime)reader["DateOfBirth"];
                    Phone = (string)reader["Phone"];
                    EMAIL = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : string.Empty;

                    IsExist = true;
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
                string query = "SELECT ID=IDPerson ,Fullname=Fistname+' '+ LastName, NationalityID ,Address , Phone , Email FROM Persons";
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

        public static bool NationalityIdExist(int ID)
        {
            bool exists = false;

            using (SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString))
            {
                string query = "SELECT 1 FROM Persons WHERE NationalityID = @NationalityID;";

                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@NationalityID", ID);

                    try
                    {
                        sqlConnection.Open();

                        exists = cmd.ExecuteScalar() != null;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return exists;
        }
        public static bool PhoneExist(string Phone)
        {
            bool Isexist =false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Persons where Phone=@Phone;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Phone", Phone);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Isexist = reader.HasRows;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally { sqlConnection.Close(); }






            return Isexist;
        }
        public static bool EmailExist(string Email)
        {
            bool Isexist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Persons where Email=@Email;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@Email", Email);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Isexist = reader.HasRows;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally { sqlConnection.Close(); }






            return Isexist;
        }
        public static bool PersonIdExist(int ID)
        {
            bool Isexist = false;
            SqlConnection sqlConnection = new SqlConnection(StringConnectionSQL.connectionString);
            string query = "select * from Persons where IDPerson=@IDPerson;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("@IDPerson", ID);


            try
            {
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Isexist = reader.HasRows;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally { sqlConnection.Close(); }






            return Isexist;
        }


    }
}
