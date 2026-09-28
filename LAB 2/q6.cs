using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> patients =
            new Queue<string>();

        // Patients arrive
        patients.Enqueue("Ram");
        patients.Enqueue("Sita");
        patients.Enqueue("Hari");
        patients.Enqueue("Gita");

        Console.WriteLine("Current Waiting List:");

        foreach (string patient in patients)
        {
            Console.WriteLine(patient);
        }

        // Next patient
        if (patients.Count > 0)
        {
            Console.WriteLine(
                "\nNext Patient: " +
                patients.Peek()
            );
        }

        // Serve patient
        if (patients.Count > 0)
        {
            string servedPatient =
                patients.Dequeue();

            Console.WriteLine(
                "\nServing Patient: " +
                servedPatient
            );
        }

        // Next patient after serving
        if (patients.Count > 0)
        {
            Console.WriteLine(
                "Next Patient: " +
                patients.Peek()
            );
        }

        // Remaining waiting list
        Console.WriteLine(
            "\nRemaining Waiting List:"
        );

        foreach (string patient in patients)
        {
            Console.WriteLine(patient);
        }
    }
}