using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class BookStore
    {
        public int  B_id;
        public string B_name;

        Hashtable obj = new Hashtable();
        public Hashtable AddBook(int id,string name)
        {
            
             obj.Add(id,name);
            
            return obj;


        }
    }

    internal class Qstion4
    {
        public static void Main()
        {
            BookStore book = new BookStore();
            Hashtable obj= new Hashtable();
            
            
            Console.WriteLine("Enter Number  of books");
            int x = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter book id");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter book Name");     
                string Name = Console.ReadLine();
                obj =   book.AddBook(Id, Name);
            }
            foreach(var k in obj)
            {
                Console.WriteLine(k);
            }

           
           




        }
       
    }
}
