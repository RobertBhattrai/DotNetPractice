//Task 2: Inheritance
public class Motorcycle : Vehicle
{
    public bool HasABS { get; set; } // unique field for example

    // Constructor
    public Motorcycle(string brand, string speed, bool hasABS) : base(brand, speed)
    {
        HasABS = hasABS;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has ABS: {HasABS}");
    }
}