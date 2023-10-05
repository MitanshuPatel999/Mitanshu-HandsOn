using System;
using System.Data.SqlClient;

namespace Employee{
    class Program
{
    static void Main()
    {
        string connectionString = "Server=PMCLAP1382;Database=HandsOn;User Id=sa;Password=India@123;";
        using SqlConnection connection = new SqlConnection(connectionString);

        try
        {
            connection.Open();

            string sqlQuery = "SELECT * FROM Employees";
            using SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Access data from the reader
                int id = reader.GetInt32(0);
                string fname = reader.GetString(1);
                string lname = reader.GetString(2);
                int did = reader.GetInt32(3);
                DateTime dob = reader.GetDateTime(4);
                decimal s = reader.GetDecimal(5);

                Console.WriteLine($"ID: {id}, First Name: {fname}, Last Name: {lname}, Department ID: {did}, DOB: {dob}, Salary: {s}");
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }
}
}