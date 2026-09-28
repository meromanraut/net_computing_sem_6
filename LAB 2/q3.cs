using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public string Faculty;

    public Student(int id, string name, string faculty)
    {
        Id = id;
        Name = name;
        Faculty = faculty;
    }

    public void Display()
    {
        Console.WriteLine(
            "ID: " + Id +
            ", Name: " + Name +
            ", Faculty: " + Faculty
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        // Add five students
        students.Add(new Student(1, "Ram", "BSc CSIT"));
        students.Add(new Student(2, "Sita", "BCA"));
        students.Add(new Student(3, "Hari", "BIM"));
        students.Add(new Student(4, "Gita", "BSc CSIT"));
        students.Add(new Student(5, "Shyam", "BCA"));

        // Display
        Console.WriteLine("All Students:");

        foreach (Student student in students)
        {
            student.Display();
        }

        // Add new student
        students.Add(
            new Student(6, "Rita", "BSc CSIT")
        );

        Console.WriteLine("\nStudent Added.");

        // Search student
        Console.Write("\nEnter Student ID to search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        Student found = null;

        foreach (Student student in students)
        {
            if (student.Id == searchId)
            {
                found = student;
                break;
            }
        }

        if (found != null)
        {
            Console.WriteLine("Student Found:");
            found.Display();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        // Remove student
        Console.Write("\nEnter Student ID to remove: ");
        int removeId = Convert.ToInt32(Console.ReadLine());

        Student removeStudent = null;

        foreach (Student student in students)
        {
            if (student.Id == removeId)
            {
                removeStudent = student;
                break;
            }
        }

        if (removeStudent != null)
        {
            students.Remove(removeStudent);
            Console.WriteLine("Student removed.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        // Final records
        Console.WriteLine("\nFinal Student List:");

        foreach (Student student in students)
        {
            student.Display();
        }
    }
}
