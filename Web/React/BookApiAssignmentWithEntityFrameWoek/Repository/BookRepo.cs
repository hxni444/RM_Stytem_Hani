using BookApiAssignmentWithEntityFrameWoek.Enity;
using Microsoft.EntityFrameworkCore;

namespace BookApiAssignmentWithEntityFrameWoek.Repository
{
    public class BookRepo : IBookRepo
    {
        MyContext obj;
        public BookRepo(MyContext obj)
        {
            this.obj = obj;
        }
       
        public void AddBook(Book book)
        {
            obj.books.Add(book);
            obj.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            Book book = obj.books.SingleOrDefault(b=>b.BookId == bookId);
            obj.books.Remove(book);
            obj.SaveChanges();  
        }

        public void EditBook(Book Book)
        {
           obj.books.Update(Book);
            obj.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return obj.books.ToList();
        }

        public List<Book> GetBooksByAuthor(string Autor)
        {
           return obj.books.Where(s => s.Author == Autor).ToList();
        }

        public  List<Book> GetBooksByLang(string lang)
        {
            return obj.books.Where(b => b.Lang == lang).ToList();
        }

        public List<Book> GetBooksByYear(DateTime year)
        {
            return obj.books.Where(s => s.ReleaseDate == year).ToList();
        }
    }
}
