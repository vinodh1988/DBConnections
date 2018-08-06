using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ModelFirstContainer()) {
                Department d = new Department();
                d.DepartmentNo = 121;
                d.Name = "Rajeev";
                Worker w = new Worker();
                w.WorkerID = 123;
                w.Name = "John";
                w.Place = "Jaipur";

                HashSet<Worker> s = new HashSet<Worker>();
                s.Add(w);
                d.Workers = s;
                db.Departments.Add(d);
                try {
                    db.SaveChanges();
                    Console.WriteLine("The records are added..!!!!!");
                    Console.ReadKey();
                }
                catch (Exception e) {
                }
               
            }
        }
    }
}
