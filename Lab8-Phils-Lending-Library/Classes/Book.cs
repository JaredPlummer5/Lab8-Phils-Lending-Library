using System;
namespace Lab8_Phils_Lending_Library.Classes
{
	public class Book
	{
		public string Title;
		
		public string FirstName;
		public string LastName;
		public string Author;
		public int NumberOfPages;
		public int Count;

        public Book(string title, string firstName, string lastName, int numberOfPages)
		{
			Title = title;
            FirstName = firstName;
			LastName = lastName;
			Author = firstName + " " + lastName;
            NumberOfPages = numberOfPages;
			

        }
	}
}

