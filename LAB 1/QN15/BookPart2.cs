using System;

public partial class Book
{
    public void IssueBook()
    {
        Console.WriteLine(Title + " has been issued.");
    }

    public void ReturnBook()
    {
        Console.WriteLine(Title + " has been returned.");
    }

    public void DisplayBook()
    {
        Console.WriteLine("Book ID: " + BookId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}