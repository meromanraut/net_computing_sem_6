using System;

public partial class Student
{
    public void Input()
    {
        Console.Write("Enter Student ID: ");
        StudentId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Student Name: ");
        StudentName = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("Student Name: " + StudentName);
    }
}