using Assignment_10.Model;

namespace Assignment_10.Repository
{
    public class ProductRepo : IProductRepo
    {
        public static List<Product> _products= new List<Product>();
        int id = 1000;
        public void AddProduct(Product product)
        {
           _products.Add(product);
            id++;
            product.Product_Id=id;
        }

        public void DeleteProduct(int productid)
        {
           foreach (var item in _products)
            {
                if(item.Product_Id == productid)
                {
                    _products.Remove(item);
                }
            }
        }

        public List<Product> GetProductByCatogory(string Catogory)
        {
            List<Product> _PodWithCat = new List<Product>();
            foreach (var item in _products)
            {
                if (item.Category == Catogory)
                {
                   _PodWithCat.Add(item);
                }
            }
            return _PodWithCat;
        }

        public Product GetProductByName(string name)
        {
            foreach (var item in _products)
            {
                if (item.ProductName == name)
                {
                   return item;
                }
            }
            return null;
        }

        public void UpdateProduct(Product product)
        {
            foreach (var item in _products)
            {
                item.Product_Id = product.Product_Id;
                item.Category = product.Category;
                item.ProductName = product.ProductName;
                item.Price = product.Price;
            }
        }
    }
}
