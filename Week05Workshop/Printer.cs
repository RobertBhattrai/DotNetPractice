// Task 3: Polymorphism

using System;

public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine("Printing message: " + message);
    }

    public void Print(int number)
    {
        Console.WriteLine("Printing number: " + number);
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine( message);
        }
    }
}