using System;

abstract class Vehicle
{
    public string VehicleNumber;
    public string Brand;

    public abstract void Start();

    public void Display()
    {
        Console.WriteLine("Vehicle Number: " + VehicleNumber);
        Console.WriteLine("Brand: " + Brand);
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();

        car.VehicleNumber = "BA 1 CA 1234";
        car.Brand = "Toyota";

        car.Display();
        car.Start();

        Console.WriteLine();

        Bike bike = new Bike();

        bike.VehicleNumber = "BA 2 PA 5678";
        bike.Brand = "Yamaha";

        bike.Display();
        bike.Start();
    }
}