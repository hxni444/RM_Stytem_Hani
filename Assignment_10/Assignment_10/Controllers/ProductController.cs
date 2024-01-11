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
        ProductRepo obj;
        public ProductController(ProductRepo obj)
        {
            this.obj = obj;
        }

        [HttpPost("Add Products")]
        public IActionResult Add(Product product)
        {
            obj.AddProduct(product);
            return Ok(obj);
        }
        [HttpPost("Update product")]
        public IActionResult Edit(Product product) 
        {
            obj.UpdateProduct(product);
            return Ok(obj);
        
        }
    }
}
