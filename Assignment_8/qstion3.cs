using System;
using System.Collections.Generic;

namespace Assignment_8
{
    class Order
    {
        public int order_id;
        public string item_name;
        public DateTime order_date;
        public int quantity;

        public Order(int order_id, string item_name, DateTime order_date, int quantity)
        {
            this.quantity = quantity;
            this.order_date = order_date;
            this.order_id = order_id;
            this.item_name = item_name;
        }
    }

    internal class qstion3
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

            /*var rslt = from k in ord
                       orderby k.order_date,k.quantity descending
                       select k;*/

            var orders = ord.OrderBy(k => k.quantity);

            foreach(var k in orders)
            {
                Console.WriteLine($"OREDR DATE:{k.order_date} OREDR QTY:{k.quantity}");
            }
        }
    }
}
