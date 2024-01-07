using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Item
    {
        public string item_name;
        public Double price;

        public Item(string item_name,Double price) 
        {
            this.item_name = item_name;
            this.price = price;
        }

    }
    class AllItem
    {
        public int order_id;
        public string item_name;
        public DateTime order_date;
        public Double price;
        public int quantity;

        public AllItem(string item_name, int order_id, DateTime order_date, int quantity, double price)
        {
            this.price = price;
            this.item_name = item_name;
            this.order_id = order_id;
            this.order_date = order_date;
            this.quantity = quantity;
        }
    }
    internal class qstion5
    {
        public static void Main()
        {
            List<Item> items = new List<Item>()
            {
                        new Item("ipod",10500),
                        new Item("mobile",50000),
                        new Item("fan",2500),
                        new Item("table",7000),

            };
            List<Order> orders = new List<Order>()
            {

                new Order(456, "mobile", new DateTime(2023, 4, 3), 5),
                new Order(456, "ipod", new DateTime(2023, 8, 2), 10),
                new Order(456, "fan", new DateTime(2023, 3, 23), 8),
                new Order(456, "table", new DateTime(2023, 4, 14), 6),
            };

           /* var data = from i in items

                       join o in orders on i.item_name equals o.item_name
                       select new { Price = i.price, Id = o.order_id, Name = i.item_name, Date = o.order_date, Qty = o.quantity };*/

            /*var grpData = from el in data
                          orderby el.Date descending
                          group data by el.Date;*/

            var group = orders.Join(items, i => i.item_name, o => o.item_name,
                (o, i) => new AllItem(i.item_name, o.order_id,o.order_date,o.quantity,i.price))
                .GroupBy(o => o.order_date);

            foreach (var l in group)
            {
              
                Console.WriteLine(l.Key);
                foreach (var r in l)
                {
                    Console.WriteLine($"Item_Name:{r.item_name}\nOder Date:{r.order_date}\nTotal Price:{r.price*r.quantity}");
                    Console.WriteLine();
                }
            }
        }
    }
}
