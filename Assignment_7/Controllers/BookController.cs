using Assignment_7.Models;
using Assignment_7.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepo Obj;
        public BookController()
        {
            Obj = new BookRepo();
        }

        [HttpPost("AddBooks")]
        public IActionResult Add(Book boo)
        {
            Obj.AddBook(boo);
            return StatusCode(200, boo);
        }

        [HttpGet("GetAllBooks")]
        public IActionResult Get() 
        {
            List<Book> books = Obj.GetAllBooks();

            return StatusCode(200, books);
        }

        [HttpDelete("delete book")]
        public IActionResult Delete(int id)
        {
            Obj.DeleteBook(id);
            return StatusCode(200,"deleted");
        }

        [HttpGet("get by lang/{lang}")]
        public IActionResult ByLang(string lang)
        {
            List<Book> langu =  Obj.GetBooksByLang(lang);
            return StatusCode(200, langu);
        }

        [HttpGet("Get book by AUthor")]
        public IActionResult GetAuthor(string name)
        {
            List<Book> Auth = Obj.GetBooksByAuthor(name);
            return StatusCode(200, Auth);
        }

        [HttpGet("Get by Year")]
        public  IActionResult year( int yer)
        {
             List<Book> yearList = Obj.GetBooksByYear(yer);
            return StatusCode(200, yearList);
        }

    }
}
