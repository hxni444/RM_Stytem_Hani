using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsONClass
{
    internal class bookMenu
    {
        public int bookId;
        public int price;
        public string bookName;
        public string language;
        public string publisher;
        public string authorName;
          
    }
    class bookRepository
    {
        public bookMenu[] Books = new bookMenu[10];
        public int idx = 0;
        public void AddBook(bookMenu book)
        {
            if (idx < Books.Length)
            {
                Books[idx] = book;
                idx++;
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter book name");
            bookMenu.
        }

    }
}
