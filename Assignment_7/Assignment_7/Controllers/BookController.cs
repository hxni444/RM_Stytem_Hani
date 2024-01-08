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
            try
            {

                Obj.AddBook(boo);
                return StatusCode(200, boo);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("GetAllBooks")]
        public IActionResult Get() 
        {
            try
            {
                List<Book> books = Obj.GetAllBooks();

                return StatusCode(200, books);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpDelete("delete book")]
        public IActionResult Delete(int id)
        {
            try
            {
                Obj.DeleteBook(id);
                return StatusCode(200, "deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("get by lang/{lang}")]
        public IActionResult ByLang(string lang)
        {
            try
            {
                List<Book> langu = Obj.GetBooksByLang(lang);
                return StatusCode(200, langu);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("Get book by AUthor")]
        public IActionResult GetAuthor(string name)
        {
            try
            {
                List<Book> Auth = Obj.GetBooksByAuthor(name);
                return StatusCode(200, Auth);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("Get by Year")]
        public  IActionResult year( int yer)
        {
            try
            {
                List<Book> yearList = Obj.GetBooksByYear(yer);
                return StatusCode(200, yearList);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet("UPdate details")]
        public IActionResult update(Book book) 
        {
            try
            {
                Obj.EditBook(book);
                return StatusCode(200, book);

            }
            catch (Exception ex) 
            {

                return StatusCode(501, ex);
            }
        }
    }
}
