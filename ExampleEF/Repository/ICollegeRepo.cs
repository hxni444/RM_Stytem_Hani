using ExampleEF.Entity;

namespace ExampleEF.Repository
{
   /* public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }*/
    public interface ICollegeRepo
    {
        public void AddCollege(College admin);
        public void UpdateCollege(College admin);
        public void DeleteCollege(int id);
        public List<College> Gettall();
    }
}
