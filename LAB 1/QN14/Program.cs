using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Input();

        Console.WriteLine("\nStudent Information");

        student.Display();
    }
}