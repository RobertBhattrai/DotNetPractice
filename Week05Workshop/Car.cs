//Task 2: Inheritance
public class Car : Vehicle
{
    public int Seats { get; set; } // unique field

    // Constructor
    public Car(string brand, string speed, int seats) : base(brand, speed)
    {
        Seats = seats;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seats: {Seats}");
    }
}