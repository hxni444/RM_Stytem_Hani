using HandsOnEF.Entity;
using HandsOnEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        StudentRepo obj;
        public StudentsController(StudentRepo obj)
        {
            this.obj = obj;
        }

        [HttpGet("Get_All_Students")]
        public IActionResult GetStudents()
        {
            List<Student> li = obj.GetALl();
            return Ok(li);
        }
        [HttpPost("Add_Students")]
        public IActionResult PostStudents(Student student)
        {
            obj.Add(student);
            return Ok(student);
        }

        [HttpDelete("Delete_student")]
        public IActionResult DeleteStudents(int id)
        {
            obj.Delete(id);
            return Ok("Student Deleted");
        }

        [HttpGet("Get_Student_By_Id")]
        public IActionResult GetStudent(int id)
        {
            return Ok(obj.GetById(id));
        }
        [HttpPut("Update_student")]
        public IActionResult PutStudent(Student student)
        {
            obj.Update(student);
            return Ok(student);
        }

    }
}
