// Task 3: Polymorphism - NepaliTeacher class inheriting from Teacher class
public class NepaliTeacher : Teacher
{
    public NepaliTeacher(string name) : base(name) { }

    public override void Teaching()
    {
        Console.WriteLine($"{Name} teaches in Nepali");
    }
}