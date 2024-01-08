using Microsoft.AspNetCore.Mvc;
using Week2_Assesment.Model;
using Week2_Assesment.Repository;


namespace Week2_Assesment.Controllers
{

    public class StudentController : Controller

    {
        StudentRepo obj;
        public StudentController(StudentRepo obj)
        {
            this.obj = obj;
          
        }


        //Student EndPoints
        [HttpPost("Add Student")]
        public IActionResult AddStud(Student studen)
        {
            try
            {
                obj.AddStudent(studen);
                return Ok(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get Student By Id/{id}")]
        public IActionResult GetStById(int id)
        {
            try
            {
                return StatusCode(200, obj.GetStudentById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Get Student By skill/{skill}")]
        public IActionResult GetStdBySki(string skill)
        {
            try
            {
                return StatusCode(200, obj.GetStudentsBySkill(skill));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("Update student Skill/{Sid}/{skill}")]
        public IActionResult UpdateStd(int Sid, String skill)
        {
            try
            {
                obj.UpdateStudent(Sid, skill);
                return Ok(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("Delete Student")]
        public IActionResult DeleteStudent(int DelSid)
        {
            try
            {
                obj.DeleteStudent(DelSid);
                return Ok(obj);
            }
            catch (Exception)
            {

                throw;
            }
        }



        //Company Endpoints

       /* [HttpPost("Add Company")]
        public IActionResult AddCmp(Company company)
        {
            obj2.AddCompany(company);
            return Ok(obj2);
        }
        [HttpGet("Get all Company")]
        public IActionResult GetAllCmp()
        {
            return StatusCode(200, obj2.GetAllCompany());
        }
        [HttpGet("Get Comapny by Id/{id}")]
        public IActionResult GetCmpByid(int id)
        {
            return StatusCode(200, obj2.GetCompanyById(id));
        }
        [HttpGet("Get Comapny by City/{city}")]
        public IActionResult GetCmpByCity(string city)
        {
            return StatusCode(200, obj2.GetAllCompanyByCity(city));
        }

        [HttpDelete("Delete Company")]
        public IActionResult DeleteComany(int Delid)
        {
            obj2.DeleteCompany(Delid);
            return Ok(obj2);
        }*/

    }
}
