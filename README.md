# Phil's Lending Library

Phil's Lending Library is a console application for managing a small library inventory and personal backpack for borrowed books. Users can add, borrow, and return books, as well as view the library's inventory and their backpack's content.


## Features

1. **View Library Inventory**: See all the books available in the library along with their details: title, author, and number of pages.
2. **Add Books to the Library**: Add new books to the library by providing the title, author's first name and last name, and number of pages.
3. **Borrow Books**: Borrow a book from the library by its title. The book will be added to your backpack.
4. **Return Books**: Return a book from your backpack to the library.
5. **View Backpack**: Check what books you have in your backpack.

## Usage

Follow these steps to run the application:

1. Clone the repository to your local machine.
   ```shell
   git clone https://github.com/YourGitHubUsername/Phils_Lending_Library.git
   ```
2. Navigate to the directory containing the project.
   ```shell
   cd Phils_Lending_Library
   ```
3. Run the application.
   ```shell
   dotnet run
   ```
4. Follow the prompts in the console. Enter the corresponding number for the action you want to perform.

   Here's an example of borrowing a book:

   ```
   Enter 3 to borrow a book
   Enter a title: The Great Gatsby
   ```

   The book will then be added to your backpack. You can check this by entering '5' to view the books in your backpack.

## Additional Information

- This application is built using .NET 5.0. Make sure you have the .NET SDK installed to run it.
- The application currently does not support adding multiple books with the same title.

