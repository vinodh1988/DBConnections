using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db=new tvsEntities1()) {

                var query = from person in db.People
                            select person;

                foreach (var item in query)
                    Console.WriteLine(item.Name + " " + item.City);

                Console.ReadKey();
            }
        }
    }
}
