using System;

public class Program{
    static void Main(string[] args){
        //Task 1: Encapsulation
        BankAccount account = new BankAccount(123456, 0.00m);
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Initial Balance: " + account.Balance);

        account.Deposit(500.00m);
        Console.WriteLine("Balance after deposit: " + account.Balance);

        account.Withdraw(200.00m);
        Console.WriteLine("Balance after withdrawal: " + account.Balance);


        //Task 2: Inheritance
        Car myCar = new Car("Toyota", "180 km/h", 5);
        myCar.DisplayInfo();

        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "160 km/h", true);
        myMotorcycle.DisplayInfo();

        //Task 3: Polymorphism
        Printer printer = new Printer();
        printer.Print("Hello, World!");
        printer.Print(12345);
        printer.Print("Repeat this message", 3);
    }
}