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

        [HttpPost("AddOder")]
        public IActionResult Order(Order order)
        {
            obj.OredrProd(order);
            return StatusCode(200, "oder plAced");
        }

        [HttpDelete("delete_order_by_id/{id}")]
        public IActionResult Delete(int id)
        {
            obj.DeltOrder(id);
            return Ok("Order Deleted");
        }

        [HttpGet("Get_all_orders")]
        public IActionResult Get() 
        {
            return StatusCode(200, obj.GetAllOders());
        }

       
    }
}
