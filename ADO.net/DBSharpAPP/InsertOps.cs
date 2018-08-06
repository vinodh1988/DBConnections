using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSharpAPP
{
    class InsertOps
    {
          
        static void Main(String[] n){
            SqlConnection conn = new SqlConnection(
      "Data Source=DESKTOP-NUIRMP2\\SQLEXPRESS;Initial Catalog=tvs;User ID=sa;Password=sqlserver");

            try
            {
                conn.Open();
                Console.WriteLine("Enter Sno");
                int sno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter City");
                String city = Console.ReadLine();

                SqlCommand sql = new SqlCommand("insert into person values(@sno,@name,@city)", conn);
                sql.Parameters.AddWithValue("@sno", sno);
                sql.Parameters.AddWithValue("@name", name);
                sql.Parameters.AddWithValue("@city", city);




                sql.ExecuteNonQuery();
                Console.WriteLine("Row Added Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
