using HandsOnEF.Repository;
using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEF.Controllers
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
        [HttpPost("Add_Staff")]
        public IActionResult AddStud(Staff staff)
        {
            obj.Add(staff);
            return Ok(staff);
        }
        [HttpGet("Get_all_Staff")]
        public IActionResult GetALLStaff()
        {
        /*    List<Staff> li = */
            return Ok(obj.GetALl());
        }
        [HttpDelete("Delete_Staff")]
        public IActionResult Delete(int id)
        {
            obj.Delete(id);
            return Ok(obj);
        }
    }
}
