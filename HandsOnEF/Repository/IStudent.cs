using HandsOnEF.Entity;

namespace HandsOnEF.Repository
{
    public class IStudent : IRepository<Student>
    {
        public MyContext StObj;
        public IStudent()
        {
            StObj = new MyContext();
        }


        public void Add(Student students)
        {
            StObj.students.Add(students);
        }

        public void Delete(int id)
        {
           Student st= StObj.students.SingleOrDefault(s => s.Id == id);
            StObj.students.Remove(st);
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
        }
    }
}
