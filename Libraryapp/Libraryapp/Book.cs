using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryapp
{
    class Book
    {
        private String bookName;

        public String BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        private String bookAuthor;

        public String BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        private String bookId;

        public String BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        private String bookType;

        public String BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        private int bookCopy;

        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            Console.WriteLine("Empty");
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name: " + bookName);
            Console.WriteLine("Author: " + bookAuthor);
            Console.WriteLine("ID: " + bookId);
            Console.WriteLine("Type: " + bookType);
            Console.WriteLine("Copy: " + bookCopy);
        }
        public void AddBookCopy(int x)
        {
            bookCopy += x;
        }
    }



}

