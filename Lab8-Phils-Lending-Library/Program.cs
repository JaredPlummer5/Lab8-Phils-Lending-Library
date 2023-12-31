﻿using Lab8_Phils_Lending_Library.Classes;
using Lab8_Phils_Lending_Library.Interfaces;

namespace Lab8_Phils_Lending_Library;

class Program
{
    static void Main(string[] args)
    {

        string libraryName = "Phil's Lending Library";
        foreach (char c in libraryName)
        {
            Console.Write(c);
            Thread.Sleep(100); // adjust delay here
        }
        Console.WriteLine();
        Library library = new Library();

        Bag<Book> backPack = new Bag<Book>();

        int play = 0;

        library.AddBook("The Great Gatsby", "F. Scott", "Fitzgerald", 180);

        library.AddBook("Pride and Prejudice", "Jane", "Austen", 432);

        library.AddBook("The Catcher in the Rye", "J.D.", "Salinger", 224);

        do
        {

            Console.WriteLine("Enter 1 to view the library's inventory:");
            Console.WriteLine("Enter 2 to add a book to the library:");
            Console.WriteLine("Enter 3 to borrow a book");
            Console.WriteLine("Enter 4 to return a book");
            Console.WriteLine("Enter 5 to view the books in your backpack");

            string? action = Console.ReadLine();

            Book borrowedBook;

            switch (action)
            {

                case "1":// View the invertory
                    ViewInventory(library);
                    break;
                case "2":// Add a book to the library

                    Console.Write("Enter a title: ");
                    string bookTitle = Console.ReadLine();

                    Console.Write("Enter the author's first name:");
                    string authorFirstName = Console.ReadLine();

                    Console.Write("Enter the author's last name:");
                    string authorLastName = Console.ReadLine();

                    Console.Write("How many pages does it have?");
                    int bookNumOfPages = Convert.ToInt32(Console.ReadLine());


                    AddBooks(library, bookTitle, authorFirstName, authorLastName, bookNumOfPages);
                    break;
                case "3": // Borrow a book and put it your backpack
                    Console.WriteLine("Enter a title");
                    string? title = Console.ReadLine();
                    borrowedBook = BorrowBooks(library, title);
                    backPack.Pack(borrowedBook);
                    break;
                case "4": // Unpack the book and return the book
                    Console.WriteLine("Enter the number the corresponds with the book you want to return");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Book returnedBook = backPack.Unpack(index);
                    AddBooks(library, returnedBook.Title, returnedBook.FirstName, returnedBook.LastName, returnedBook.NumberOfPages);
                    break;
                case "5":
                    ViewBackPack(backPack);
                    break;

            }
        } while (play == 0);
       
   
    }

    public static void ViewInventory(Library library)
    {
        Console.WriteLine("=============== Library's Inventory ==================");

        foreach (Book book in library)
        {
             
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Pages : {book.NumberOfPages}");
            Console.WriteLine($"Count: {book.Count}");
            Console.WriteLine("=================================");

        }

        Console.WriteLine("=============== End of Library's Inventory ==================");

    }

    public static void AddBooks(Library library, string title, string firstName, string lastName, int numberOfPages)
    {

        library.AddBook(title, firstName, lastName, numberOfPages);

    }

    public static void ViewBackPack(Bag<Book> backPack)
    {
        Console.WriteLine("=============== Back Pack Inventory ==================");

        foreach (Book book in backPack)
        {

            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
            Console.WriteLine($"Pages : {book.NumberOfPages}");
            Console.WriteLine($"Count: {book.Count}");
            Console.WriteLine("=================================");

        }

        Console.WriteLine("=============== End of Back Pack Inventory ==================");
    }

    public static Book BorrowBooks(Library library, string title)
    {
        return library.Borrow(title);
    }
}

