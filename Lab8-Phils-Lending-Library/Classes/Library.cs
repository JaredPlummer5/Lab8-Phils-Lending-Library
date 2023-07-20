using System;
using System.Collections;
using Lab8_Phils_Lending_Library.Interfaces;

namespace Lab8_Phils_Lending_Library.Classes
{
    public class Library : ILibrary
    {
        private readonly Dictionary<string, Book> _Books;
      

        public Library()
        {
            _Books = new Dictionary<string,Book>();
        }

        public int Count => _Books.Count;

        // Adds a new book to the library
        public void AddBook(string title, string firstName, string lastName, int numberOfPages)
        {
            Book book = new Book(title, firstName, lastName, numberOfPages);
            _Books.Add(title,book);
        }

        // Borrows a book from the library by title
        public Book Borrow(string title)
        {
            // Find the book in the library
            if (_Books.ContainsKey(title))
            {
                Book book = _Books[title];
                _Books.Remove(title); // Remove the book from the library
                return book; // Return the borrowed book
            }
            else
            {
                Console.WriteLine("You can't borrow that book");
                return null; // Return null if book not found
            }
        }
            // Returns a book to the library
            public void Return(Book book)
        {
            _Books.Add(book.Title,book); // Add the returned book to the library
        }

        // Gets the enumerator for iterating over the books in the library
        public IEnumerator<Book> GetEnumerator()
        {
            return _Books.Values.GetEnumerator();
        }

        // Gets the non-generic enumerator for iterating over the books in the library
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
