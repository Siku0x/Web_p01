using LibraryApp.Models;
using LibraryApp.Services;

var manager = new LibraryManager();

// Seed data
manager.AddBook(new Book { ISBN = "123", Title = "The C# Guide", Author = "John Doe" });
manager.AddBook(new Book { ISBN = "456", Title = "Mastering .NET", Author = "Jane Smith" });

Console.WriteLine("--- Library System ---");
Console.WriteLine("Search results for 'C#':");

foreach (var book in manager.Search("C#"))
{
    Console.WriteLine(book);
}

if (manager.CheckOut("123"))
{
    Console.WriteLine("\nSuccessfully checked out 'The C# Guide'.");
}

// doker on - offerss
