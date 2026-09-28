using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> actions =
            new Stack<string>();

        // Add actions
        actions.Push("Typed Hello");
        actions.Push("Typed World");
        actions.Push("Changed Font");
        actions.Push("Deleted Text");

        Console.WriteLine("All Actions:");

        foreach (string action in actions)
        {
            Console.WriteLine(action);
        }

        // Current top action
        if (actions.Count > 0)
        {
            Console.WriteLine(
                "\nCurrent Top Action: " +
                actions.Peek()
            );
        }

        // Undo
        if (actions.Count > 0)
        {
            string undoAction =
                actions.Pop();

            Console.WriteLine(
                "\nUndo: " + undoAction
            );
        }

        // New top action
        if (actions.Count > 0)
        {
            Console.WriteLine(
                "Current Top Action: " +
                actions.Peek()
            );
        }

        // Remaining actions
        Console.WriteLine(
            "\nRemaining Actions:"
        );

        foreach (string action in actions)
        {
            Console.WriteLine(action);
        }

        // User enters another action
        Console.Write(
            "\nEnter a new action: "
        );

        string newAction =
            Console.ReadLine();

        actions.Push(newAction);

        Console.WriteLine(
            "Action added."
        );
    }
}