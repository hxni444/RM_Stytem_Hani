using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class qstion10
    {
       public static void Main()
        {
            List<Order> orders = new List<Order>()
            {

                new Order(456, "mobile", new DateTime(2023, 4, 3), 5),
                new Order(456, "ipod", new DateTime(2023, 8, 2), 10),
                new Order(456, "fan", new DateTime(2023, 3, 23), 8),
                new Order(456, "table", new DateTime(2023, 4, 14), 0),
            };

            var data = (from o in orders
                        select o.quantity).Sum();

            var MQty = (from o in orders
                        orderby o.quantity descending
                        select o.item_name).First();


            Console.WriteLine("item with higer qty is " + MQty);
            Console.WriteLine(data);
        }
    }
}
