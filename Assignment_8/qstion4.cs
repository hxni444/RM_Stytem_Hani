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
                new Order(456, "mobile", new DateTime(2023, 8, 2), 10),
                new Order(456, "mobile", new DateTime(2023, 6, 23), 8),
                new Order(456, "mobile", new DateTime(2023, 12, 14), 6),

            };

            var ods = from l in ord
                      orderby l.order_date
                      group l by l.order_date.Month;

            foreach (var o in ods)
            {
                Console.Write(o.Key + " ");
                foreach (var item in o)
                {
                    Console.WriteLine(item.item_name);
                }
            }
                      
        }
    }
}
