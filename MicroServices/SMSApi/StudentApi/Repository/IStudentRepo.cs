using StudentApi.Model;
namespace StudentApi.Repository
{
    public interface IStudentRepo
    {

        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public void DeleteStudent(int id);
        public List<Student> GetAllStudentByClass(string section, int std);
       
    }
}
