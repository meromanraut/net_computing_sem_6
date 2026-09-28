using System;

class BookCollection
{
    private string[] books =
    {
        "C# Programming",
        "Java Programming",
        "Database System",
        "Computer Network",
        "Web Technology"
    };

    // Indexer
    public string this[int index]
    {
        get
        {
            return books[index];
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Available Books:");

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(
                i + ": " + books[i]
            );
        }
    }

    public int Count
    {
        get
        {
            return books.Length;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookCollection books =
            new BookCollection();

        books.DisplayBooks();

        Console.Write(
            "\nEnter book index: "
        );

        int index =
            Convert.ToInt32(Console.ReadLine());

        if (index >= 0 && index < books.Count)
        {
            Console.WriteLine(
                "Book: " + books[index]
            );
        }
        else
        {
            Console.WriteLine(
                "Invalid book index."
            );
        }
    }
}