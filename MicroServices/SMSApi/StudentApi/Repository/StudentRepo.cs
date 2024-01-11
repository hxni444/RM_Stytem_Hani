using StudentApi.Model;

namespace StudentApi.Repository
{
    public class StudentRepo : IStudentRepo
    {
        List<Student> students =    new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DeleteStudent(int id)
        {
            try
            {
                Student std = students.SingleOrDefault(s => s.Id == id);
                students.Remove(std);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAllStudentByClass(string section, int std)
        {
            try
            {
                return students.Where(s => s.std == std && s.section == section).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                foreach (var k in students)
                {
                    k.Id = student.Id;
                    k.section = student.section;
                    k.std = student.std;
                    k.Name = student.Name;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
