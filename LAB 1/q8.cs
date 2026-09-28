using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Triangle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape;

        shape = new Circle();
        shape.Draw();

        shape = new Rectangle();
        shape.Draw();

        shape = new Triangle();
        shape.Draw();
    }
}