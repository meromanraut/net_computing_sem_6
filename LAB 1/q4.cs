using System;

class Person
{
    public string Name;
    public int Age;
}

class Student : Person
{
    public int RollNumber;
    public string Faculty;

    public void DisplayStudent()
    {
        Console.WriteLine("Student Information");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Faculty: " + Faculty);
    }
}

class Teacher : Person
{
    public string Subject;
    public double Salary;

    public void DisplayTeacher()
    {
        Console.WriteLine("Teacher Information");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Subject: " + Subject);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Name = "Ram";
        student.Age = 20;
        student.RollNumber = 10;
        student.Faculty = "BSc CSIT";

        Teacher teacher = new Teacher();

        teacher.Name = "Hari";
        teacher.Age = 35;
        teacher.Subject = "C# Programming";
        teacher.Salary = 50000;

        student.DisplayStudent();

        Console.WriteLine();

        teacher.DisplayTeacher();
    }
}
