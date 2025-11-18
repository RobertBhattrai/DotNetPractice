//Task 2: Methods & Return Types
public class Calculator
{
    //Method to print welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    //Method to add two numbers
    public int Add(int a, int b)
    {
        return a + b;
    }

    //Method to Multiply two numbers with optional parament as number 2
    public int Multiply(int a, int b = 1)
    {
        return a * b;
    }


}