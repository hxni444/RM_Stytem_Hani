using HandsOnEF.Entity;

namespace HandsOnEF.Repository
{
    public class StudentRepo : IRepository<Student>
    {
        public MyContext StObj;
        public StudentRepo(MyContext StObj)
        {
            this.StObj = StObj;
        }


        public void Add(Student students)
        {
            StObj.students.Add(students);
            StObj.SaveChanges();

        }

        public void Delete(int id)
        {
           Student st= StObj.students.SingleOrDefault(s => s.Id == id);
            StObj.students.Remove(st);
            StObj.SaveChanges();

        }

        public List<Student> GetALl()
        {
           return StObj.students.ToList();
        }

        public Student GetById(int id)
        {
            return StObj.students.SingleOrDefault(s => s.Id == id);
          
        }

        public void Update(Student entity)
        {
            StObj.students.Update(entity);
            StObj.SaveChanges();

        }
    }
}
