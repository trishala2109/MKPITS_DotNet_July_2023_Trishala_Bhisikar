using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macine_Test_3
{
public class Author
{
    public string Name { get; }

    public Author(string name)
    {
        Name = name;
    }
}

public class Book
{
    public string Title { get; }
    public string ISBN { get; }
    public Author Author { get; }

    public Book(string title, string isbn, Author author)
    {
        Title = title;
        ISBN = isbn;
        Author = author;
    }

    public override string ToString()
    {
        return $"Title: {Title}, ISBN: {ISBN}, Author: {Author.Name}";
    }
}

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("List of Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine(book.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create authors
        Author author1 = new Author("John Doe");
        Author author2 = new Author("Jane Smith");

        // Create books
        Book book1 = new Book("Book Title 1", "ISBN001", author1);
        Book book2 = new Book("Book Title 2", "ISBN002", author1);
        Book book3 = new Book("Book Title 1", "ISBN003", author2); // Different ISBN, same title

        // Create library
        Library library = new Library();

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        // Display all books in the library
        library.DisplayBooks();

        // Remove a book from the library
        library.RemoveBook(book2);

        // Display updated list of books in the library
        Console.WriteLine("\nAfter removing a book:");
        library.DisplayBooks();
        Console.ReadLine();
    }
}
}