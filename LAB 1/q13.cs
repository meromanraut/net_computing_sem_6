using System;

interface IAppointment
{
    void BookAppointment();
    void CancelAppointment();
}

abstract class Hospital
{
    public string Name;
    public int Id;

    // Constructor
    public Hospital(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Abstract method
    public abstract void DisplayDetails();

    // Method Overloading
    public double CalculateBill(double consultationFee)
    {
        return consultationFee;
    }

    public double CalculateBill(
        double consultationFee,
        double medicineCharge
    )
    {
        return consultationFee + medicineCharge;
    }
}

class Doctor : Hospital, IAppointment
{
    public string Department;

    public Doctor(
        int id,
        string name,
        string department
    ) : base(id, name)
    {
        Department = department;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Doctor ID: " + Id);
        Console.WriteLine("Doctor Name: " + Name);
        Console.WriteLine("Department: " + Department);
    }

    public void BookAppointment()
    {
        Console.WriteLine("Appointment booked.");
    }

    public void CancelAppointment()
    {
        Console.WriteLine("Appointment cancelled.");
    }
}

class SpecialistDoctor : Doctor
{
    public string Specialization;

    public SpecialistDoctor(
        int id,
        string name,
        string department,
        string specialization
    ) : base(id, name, department)
    {
        Specialization = specialization;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Specialist Doctor ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Specialization: " + Specialization);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Doctor doctor =
            new Doctor(1, "Dr. Ram", "General");

        doctor.DisplayDetails();
        doctor.BookAppointment();

        Console.WriteLine(
            "Normal Bill: " +
            doctor.CalculateBill(500)
        );

        Console.WriteLine(
            "Bill with Medicine: " +
            doctor.CalculateBill(500, 300)
        );

        Console.WriteLine();

        SpecialistDoctor specialist =
            new SpecialistDoctor(
                2,
                "Dr. Hari",
                "Cardiology",
                "Heart Specialist"
            );

        specialist.DisplayDetails();
        specialist.BookAppointment();
        specialist.CancelAppointment();
    }
}