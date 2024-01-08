using Week2_Assesment.Model;

namespace Week2_Assesment.Repository
{
    public interface IstudentRepo
    {
        public void AddStudent(Student student); 
        public List<Student> GetStudentsByQuali(string qualification);
        public List<Student> GetStudentsBySkill(string skill);
        public Student GetStudentById(int id);
        public void UpdateStudent(int Sid, String Skill);
        public void DeleteStudent(int DelSid);



    }
}
