using System;
using System.Data;
using System.Data.SqlClient;

namespace DataSTA{
    class Program
{
    static void Main()
    {
        string connectionString = "Server=PMCLAP1382;Database=HandsOn;User Id=sa;Password=India@123;";
        using SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            DataSet ds= new DataSet();
            SqlDataAdapter da=new SqlDataAdapter("select * from student;",connection);
            DataTable dt=new DataTable("student");
            da.Fill(dt);
            ds.Tables.Add(dt);
            foreach(DataRow row in dt.Rows){
                Console.WriteLine($"{row["id"]}, {row["name"]}, {row["email"]}, {row["join_date"]}");
            }

            Console.WriteLine("After Updating...");

            DataRow first=dt.Rows[0];
            first["name"]="Mitanshu_1";

             foreach(DataRow row in dt.Rows){
                Console.WriteLine($"{row["id"]}, {row["name"]}, {row["email"]}, {row["join_date"]}");
            }

            // SqlCommandBuilder cmb=new SqlCommandBuilder(new SqlDataAdapter(""));
            // da.Update(dt);
            // // Console.WriteLine($"First Column=> {first["id"]}, {first["name"]}, {first["email"]}, {first["join_date"]}");

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