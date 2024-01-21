using ExampleEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleEF.Entity;

namespace ExampleEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        CollegeRepo obj;
        public CollegeController(CollegeRepo obj)
        {
            this.obj = obj;
        }
        [HttpPost("ADD-COllege")]
        public IActionResult Add(College college)
        {
            obj.AddCollege(college);  
            return Ok(college);

        }
        [HttpGet("Get_Colleges")]
        public IActionResult Get()
        {
           
            return Ok(obj.Gettall());
        }


    }
}
