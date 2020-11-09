using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryapp
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
        Book[] listofbook;
        int bookcount = 0;

        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Library Name :" + libName);
            Console.WriteLine("Library Address:" + libAddress);
            Console.WriteLine("Total Book:" + totalBook);

        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}