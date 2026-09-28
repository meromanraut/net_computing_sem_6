using System;

delegate int TotalDelegate();

delegate double PercentageDelegate();

delegate string GradeDelegate();

class Program
{
    static void Main(string[] args)
    {
        StudentCollection students =
            new StudentCollection();

        // Add Student
        Student s1 = new Student();

        s1.Id = 1;
        s1.Name = "Ram";
        s1.Mark1 = 80;
        s1.Mark2 = 70;
        s1.Mark3 = 90;

        students[0] = s1;

        // View Student
        Console.WriteLine(
            "Student Information"
        );

        students[0].Display();

        // Delegates
        TotalDelegate totalDelegate =
            students[0].CalculateTotal;

        PercentageDelegate percentageDelegate =
            students[0].CalculatePercentage;

        GradeDelegate gradeDelegate =
            students[0].CalculateGrade;

        Console.WriteLine(
            "\nResult"
        );

        Console.WriteLine(
            "Total: " +
            totalDelegate()
        );

        Console.WriteLine(
            "Percentage: " +
            percentageDelegate() + "%"
        );

        Console.WriteLine(
            "Grade: " +
            gradeDelegate()
        );

        // Update Student
        students[0].Name = "Ramesh";

        Console.WriteLine(
            "\nAfter Update"
        );

        students[0].Display();
    }
}