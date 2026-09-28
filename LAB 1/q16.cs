using System;

delegate int SquareDelegate(int number);

class Program
{
    static int CalculateSquare(int number)
    {
        return number * number;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        int number =
            Convert.ToInt32(Console.ReadLine());

        SquareDelegate square =
            CalculateSquare;

        int result = square(number);

        Console.WriteLine(
            "Square = " + result
        );
    }
}