using Assignment_10.Model;

namespace Assignment_10.Repository
{
    public interface IProductRepo
    {
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int  productid);
        public Product GetProductByName(string name);
        public List<Product> GetProductByCatogory(string Catogory);

    }
}
