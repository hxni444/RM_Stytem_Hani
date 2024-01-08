using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{

    internal class qstion7
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


          //  var qtyck = orders.Where(o => o.quantity <= 0).Select(o => o.item_name).SingleOrDefault
            var qtcky = (from o in orders
                        where o.quantity<= 0
                        select o.item_name).SingleOrDefault();

            if(qtcky != null)
            {
                Console.WriteLine("There is no item in "+ qtcky + " item");

            }

            // var MQty = orders.Max(o => o.quantity);
            var MaxQty = (from o in orders
                        orderby o.quantity descending
                        select o.quantity).First();

           // var nQty = orders.Where(o => o.quantity == MQty).Select(o => o.item_name).First();
           var ItmWithMaxQty = (from o in orders
                                where o.quantity == MaxQty
                                select o.item_name).SingleOrDefault();

            Console.WriteLine("item with higer qty is "+ItmWithMaxQty);

            DateTime x = DateTime.Now;
           // var orderdate = orders.Where(o => o.order_date.Year < x.Year && x.Month < 1);
           var orderdate = from o in orders
                           where o.order_date.Year == x.Year&& x.Month<1
                           select o;

            if (orderdate != null)
            {
                Console.WriteLine("There is  order'(s) before this jan");
            }
            else
                Console.WriteLine("There is NO order before this jan");











        }
    }
}
