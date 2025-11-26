//Task 4: Abstraction
public class Bike : VehicleAbstract
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with kick start");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped using kill switch");
    }
}