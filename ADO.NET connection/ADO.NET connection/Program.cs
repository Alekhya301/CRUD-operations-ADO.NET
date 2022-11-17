using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO.NET_connection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SqlConnection con = new SqlConnection("data source = .; database = Sample; integrated security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" select * from Customers", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string ID = dr["ID"].ToString();
                string Custname = dr["Custname"].ToString();

                string Phone = dr["Phone"].ToString();
                Console.WriteLine(ID + " " + Custname + " " + Phone);





            }

          
              
            dr.Close();
            con.Close();
            Console.ReadLine();


        }
    }
}