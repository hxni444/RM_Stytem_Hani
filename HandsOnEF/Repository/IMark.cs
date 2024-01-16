using HandsOnEF.Entity;

namespace HandsOnEF.Repository
{
    public class IMark : IRepository<Mark>
    {
        public MyContext context;
        public IMark()
        {
            context = new MyContext();
        }
        public void Add(Mark entity)
        {
            context.marks.Add(entity);
            context.SaveChanges();

        }

        public void Delete(int id)
        {
            Mark Mrk = context.marks.SingleOrDefault(s =>s.StudentId == id);
            context.marks.Remove(Mrk);
            context.SaveChanges();

        }

        public List<Mark> GetALl()
        {

           return context.marks.ToList();   
        }

        public Mark GetById(int id)
        {
            return context.marks.SingleOrDefault(s => s.StudentId == id);
           

        }

        public void Update(Mark entity)
        {
            context.marks.Update(entity);
            context.SaveChanges();
        }
    }
}
