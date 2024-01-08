using Microsoft.AspNetCore.Mvc;
using Week2_Assesment.Model;
using Week2_Assesment.Repository;

namespace Week2_Assesment.Controllers
{
    public class CompanyController : Controller
    {
        
        CompanyRepo obj2;
        public CompanyController(CompanyRepo obj2)
        {
           
            this.obj2 = obj2;
        }


        [HttpPost("Add Company")]
        public IActionResult AddCmp(Company company)
        {
            try
            {
                obj2.AddCompany(company);
                return Ok(obj2);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("Get all Company")]
        public IActionResult GetAllCmp()
        {
            try
            {
                return StatusCode(200, obj2.GetAllCompany());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("Get Comapny by Id/{id}")]
        public IActionResult GetCmpByid(int id)
        {
            try
            {
                return StatusCode(200, obj2.GetCompanyById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("Get Comapny by City/{city}")]
        public IActionResult GetCmpByCity(string city)
        {
            try
            {
                return StatusCode(200, obj2.GetAllCompanyByCity(city));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("Delete Company")]
        public IActionResult DeleteComany(int Delid)
        {
            try
            {
                obj2.DeleteCompany(Delid);
                return Ok(obj2);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
