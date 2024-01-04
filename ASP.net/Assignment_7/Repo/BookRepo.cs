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
           BookList.Add(books);

        }

        public void DeleteBook(int bookId)
        {
            foreach (var k in BookList)
            {
                if (k.BookId== bookId)
                {
                    BookList.Remove(k);
                    return;
                }

            }
           
           }

       /* public string EditBook()
        {
            throw new NotImplementedException();
        }*/

        public List<Book> GetAllBooks()
        {
          return BookList;
        }

        public List<Book> GetBooksByAuthor(string Author)
        {
            List<Book> auBooks = new List<Book>();

            foreach(var k in BookList)
            {
                if(k.Author == Author)
                {
                   auBooks.Add(k);
                }
            }
            return auBooks;
        }

        public List<Book> GetBooksByLang(string lang)
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

        public List<Book> GetBooksByYear(int year)
        {
            List<Book> langBooks = new List<Book>();

            foreach (var k in BookList)
            {
                if (k.ReleaseDate == year)
                {
                    langBooks.Add(k);
                }
            }
            return langBooks;
        }
    }
}
