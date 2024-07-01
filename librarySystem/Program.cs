using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    // Class representing a Book
    public class Book
    {
        // Private fields
        private string title;
        private string author;
        private bool isCheckedOut;

        // Public properties
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }

        public string Author
        {
            get { return author; }
            private set { author = value; }
        }

        public bool IsCheckedOut
        {
            get { return isCheckedOut; }
            private set { isCheckedOut = value; }
        }

        // Constructor
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsCheckedOut = false;
        }

        // Public method to check out the book
        public void CheckOut()
        {
            if (!IsCheckedOut)
            {
                IsCheckedOut = true;
                Console.WriteLine($"{Title} by {Author} has been checked out.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is already checked out.");
            }
        }

        // Public method to return the book
        public void Return()
        {
            if (IsCheckedOut)
            {
                IsCheckedOut = false;
                Console.WriteLine($"{Title} by {Author} has been returned.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} was not checked out.");
            }
        }
    }

    // Class representing a Library Member
    public class Member
    {
        // Public property
        public string Name { get; private set; }

        // Constructor
        public Member(string name)
        {
            Name = name;
        }

        // Public method to borrow a book
        public void BorrowBook(Book book)
        {
            book.CheckOut();
        }

        // Public method to return a book
        public void ReturnBook(Book book)
        {
            book.Return();
        }
    }

    // Class representing the Library
    public class Library
    {
        // Private field to store books
        private List<Book> books;

        // Constructor
        public Library()
        {
            books = new List<Book>();
        }

        // Public method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} by {book.Author} has been added to the library.");
        }

        // Public method to list all books
        public void ListBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (Checked out: {book.IsCheckedOut})");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a library
            Library library = new Library();

            // Create some books
            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");

            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);

            // List books in the library
            library.ListBooks();

            // Create a library member
            Member member = new Member("Psenjen");

            // Member borrows a book
            member.BorrowBook(book1);

            // List books in the library after borrowing
            library.ListBooks();

            // Member returns the book
            member.ReturnBook(book1);

            // List books in the library after returning
            library.ListBooks();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

