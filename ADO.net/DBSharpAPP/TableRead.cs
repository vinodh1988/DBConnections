//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace dbsharpapp
//{
//    class tableread
//    {
//        static void Main(string[] n )
//        {
//            SqlConnection conn = new SqlConnection(
//       "Data Source=DESKTOP-NUIRMP2\\SQLEXPRESS;Initial Catalog=tvs;User ID=sa;Password=sqlserver");

//            try
//            {
//                conn.Open();
//                SqlCommand sql = new SqlCommand("select * from person", conn);

//                SqlDataReader reader = sql.ExecuteReader();

//                while (reader.Read())
//                {
//                    Console.WriteLine(reader["name"] + " " + reader["city"]);
//                }

//                Console.ReadKey();
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.StackTrace);
//                Console.WriteLine("Not Connected...!!!");

//            }

//            Console.ReadKey();

//        }
//    }
//}
