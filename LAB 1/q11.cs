using System;

interface IPrintable
{
    void Print();
}

class Student : IPrintable
{
    public int Id;
    public string Name;

    public void Print()
    {
        Console.WriteLine("Student ID: " + Id);
        Console.WriteLine("Student Name: " + Name);
    }
}

class Employee : IPrintable
{
    public int Id;
    public string Name;

    public void Print()
    {
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Employee Name: " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Id = 1;
        student.Name = "Ram";

        Employee employee = new Employee();

        employee.Id = 101;
        employee.Name = "Hari";

        student.Print();

        Console.WriteLine();

        employee.Print();
    }
}