using Assignment_10.Model;
using Assignment_10.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OderController : ControllerBase
    {
        public readonly OderRepo obj;
        public OderController(OderRepo obj) 
        {
            this.obj = obj;
        }

        [HttpPost("AddOder/{id}")]
        public IActionResult Order(int id, Order order, Product product)
        {
            obj.OredrProd(id, order, product);
            return StatusCode(200,"oder plAced");
        }
       
    }
}
