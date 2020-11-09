using System;
using System.Net.Http.Headers;

namespace Libraryapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Roy", "Humayun ahmed", "6", "tel", 43);
            b.ShowInfo();
            b.AddBookCopy(2);
            b.ShowInfo();
            Console.WriteLine();
            Library 22 = new Library("Ru", "Rangpur", "35");
            22.ShowInfo();
        }
    }
}
