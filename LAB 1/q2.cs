using System;

class Rectangle
{
    double length;
    double width;

    // Default Constructor
    public Rectangle()
    {
        length = 5;
        width = 4;
    }

    // Parameterized Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + width);
    }

    public void Display()
    {
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Perimeter: " + CalculatePerimeter());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle();
        Rectangle r2 = new Rectangle(10, 6);

        Console.WriteLine("Default Rectangle:");
        r1.Display();

        Console.WriteLine("\nParameterized Rectangle:");
        r2.Display();
    }
}