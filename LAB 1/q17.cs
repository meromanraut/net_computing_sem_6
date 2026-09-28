using System;

delegate void DisplayDelegate();

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to C# Programming.");
    }

    static void DisplayDateTime()
    {
        Console.WriteLine(
            "Current Date and Time: " +
            DateTime.Now
        );
    }

    static void Main(string[] args)
    {
        DisplayDelegate display;

        display = DisplayWelcome;

        display += DisplayDateTime;

        display();
    }
}