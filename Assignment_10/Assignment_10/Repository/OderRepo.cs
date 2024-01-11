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

        public void DeltOrder(string product_name, Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOders()
        {
                return _order;
        }

        public void OredrProd(int id,Order order,Product product)
        {
            //_order.Add(order);

           /* var data = (from p in prod
                        select p.Product_Id).SingleOrDefault();*/

                order.OrderId = id;
            if(order.ProductId ==product.Product_Id)
            {
                foreach(var k in _order)
                {
                    _order.Add(order);
                }

            }  
            
        }

    }

       
    }

