using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Two Integers: " + calc.Add(10, 20));

        Console.WriteLine(
            "Two Double Values: " + calc.Add(10.5, 20.5)
        );

        Console.WriteLine(
            "Three Integers: " + calc.Add(10, 20, 30)
        );
    }
}