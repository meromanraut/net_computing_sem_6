using System;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book();

        book.BookId = 101;
        book.Title = "C# Programming";
        book.Author = "Mark J. Price";

        book.DisplayBook();

        Console.WriteLine();

        book.IssueBook();
        book.ReturnBook();
    }
}