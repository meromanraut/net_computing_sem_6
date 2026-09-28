using System;

class DataStorage<T>
{
    private T data;

    public DataStorage(T data)
    {
        this.data = data;
    }

    public void Display()
    {
        Console.WriteLine("Stored Value: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataStorage<int> intData =
            new DataStorage<int>(100);

        DataStorage<string> stringData =
            new DataStorage<string>("Hello C#");

        DataStorage<double> doubleData =
            new DataStorage<double>(25.5);

        Console.WriteLine("Integer Data:");
        intData.Display();

        Console.WriteLine("\nString Data:");
        stringData.Display();

        Console.WriteLine("\nDouble Data:");
        doubleData.Display();
    }
}