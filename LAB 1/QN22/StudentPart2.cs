public partial class Student
{
    public int CalculateTotal()
    {
        return Mark1 + Mark2 + Mark3;
    }

    public double CalculatePercentage()
    {
        return CalculateTotal() / 3.0;
    }

    public string CalculateGrade()
    {
        double percentage =
            CalculatePercentage();

        if (percentage >= 80)
        {
            return "A";
        }
        else if (percentage >= 60)
        {
            return "B";
        }
        else if (percentage >= 50)
        {
            return "C";
        }
        else
        {
            return "Fail";
        }
    }

    public void Display()
    {
        System.Console.WriteLine(
            "Student ID: " + Id
        );

        System.Console.WriteLine(
            "Student Name: " + Name
        );

        System.Console.WriteLine(
            "Mark 1: " + Mark1
        );

        System.Console.WriteLine(
            "Mark 2: " + Mark2
        );

        System.Console.WriteLine(
            "Mark 3: " + Mark3
        );
    }
}