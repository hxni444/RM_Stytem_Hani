using Assignment_10.Model;

namespace Assignment_10.Repository
{
    public interface IOredrepo
    {
        public string OredrProd( Order order);
        public List<Order> GetAllOders();
        public void DeltOrder(int OrdId);
    }
}
