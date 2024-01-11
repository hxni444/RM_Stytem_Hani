using Assignment_10.Model;
using System.Security.Cryptography;

namespace Assignment_10.Repository
{
    public class OderRepo : IOredrepo
    {
        List<Order> _order = new List<Order>();
        List<Product> prod = ProductRepo._products;
        
        public void DeltOrder(int OrdId)
        {
            foreach (var item in _order)
            {
                if (item.OrderId == OrdId)
                {
                    _order.Remove(item);
                }
            }
        }

       

        public List<Order> GetAllOders()
        {
                return _order;
        }

        public string OredrProd(Order order)
        {
            //_order.Add(order);

            Product data = (from p in prod
                        where p.Product_Id == order.ProductId
                        select p).SingleOrDefault();


            if (data == null)
            {
                return "no such product";

            }
            else
            {
                order.Amount = order.Quantity * data.Price;
                _order.Add(order);

                return "order placed";

            }
              

            
        }

        
    }

       
    }

