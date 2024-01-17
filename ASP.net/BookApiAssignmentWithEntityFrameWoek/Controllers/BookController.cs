using BookApiAssignmentWithEntityFrameWoek.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookApiAssignmentWithEntityFrameWoek.Enity;
namespace BookApiAssignmentWithEntityFrameWoek.Controllers
{ 

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    public readonly BookRepo OBJ;
    public BookController(BookRepo OBJ)
    {
        this.OBJ = OBJ;
    }
    [HttpPost("Add_books")]
    public IActionResult AddBook(Book book)
    {
        OBJ.AddBook(book);
        return Ok(book);
    }

    [HttpGet("Get_All_Book")]
    public IActionResult GettAll()
    {
        return Ok(OBJ.GetAllBooks());
    }
    [HttpDelete("Delete_Book")]
    public IActionResult Delete(int id)
    {
        OBJ.DeleteBook(id);
        return Ok("Book deleted");
    }

    [HttpGet("GEt_book_by_author")]
    public IActionResult GetByAuthor(string name)
    {
        return Ok(OBJ.GetBooksByAuthor(name));

    }


    [HttpGet("GEt_book_by_languge")]
    public IActionResult GetByLanguge(string name)
    {
        return Ok(OBJ.GetBooksByLang(name));

    }


    [HttpGet("GEt_book_by_date")]
    public IActionResult GetByAuthor(DateTime yr)
    {
        return Ok(OBJ.GetBooksByYear(yr));

    }
    [HttpPut("Edit_bok")]
    public IActionResult Edit(Book book)
    {
        OBJ.EditBook(book);
        return Ok(book);
    }
}
}
