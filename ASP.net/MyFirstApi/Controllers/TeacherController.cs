using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")] //route specifues the url pattern of a controller
    [ApiController] //attribute
    public class TeacherController : ControllerBase
    {
        [HttpGet("greet")] //htthp verb
        public string Mssg()
        {
            return "hello world";
        }
        [HttpGet("bell")]
        public string Ding() 
        {
            return "Ding dong";
        }

        [HttpGet]
        public string[] aryy()
        {
             return new string[] { "hello", "boys" };
        }

        [HttpGet("func/{num}")]
        public void func(int num)
        {
            Console.WriteLine($"Wlcome {num}");
        }
    }
}
