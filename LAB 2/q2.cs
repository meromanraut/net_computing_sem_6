using System;

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        // Integer
        int a = 10;
        int b = 20;

        Console.WriteLine("Before Integer Swap:");
        Console.WriteLine("a = " + a + ", b = " + b);

        Swap(ref a, ref b);

        Console.WriteLine("After Integer Swap:");
        Console.WriteLine("a = " + a + ", b = " + b);

        // String
        string x = "Ram";
        string y = "Sita";

        Console.WriteLine("\nBefore String Swap:");
        Console.WriteLine("x = " + x + ", y = " + y);

        Swap(ref x, ref y);

        Console.WriteLine("After String Swap:");
        Console.WriteLine("x = " + x + ", y = " + y);

        // Double
        double p = 10.5;
        double q = 20.5;

        Console.WriteLine("\nBefore Double Swap:");
        Console.WriteLine("p = " + p + ", q = " + q);

        Swap(ref p, ref q);

        Console.WriteLine("After Double Swap:");
        Console.WriteLine("p = " + p + ", q = " + q);
    }
}