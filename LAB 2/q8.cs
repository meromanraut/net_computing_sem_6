using System;
using System.Collections.Generic;

// Generic Class
class DataStorage<T>
{
    private T data;

    public DataStorage(T data)
    {
        this.data = data;
    }

    public void Display()
    {
        Console.WriteLine("Stored Data: " + data);
    }
}

// Student Class
class Student
{
    public int Id;
    public string Name;

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine(
            "ID: " + Id +
            ", Name: " + Name
        );
    }
}

// Teacher Class
class Teacher
{
    public int Id;
    public string Name;

    public Teacher(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine(
            "ID: " + Id +
            ", Name: " + Name
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        // -------------------------
        // Generic Class
        // -------------------------

        DataStorage<string> college =
            new DataStorage<string>(
                "ABC College"
            );

        college.Display();

        // -------------------------
        // List<T> - Students
        // -------------------------

        List<Student> students =
            new List<Student>();

        students.Add(
            new Student(1, "Ram")
        );

        students.Add(
            new Student(2, "Sita")
        );

        students.Add(
            new Student(3, "Hari")
        );

        // -------------------------
        // List<T> - Teachers
        // -------------------------

        List<Teacher> teachers =
            new List<Teacher>();

        teachers.Add(
            new Teacher(101, "Mr. Sharma")
        );

        teachers.Add(
            new Teacher(102, "Ms. Karki")
        );

        // -------------------------
        // Dictionary - Library
        // -------------------------

        Dictionary<int, string> books =
            new Dictionary<int, string>();

        books.Add(1001, "C# Programming");
        books.Add(1002, "Database System");
        books.Add(1003, "Computer Network");

        // -------------------------
        // Queue - Admission
        // -------------------------

        Queue<string> admissionQueue =
            new Queue<string>();

        admissionQueue.Enqueue("Ramesh");
        admissionQueue.Enqueue("Gita");
        admissionQueue.Enqueue("Shyam");

        // -------------------------
        // Stack - Activities
        // -------------------------

        Stack<string> activities =
            new Stack<string>();

        activities.Push("Student Ram Added");
        activities.Push("Teacher Sharma Added");
        activities.Push("Book Added");

        // =========================
        // DISPLAY STUDENTS
        // =========================

        Console.WriteLine(
            "\nStudent List:"
        );

        foreach (Student student in students)
        {
            student.Display();
        }

        // =========================
        // SEARCH STUDENT
        // =========================

        Console.Write(
            "\nEnter Student ID to search: "
        );

        int searchId =
            Convert.ToInt32(Console.ReadLine());

        Student foundStudent = null;

        foreach (Student student in students)
        {
            if (student.Id == searchId)
            {
                foundStudent = student;
                break;
            }
        }

        if (foundStudent != null)
        {
            Console.WriteLine(
                "Student Found:"
            );

            foundStudent.Display();
        }
        else
        {
            Console.WriteLine(
                "Student not found."
            );
        }

        // =========================
        // UPDATE STUDENT
        // =========================

        Console.Write(
            "\nEnter Student ID to update: "
        );

        int updateId =
            Convert.ToInt32(Console.ReadLine());

        foreach (Student student in students)
        {
            if (student.Id == updateId)
            {
                Console.Write(
                    "Enter New Name: "
                );

                student.Name =
                    Console.ReadLine();

                activities.Push(
                    "Student Updated"
                );

                Console.WriteLine(
                    "Student updated."
                );

                break;
            }
        }

        // =========================
        // DELETE STUDENT
        // =========================

        Console.Write(
            "\nEnter Student ID to delete: "
        );

        int deleteId =
            Convert.ToInt32(Console.ReadLine());

        Student deleteStudent = null;

        foreach (Student student in students)
        {
            if (student.Id == deleteId)
            {
                deleteStudent = student;
                break;
            }
        }

        if (deleteStudent != null)
        {
            students.Remove(deleteStudent);

            activities.Push(
                "Student Deleted"
            );

            Console.WriteLine(
                "Student deleted."
            );
        }

        // =========================
        // DISPLAY TEACHERS
        // =========================

        Console.WriteLine(
            "\nTeacher List:"
        );

        foreach (Teacher teacher in teachers)
        {
            teacher.Display();
        }

        // =========================
        // LIBRARY BOOKS
        // =========================

        Console.WriteLine(
            "\nLibrary Books:"
        );

        foreach (
            KeyValuePair<int, string> book
            in books
        )
        {
            Console.WriteLine(
                "Book ID: " + book.Key +
                ", Title: " + book.Value
            );
        }

        // Search Book
        Console.Write(
            "\nEnter Book ID to search: "
        );

        int bookId =
            Convert.ToInt32(Console.ReadLine());

        if (books.ContainsKey(bookId))
        {
            Console.WriteLine(
                "Book Found: " +
                books[bookId]
            );
        }
        else
        {
            Console.WriteLine(
                "Book not found."
            );
        }

        // =========================
        // ADMISSION QUEUE
        // =========================

        Console.WriteLine(
            "\nAdmission Queue:"
        );

        foreach (
            string applicant
            in admissionQueue
        )
        {
            Console.WriteLine(applicant);
        }

        if (admissionQueue.Count > 0)
        {
            Console.WriteLine(
                "\nNext Applicant: " +
                admissionQueue.Peek()
            );

            Console.WriteLine(
                "Processing: " +
                admissionQueue.Dequeue()
            );
        }

        // =========================
        // RECENT ACTIVITIES
        // =========================

        Console.WriteLine(
            "\nRecent Activities:"
        );

        foreach (
            string activity
            in activities
        )
        {
            Console.WriteLine(activity);
        }

        if (activities.Count > 0)
        {
            Console.WriteLine(
                "\nLatest Activity: " +
                activities.Peek()
            );
        }
    }
}