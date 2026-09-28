using System;

class Student
{
    int studentId;
    string studentName;
    string faculty;

    // Default Constructor
    public Student()
    {
        studentId = 1;
        studentName = "Roman";
        faculty = "BSc CSIT";
    }

    // Parameterized Constructor
    public Student(int id, string name, string faculty)
    {
        studentId = id;
        studentName = name;
        this.faculty = faculty;
    }

    public void Display()
    {
        Console.WriteLine("Student ID: " + studentId);
        Console.WriteLine("Student Name: " + studentName);
        Console.WriteLine("Faculty: " + faculty);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        Student s2 = new Student(
            2,
            "Sita",
            "BCA"
        );

        Console.WriteLine("Default Constructor:");
        s1.Display();

        Console.WriteLine("\nParameterized Constructor:");
        s2.Display();
    }
}