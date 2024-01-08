using Week2_Assesment.Model;

namespace Week2_Assesment.Repository
{
    public class StudentRepo : IstudentRepo
    {
        List<Student> studentlist = new List<Student>()
        {
            new Student(){skill="Drawing",studentId=123,name="rahul",qualification="btech"},
         };
        public void AddStudent(Student stud)
        {
            studentlist.Add(stud);
        }

        public void DeleteStudent(int DelSid)
        {
            foreach (var k in studentlist)
            {
                if (k.studentId == DelSid)
                {
                    studentlist.Remove(k);
                    break;
                }
            }
        }

        public Student GetStudentById(int id)
        {
           foreach (var k in studentlist)
            {
                if(k.studentId == id)
                {
                    return k;
                }
            }
            return null;
        }

        public List<Student> GetStudentsByQuali(string qualification)
        {
            try
            {

                List<Student> studentsWithQuali = new List<Student>();
                foreach (var k in studentlist)
                {
                    if (k.qualification == qualification)
                    {
                        studentsWithQuali.Add(k);
                    }
                }
                return studentsWithQuali;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentsBySkill(string skill)
        {
            try
            {
                List<Student> studentsWithSkill = new List<Student>();
                foreach (var k in studentlist)
                {
                    if (k.skill == skill)
                    {
                        studentsWithSkill.Add(k);
                    }
                }
                return studentsWithSkill;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateStudent(int Sid, string Skill)
        {
            try
            {
                foreach (var k in studentlist)
                {
                    if (k.studentId == Sid)
                    {
                        k.skill = Skill;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
