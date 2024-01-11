using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment_10.Model;
using Assignment_10.Repository;

namespace Assignment_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       public readonly ProductRepo obj1;
        public ProductController(ProductRepo obj1)
        {
            this.obj1 = obj1;
        }

        [HttpPost("AddProducts")]
        public IActionResult Add(Product product)
        {
            obj1.AddProduct(product);
            return Ok(obj1);
        }
        [HttpPost("UpdateProduct")]
        public IActionResult Edit(Product product) 
        {
            obj1.UpdateProduct(product);
            return Ok(obj1);
        
        }
    }
}
