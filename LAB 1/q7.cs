using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow");
    }
}

class Cow : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cow says: Moo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal;

        animal = new Dog();
        animal.MakeSound();

        animal = new Cat();
        animal.MakeSound();

        animal = new Cow();
        animal.MakeSound();
    }
}