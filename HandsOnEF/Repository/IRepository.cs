namespace HandsOnEF.Repository
{
    public interface IRepository<T> where T:class 
    {
       public T GetById(int id);
        public List<T> GetALl();
        public void Delete(int id);
        public void Add(T entity);
        public void Update(T entity);
    }
}
