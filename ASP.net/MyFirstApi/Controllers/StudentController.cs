using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        string[] stud = new string[] { "manoioj", "raju", "mohan", "lokesh" };
        [HttpGet("Getstud")]
        public string[] Getstud()
        {
            return stud;
        }

        [HttpGet("GetStudById/{ind}")]
        public string GetStudById(int ind)
        {
            return stud[ind];
        }

        [HttpPost("AddStud/{name}")]
        public void AddStud(string name)
        {
            stud[0]=name;
           
        }

    }
}
