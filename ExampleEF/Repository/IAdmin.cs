using ExampleEF.Entity;

namespace ExampleEF.Repository
{
    public interface IAdmin
    {
        public void AddAdmin(Admin admin);
        public void UpdateAdmin(Admin admin);
        public void DeleteAdmin(int id);
        public List<Admin> Gettall();
    }
}
