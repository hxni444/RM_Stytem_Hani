using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffApi.Repository;
using StaffApi.Models;

namespace StaffApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        public readonly StaffRepo obj;
        public StaffController(StaffRepo obj)
        {
            this.obj = obj;
        }
        [HttpGet("Get Staff BY id")]
        public IActionResult GetById(int std) 
        {
            return Ok(obj.GetStaffByStd(std));
        }
        [HttpPost("Add Stff")]
        public IActionResult Add(Staff staff)
        {
            obj.AdStaff(staff);
            return Ok(obj);
        }
    }
}
