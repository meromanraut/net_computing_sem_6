using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine(
            "ID: " + Id +
            ", Name: " + Name +
            ", Salary: " + Salary
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees =
            new List<Employee>();

        // Add employees
        employees.Add(
            new Employee(1, "Ram", 30000)
        );

        employees.Add(
            new Employee(2, "Sita", 40000)
        );

        employees.Add(
            new Employee(3, "Hari", 35000)
        );

        Console.WriteLine("Employee List:");

        foreach (Employee emp in employees)
        {
            emp.Display();
        }

        // Add employee
        Console.WriteLine("\nAdd New Employee");

        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Salary: ");
        double salary =
            Convert.ToDouble(Console.ReadLine());

        employees.Add(
            new Employee(id, name, salary)
        );

        Console.WriteLine("Employee added.");

        // Update salary
        Console.Write("\nEnter Employee ID to update: ");

        int updateId =
            Convert.ToInt32(Console.ReadLine());

        foreach (Employee emp in employees)
        {
            if (emp.Id == updateId)
            {
                Console.Write("Enter New Salary: ");

                emp.Salary =
                    Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Salary updated.");
                break;
            }
        }

        // Delete employee
        Console.Write("\nEnter Employee ID to delete: ");

        int deleteId =
            Convert.ToInt32(Console.ReadLine());

        Employee deleteEmployee = null;

        foreach (Employee emp in employees)
        {
            if (emp.Id == deleteId)
            {
                deleteEmployee = emp;
                break;
            }
        }

        if (deleteEmployee != null)
        {
            employees.Remove(deleteEmployee);

            Console.WriteLine(
                "Employee deleted."
            );
        }
        else
        {
            Console.WriteLine(
                "Employee not found."
            );
        }

        // Display final employees
        Console.WriteLine("\nEmployee List:");

        foreach (Employee emp in employees)
        {
            emp.Display();
        }

        Console.WriteLine(
            "\nTotal Employees: " +
            employees.Count
        );
    }
}