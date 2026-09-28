using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> books =
            new Dictionary<int, string>();

        // Add books
        books.Add(101, "C# Programming");
        books.Add(102, "Java Programming");
        books.Add(103, "Database System");

        Console.WriteLine("Available Books:");

        foreach (KeyValuePair<int, string> book in books)
        {
            Console.WriteLine(
                "Book ID: " + book.Key +
                ", Title: " + book.Value
            );
        }

        // Add new book
        Console.Write("\nEnter New Book ID: ");
        int newId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Book Title: ");
        string newTitle = Console.ReadLine();

        books.Add(newId, newTitle);

        Console.WriteLine("Book added.");

        // Search
        Console.Write("\nEnter Book ID to search: ");

        int searchId =
            Convert.ToInt32(Console.ReadLine());

        if (books.ContainsKey(searchId))
        {
            Console.WriteLine(
                "Book Found: " + books[searchId]
            );
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

        // Update
        Console.Write("\nEnter Book ID to update: ");

        int updateId =
            Convert.ToInt32(Console.ReadLine());

        if (books.ContainsKey(updateId))
        {
            Console.Write("Enter New Title: ");

            books[updateId] =
                Console.ReadLine();

            Console.WriteLine(
                "Book updated."
            );
        }
        else
        {
            Console.WriteLine(
                "Book not found."
            );
        }

        // Remove
        Console.Write("\nEnter Book ID to remove: ");

        int removeId =
            Convert.ToInt32(Console.ReadLine());

        if (books.Remove(removeId))
        {
            Console.WriteLine(
                "Book removed."
            );
        }
        else
        {
            Console.WriteLine(
                "Book not found."
            );
        }

        // Display final books
        Console.WriteLine("\nFinal Book List:");

        foreach (KeyValuePair<int, string> book in books)
        {
            Console.WriteLine(
                "Book ID: " + book.Key +
                ", Title: " + book.Value
            );
        }
    }
}