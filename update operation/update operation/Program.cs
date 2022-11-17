using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace update_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            string connectingstring = ("Server = alekhyaVM; database = Sample; integrated security = True");
            try
            {
                con = new SqlConnection(connectingstring);
                Console.WriteLine("Connection established successfully ");
                con.Open();
                Console.WriteLine("Enter the id of the custumer");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number to update");
                int phone = Convert.ToInt32(Console.ReadLine());
                string updateQuery = "UPDATE Customers SET Phone = " + phone + " WHERE ID = " + id + "";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("data updated successfully");
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
