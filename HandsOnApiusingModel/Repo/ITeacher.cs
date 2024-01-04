using HandsOnApiusingModel.Models;
using System.Collections.Generic;

namespace HandsOnApiusingModel.Repo
{
    public interface ITeacher
    {
       public List<Teacher> GetAll();
       public void AddTeacher(Teacher teacher);

        public Teacher GetTeacherById(int id);

        public List<Teacher> GetTeacherBySub(string sub);
       
        

    }
}
