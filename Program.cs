using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Model1())
            {
                Console.WriteLine("Begin");
                // var query = from b in db.create_pps 
                //          orderby b.number_pp 
                //     select b;

                var query = db.create_pps.Where(p => p.date_pp=="07.04.2020");
                //var p1 = query();
                //Console.WriteLine(p1.Name_platelshika);
                Console.WriteLine("Номер ПП" + "    " + "ФОРМ ОКУД");
                foreach ( var item in query)
                {
                    Console.WriteLine(item.number_pp + "    " + item.form_okyd);
              }

                Console.ReadKey();
            }
        }
    }
}
