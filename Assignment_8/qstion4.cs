using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class qstion4
    {
        public static void Main()
        {
            List<Order> ord = new List<Order>
            {
                new Order(456, "mobile", new DateTime(2023, 2, 3), 5),
                new Order(152, "ipod", new DateTime(2023, 8, 2), 10),
                new Order(1351, "tablet", new DateTime(2023, 6, 23), 8),
                new Order(1211, "fan", new DateTime(2023, 12, 14), 6),

            };

            var data = from o in ord
                       orderby o.order_date descending
                       group o by o.order_date.Month;
            foreach( var k in data)
            {
                Console.Write(k.Key+ " ");
                foreach(var j in k)
                {
                    Console.WriteLine($"{j.order_id} {j.item_name}");
                }
            }
        }
    }
}
