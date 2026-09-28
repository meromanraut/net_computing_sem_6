using System;

class Person
{
    public string Name;
    public string Address;
}

class Employee : Person
{
    public int EmployeeId;
    public double Salary;

    public void Input()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Address: ");
        Address = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        EmployeeId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Salary: ");
        Salary = Convert.ToDouble(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine("\nEmployee Information");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Employee ID: " + EmployeeId);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();

        emp.Input();
        emp.Display();
    }
}