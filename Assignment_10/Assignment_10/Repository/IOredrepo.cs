using Assignment_10.Model;

namespace Assignment_10.Repository
{
    public interface IOredrepo
    {
        public void OredrProd(int id, Order order);
        public List<Order> GetAllOders();
        public void DeltOrder(int OrdId);
    }
}
