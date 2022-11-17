using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace insert_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sc;
            string connectingstring = ("Server = alekhyaVM; database = Sample; integrated security = True");
            try
            {
                sc = new SqlConnection(connectingstring);
                sc.Open();
                Console.WriteLine("Connection established");
                //creating CRUD

                Console.WriteLine("Enter user id:");
               int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter user name:");
                string Custname = Console.ReadLine();
                Console.WriteLine("Enter user phone number:");
                int Phone = Convert.ToInt32(Console.ReadLine());

                //writing insert query

                string insertQuery = "insert into Customers(ID, Custname, Phone)values(" + ID + ", '" + Custname + "', " + Phone + ")";
                //Executing insert Query

                SqlCommand cmd = new SqlCommand(insertQuery, sc);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted");

                sc.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
