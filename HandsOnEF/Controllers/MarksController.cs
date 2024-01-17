using HandsOnEF.Entity;
using HandsOnEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarksController : ControllerBase
    {
        public MarkRepo obj;
        public MarksController(MarkRepo obj)
        {
            this.obj = obj;
        }

        [HttpPost("Add_marks")]
        public IActionResult AddMArks(Mark mark)
        {
            obj.Add(mark);
            return Ok(mark);

        }

        [HttpDelete("Delete Marks")]
        public IActionResult DeleteMArks(int id)
        {
            obj.Delete(id);
            return Ok(new JsonResult("Mark deleted on id:"+ id));
        }

        [HttpGet("Get_all_Marks")]
        public IActionResult GetAllMarks()
        {
           
            return Ok(obj.GetALl());
        }


        [HttpGet("Get_Mark_By_id")]
        public IActionResult GetMarks(int id)
        {
           
            return Ok(obj.GetById(id));
        }

        [HttpPut("Update_Mark")]
        public IActionResult UpdateMark(Mark mark)
        {
            obj.Update(mark);
            return Ok(mark);
        }
    }
}
