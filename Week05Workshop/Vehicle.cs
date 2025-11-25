// Task 2: Inheritance
public class Vehicle
{
    public string Brand;
    public string Speed;

    //Constructor
    public Vehicle()
    {
        Brand = "Generic Brand";
        Speed = "0 km/h";
    }

    //Parameterize Constructor
    public Vehicle(string brand, string speed)
    {
        Brand = brand;
        Speed = speed;
    }

    //method
    public void Start()
    {
        Console.WriteLine("Vehicle Started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle Stopped");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + Brand);
    }
}