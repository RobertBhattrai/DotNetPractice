// Task 4: Abstraction
public class CarAbstract : VehicleAbstract
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with key ignition");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped");
    }
}