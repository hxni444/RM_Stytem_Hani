using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Repository;
using StudentApi.Model;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       public readonly StudentRepo obj;
        public StudentController(StudentRepo obj)
        {
            this.obj = obj;
        }
        [HttpPost("Add Student")]
        public IActionResult Add(Student student)
        {
            obj.AddStudent(student);
            return Ok(student);
        }
        [HttpGet("Get Student By section And class/{section}/{std}")]
        public IActionResult Get(string section,int std)
        {

            return StatusCode(200, obj.GetAllStudentByClass(section, std));
        }

        [HttpDelete("Delete Student")]
        public IActionResult Delete(int id)
        {
            obj.DeleteStudent(id);
            return Ok("Student deleted");
        }
        [HttpPut("Edit Student")]
        public IActionResult Edit(Student student)
        {
            obj.UpdateStudent(student);
            return Ok(student);
        }
    }
}
