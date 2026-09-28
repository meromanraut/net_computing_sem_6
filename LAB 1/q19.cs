using System;

delegate int AddDelegate(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // Anonymous Method
        AddDelegate anonymousAdd =
            delegate(int a, int b)
            {
                return a + b;
            };

        Console.WriteLine(
            "Anonymous Method Result: " +
            anonymousAdd(10, 20)
        );

        // Lambda Expression
        AddDelegate lambdaAdd =
            (a, b) => a + b;

        Console.WriteLine(
            "Lambda Expression Result: " +
            lambdaAdd(10, 20)
        );
    }
}