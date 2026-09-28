using System;

abstract class BankAccount
{
    public int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    public abstract double CalculateInterest();

    public void Display()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolderName);
        Console.WriteLine("Balance: " + Balance);
    }
}

class SavingAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return Balance * 0.05;
    }
}

class CurrentAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return Balance * 0.02;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingAccount saving = new SavingAccount();

        saving.AccountNumber = 101;
        saving.AccountHolderName = "Ram";
        saving.Balance = 100000;

        saving.Display();

        Console.WriteLine(
            "Saving Interest: " + saving.CalculateInterest()
        );

        Console.WriteLine();

        CurrentAccount current = new CurrentAccount();

        current.AccountNumber = 102;
        current.AccountHolderName = "Sita";
        current.Balance = 100000;

        current.Display();

        Console.WriteLine(
            "Current Interest: " + current.CalculateInterest()
        );
    }
}