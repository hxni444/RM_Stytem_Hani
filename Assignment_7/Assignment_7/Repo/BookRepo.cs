using Assignment_7.Models;

namespace Assignment_7.Repo
{
   
    public class BookRepo : IBookRepo
    {
        static List<Book> BookList = new List<Book>()
       {
           new Book(){Price=500,BookId=123,BookName="Harry",Author="jenny",Lang="eng",ReleaseDate=2000 },
            new Book(){Price=353,BookId=33,BookName="tjhomas the train",Author="parekre",Lang="mal",ReleaseDate=2023 },
             new Book(){Price=111,BookId=893,BookName="potter",Author="lohar",Lang="tel",ReleaseDate=199 }
       };

        public void AddBook(Book books)
        {
            try
            {
                BookList.Add(books);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteBook(int bookId)
        {
            try
            {
                foreach (var k in BookList)
                {
                    if (k.BookId == bookId)
                    {
                        BookList.Remove(k);
                        return;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void EditBook(Book bok)
        {
            try
            {
                foreach (var k in BookList)
                {
                    k.BookId = bok.BookId;
                    k.Author = bok.Author;
                    k.Lang = bok.Lang;
                    k.Price = bok.Price;
                    k.ReleaseDate = bok.ReleaseDate;
                }
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        /* public string EditBook()
         {
             throw new NotImplementedException();
         }*/

        public List<Book> GetAllBooks()
        {
            try
            {
                return BookList;

            }
            catch (Exception)
            {

                throw;
            }        }

        public List<Book> GetBooksByAuthor(string Author)
        {
            try
            {
                List<Book> auBooks = new List<Book>();

                foreach (var k in BookList)
                {
                    if (k.Author == Author)
                    {
                        auBooks.Add(k);
                    }
                }
                return auBooks;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try
            {
                List<Book> langBooks = new List<Book>();

                foreach (var k in BookList)
                {
                    if (k.Lang == lang)
                    {
                        langBooks.Add(k);
                    }
                }
                return langBooks;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            List<Book> langBooks = new List<Book>();

            try
            {
                foreach (var k in BookList)
                {
                    if (k.ReleaseDate == year)
                    {
                        langBooks.Add(k);
                    }
                }
                return langBooks;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
