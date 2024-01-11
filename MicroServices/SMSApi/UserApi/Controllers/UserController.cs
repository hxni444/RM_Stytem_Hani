using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserApi.Repository;
using UserApi.Models;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepo obj;
        public UserController(UserRepo obj)
        {
            this.obj = obj;
        }
        [HttpPost("AddUser")]
        public  IActionResult Add(User user)
        {
             obj.Register(user);
                return StatusCode(200, "User Added");
            
        }
        [HttpPut("EditUser")]
        public IActionResult Edit(User user)
        {
            obj.Update(user);
            return StatusCode(200, "Edited User");
        }
        [HttpPost("ValidateUser")]
        public IActionResult Validate(validate validate) 
        {
            User user = obj.Validate(validate.userName, validate.password);
            if(user == null)
            {
                return BadRequest("Access Denied");
            }
            else
            
            return StatusCode(200, "Access Granted");

        }

    }
}
