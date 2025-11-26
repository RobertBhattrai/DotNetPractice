// Task 3: Polymorphism

using System;
public class Teacher
{
    public string Name;

    //Constructor
    public Teacher(string name)
    {
        Name = name;
    }
    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public sealed void SalaryInfo()
    {

        Console.WriteLine("Teacher's salary information");
        Console.WriteLine("Teacher's salary information");
    }
}