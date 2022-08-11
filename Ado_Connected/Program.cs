using System;
using System.Data.SqlClient;


namespace Ado_Connected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = LAPTOP-20VKH6BS\\SQLEXPRESS; initial catalog = PracticeDB; integrated security = true ");
                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select avg(salary) from employees";
                con.Open();
                decimal Avg = (decimal)com.ExecuteScalar();
                Console.WriteLine("Average salary of employee = " + Avg);
                con.Close();

                
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(); 
            
        }
    }
}
