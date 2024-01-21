using ExampleEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleEF.Entity;

namespace ExampleEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        AdminRepo adminRepo;
      public AdminController(AdminRepo adminRepo)
        {
            this.adminRepo = adminRepo;
        }
        [HttpPost("Add_Admininstration")]
        public IActionResult Add(Admin admin)
        { 
            adminRepo.AddAdmin(admin);
            return Ok(admin);
        }
        [HttpGet("Getall_Admininstration")]
        public IActionResult getall()
        {
            return Ok(adminRepo.Gettall());
        }

        [HttpDelete("Delete_Admininstration")]
        public IActionResult delete(int id)
        {
            adminRepo.DeleteAdmin(id);
            return (Ok("administrtion deleted"));
        }

        [HttpPut("Edit_Admininstration")]
        public IActionResult put(Admin admin)
        {
            adminRepo.UpdateAdmin(admin);
            return Ok(admin);
        }
    }
}
