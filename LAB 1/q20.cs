using System;

class StudentCollection
{
    private string[] students =
        new string[5];

    // Indexer
    public string this[int index]
    {
        get
        {
            return students[index];
        }

        set
        {
            students[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentCollection students =
            new StudentCollection();

        // Adding students
        students[0] = "Ram";
        students[1] = "Sita";
        students[2] = "Hari";
        students[3] = "Gita";
        students[4] = "Shyam";

        Console.WriteLine("Student Names:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(
                i + ": " + students[i]
            );
        }

        // Updating
        students[0] = "Ramesh";

        Console.WriteLine(
            "\nUpdated Student: " +
            students[0]
        );
    }
}