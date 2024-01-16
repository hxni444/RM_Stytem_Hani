using HandOnApiWithEF_CodeFirst.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandOnApiWithEF_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly MyContext obj;
        public StudentController()
        {
            obj = new MyContext();
        }

        [HttpPost("AddStudent")]
        public IActionResult Add(Student student)
        {
            obj.Students.Add(student);
            obj.SaveChanges();
            return Ok(student);
            
        }

        [HttpGet("GetStudent")]
        public IActionResult get(int id)
        {
            Student stdli = obj.Students.SingleOrDefault(s => s.id == id);
            return Ok(stdli);   

        }

        [HttpDelete("Delete Std")]
        public IActionResult delete(int id)
        {
            Student stud = obj.Students.SingleOrDefault(student => student.id == id);
            obj.Students.Remove(stud);
            obj.SaveChanges();
            return Ok(stud);
        }

        [HttpGet("Get all")]
        public IActionResult Getall()
        {
            List<Student> stulist = obj.Students.ToList();
            return Ok(stulist);
        }
    }
}
