// Task 4: Abstraction with abstract class
public abstract class VehicleAbstract
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}