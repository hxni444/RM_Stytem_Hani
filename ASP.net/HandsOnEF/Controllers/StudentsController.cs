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
        IStudent obj;
        public StudentsController(IStudent obj)
        {
            this.obj = obj;
        }

        [HttpGet("Get_All_Students")]
        public IActionResult GetStudents()
        {

            return Ok(obj.GetALl());
        }

    }
}
