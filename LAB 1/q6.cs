using System;

class AreaCalculator
{
    // Circle
    public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Rectangle
    public double Area(double length, double width)
    {
        return length * width;
    }

    // Triangle
    public double Area(double baseValue, double height, string shape)
    {
        return 0.5 * baseValue * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        AreaCalculator calc = new AreaCalculator();

        Console.WriteLine(
            "Area of Circle: " + calc.Area(5)
        );

        Console.WriteLine(
            "Area of Rectangle: " + calc.Area(10, 5)
        );

        Console.WriteLine(
            "Area of Triangle: " + calc.Area(10, 5, "Triangle")
        );
    }
}