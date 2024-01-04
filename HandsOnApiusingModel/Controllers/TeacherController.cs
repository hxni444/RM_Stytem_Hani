using HandsOnApiusingModel.Models;
using HandsOnApiusingModel.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiusingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher iObj;
        public TeacherController()
        {
            iObj = new TeacherRepo();
        }


        [HttpGet("GetallTeacher")]
        public IActionResult GetallTeacher()
        {
            List<Teacher> teacherList = iObj.GetAll();

            return StatusCode(200, teacherList);
        }

        [HttpPost("AddTeacher")]
        public IActionResult AddTchr(Teacher teacher)
        {
            iObj.AddTeacher(teacher);
            return StatusCode(200, teacher);

           
        }
        [HttpPost("GEtTeacherById")]
        public IActionResult GetById(int id)
        {
           Teacher X = iObj.GetTeacherById(id);
            if(X != null)
            {
                return StatusCode(200, X);
            }
            return StatusCode(200, null);
            
        }
        [HttpPost("GetTchrBySub{sub}")]
        public IActionResult GetBySub (string sub) 
        {
            List<Teacher> sublist = new List<Teacher>();
            sublist = iObj.GetTeacherBySub(sub);
            return StatusCode(200, sublist);
        }
        
    }
}
