using System;

delegate int TotalDelegate(int m1, int m2, int m3);

delegate double PercentageDelegate(int total);

delegate string GradeDelegate(double percentage);

class Program
{
    static int CalculateTotal(
        int m1,
        int m2,
        int m3
    )
    {
        return m1 + m2 + m3;
    }

    static double CalculatePercentage(int total)
    {
        return total / 3.0;
    }

    static string CalculateGrade(double percentage)
    {
        if (percentage >= 80)
            return "A";

        else if (percentage >= 60)
            return "B";

        else if (percentage >= 50)
            return "C";

        else
            return "Fail";
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Mark 1: ");
        int m1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 2: ");
        int m2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Mark 3: ");
        int m3 = Convert.ToInt32(Console.ReadLine());

        TotalDelegate totalDelegate =
            CalculateTotal;

        PercentageDelegate percentageDelegate =
            CalculatePercentage;

        GradeDelegate gradeDelegate =
            CalculateGrade;

        int total =
            totalDelegate(m1, m2, m3);

        double percentage =
            percentageDelegate(total);

        string grade =
            gradeDelegate(percentage);

        Console.WriteLine("\nResult");

        Console.WriteLine(
            "Total Marks: " + total
        );

        Console.WriteLine(
            "Percentage: " + percentage + "%"
        );

        Console.WriteLine(
            "Grade: " + grade
        );
    }
}