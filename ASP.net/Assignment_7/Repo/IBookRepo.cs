using Assignment_7.Models;
using System.Collections.Generic;

namespace Assignment_7.Repo
{
    public interface IBookRepo
    {
        void AddBook(Book books);

        List<Book> GetAllBooks();

        List<Book> GetBooksByAuthor(string Autor);

        List<Book> GetBooksByLang(string lang);

        List<Book> GetBooksByYear(int year);

         string EditBook(Book bok);

     void  DeleteBook(int bookId);

    }
}
