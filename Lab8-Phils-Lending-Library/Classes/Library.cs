using System;
using System.Collections;
using Lab8_Phils_Lending_Library.Interfaces;

namespace Lab8_Phils_Lending_Library.Classes
{
    public class Library : ILibrary
    {
        private readonly List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public int Count => Books.Count;

        // Adds a new book to the library
        public void AddBook(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages, Count);
            Books.Add(book);
        }

        // Borrows a book from the library by title
        public Book Borrow(string title)
        {
            // Find the book in the library
            Book book = Books.Find(b => b.Title == title);
            if (book != null)
            {
                Books.Remove(book); // Remove the book from the library
            }
            else
            {
                Console.WriteLine("You can't borrow that book");
            }
            return book; // Return the borrowed book or null if not found
        }

        // Returns a book to the library
        public void Return(Book book)
        {
            Books.Add(book); // Add the returned book to the library
        }

        // Gets the enumerator for iterating over the books in the library
        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        // Gets the non-generic enumerator for iterating over the books in the library
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
