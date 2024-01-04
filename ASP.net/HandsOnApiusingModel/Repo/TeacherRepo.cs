using HandsOnApiusingModel.Models;

namespace HandsOnApiusingModel.Repo
{
    public class TeacherRepo : ITeacher
    {
       static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher(){Id=123,Name="ROhahini",Subject="Maths",Class=new[]{"12","32"}}
        };
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return teachers;
        }

        public Teacher GetTeacherById(int id)
        {
           foreach (var teacher in teachers)
            {
                if(teacher.Id == id)
                    return teacher;
            }
            return null;
        }

        public List<Teacher> GetTeacherBySub(string sub)
        {
            List<Teacher> TsubList = new List<Teacher>();
            foreach(var k in teachers)
            {
                if (string.Equals(sub, k.Subject))
                {
                    TsubList.Add(k);
                }
            }
            return TsubList;
        }
    }
}
