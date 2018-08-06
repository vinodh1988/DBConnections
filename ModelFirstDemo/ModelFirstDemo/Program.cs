using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context=new MyModelContainer()) {
                Vehicle v = new Vehicle();
                v.VehicleID = 23133;
                v.Type = "Luxury Car";

                Cars c = new Cars();
                c.CarID = 2132;
                c.Name = "BMW XYZ";
                c.Price = "5400000";
                c.Brand = "BMW";

                HashSet<Cars> h = new HashSet<Cars>();
                h.Add(c);

                v.Cars = h;

                context.Vehicles.Add(v);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e) {
                    Console.WriteLine(e.StackTrace);
                }
                Console.ReadKey();
            }
        }
    }
}
