using BookApiAssignmentWithEntityFrameWoek.Enity;

namespace BookApiAssignmentWithEntityFrameWoek.Repository
{
    public interface IBookRepo
    {
        public void AddBook(Book book);

        public List<Book> GetAllBooks();

        public List<Book> GetBooksByAuthor(string Autor);

        public List<Book> GetBooksByLang(string lang);

        public List<Book> GetBooksByYear(DateTime year);

        public void EditBook(Book Book);

        public void DeleteBook(int bookId);
    }
}
