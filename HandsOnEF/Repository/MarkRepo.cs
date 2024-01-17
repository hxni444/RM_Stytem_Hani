using HandsOnEF.Entity;

namespace HandsOnEF.Repository
{
    public class MarkRepo : IRepository<Mark>
    {
        public MyContext context;
        public MarkRepo(MyContext context)
        {
           this.context = context;
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
        public List<StudentMark> GetStudentMarks(int id)
        {
            List<StudentMark> studentMarks = from s in context.students                                        
                                             join m in context.marks on s.Id equals m.StudentId
                                             where 

        }
    }
}
