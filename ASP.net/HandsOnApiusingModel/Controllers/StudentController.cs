using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnApiusingModel.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsOnApiusingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> stud = new List<Student>()
        {
            new Student{id=123,age=12,name="hani",std="B" },
            new Student{id=456,age=22,name="manu",std="A" },
            new Student{id=789,age=02,name="dan",std="C" },
            new Student{id=963,age=36,name="peter",std="D" },
        };

        [HttpPost("AddStud")]
         public Student AddStud(Student student)
        {
            stud.Add(student);
            return student;
        }
        [HttpGet("GetAll")]
        public List<Student> GetAll()
        {
            return stud;
        }

        [HttpGet("GetById/{id}")]
        public Student GetById(int id)
        {
            foreach (var k in stud)
            {
                if (id == k.id)
                {
                    return k;
                }
            }
            return null;   
        }
        [HttpDelete("Delete/{num}")]
        public List<Student> Delete(int num)
        {
            foreach (var k in stud)
            {
                if (num == k.id)
                {
                    stud.Remove(k);
                    return stud;
                }
            }
            return null;
           
        }
        [HttpGet("Vdelete/{num}")]
        public List<Student> vDelete(int num)
        {
            foreach (var k in stud)
            {
                if (num == k.id)
                {
                    stud.Remove(k);
                    return stud;
                }
            }
            return null;

        }

    }
}
