using System;
using System.Net.Http.Headers;

namespace Libraryapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Deyal", "Humayun Ahmed", "6", "Novel", 43);
            b.ShowInfo();
            b.AddBookCopy(2);
            b.ShowInfo();
            Console.WriteLine();
            Library l1 = new Library("Himu", "DHAKA", 1200);
            l1.ShowLibInfo();
            l1.AddNewBook(b);
            Book c = new Book("Shuvro", "Humayun Ahmed", "4", "Novel", 34);
            l1.AddNewBook(c);

            l1.ShowAllBooks();
            b.AddBookCopy(20);
            b.ShowInfo();

            Console.WriteLine();
            l1.DeleteBook(b);
            l1.ShowAllBooks();
        }
    }
}
       
   
