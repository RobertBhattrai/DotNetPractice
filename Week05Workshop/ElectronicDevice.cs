// Task 5: Complete OOP System
public abstract class ElectronicDevice
{
    private string brand;
    private double price;

    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // Properties with encapsulation
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public abstract void ShowInfo();
}