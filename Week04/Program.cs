public class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Student stu1 = new Student();
        Student stu2 = new Student();

        stu1.StudentName = "John Doe";
        stu1.StudentAddress = "123 Main St";
        stu1.StudentPhoneNum = 123456789;

        stu2.StudentName = "Jane Smith";
        stu2.StudentAddress = "456 Oak St";
        stu2.StudentPhoneNum = 987654321;

        Console.WriteLine("Student 1 Name: " + stu1.StudentName);
        Console.WriteLine("Student 1 Address: " + stu1.StudentAddress);
        Console.WriteLine("Student 1 Phone Number: " + stu1.StudentPhoneNum);

        Console.WriteLine("\n\nStudent 2 Name: " + stu2.StudentName);
        Console.WriteLine("Student 2 Address: " + stu2.StudentAddress);
        Console.WriteLine("Student 2 Phone Number: " + stu2.StudentPhoneNum);

        Console.WriteLine("\nStatic Field of Student Class" + Student.SchoolName);

        //Task 2
        Calculator calc = new Calculator();
        calc.PrintWelcome();
        int sum = calc.Add(5, 10);
        Console.WriteLine("Sum: " + sum);
        int product1 = calc.Multiply(5, 3);
        Console.WriteLine("Product with two parameters: " + product1);
        int product2 = calc.Multiply(5);
        Console.WriteLine("Product with one parameter (using default for second): " + product2);


        //Task 3
        ParameterDemo paramDemo = new ParameterDemo();

        // ref parameter
        int number = 5;
        Console.WriteLine($"Before: {number}");
        paramDemo.Increase(ref number);
        Console.WriteLine($"After: {number}");

        // out parameter
        paramDemo.GetFullName(out string fullName);
        Console.WriteLine($"Full Name: {fullName}");

        // params parameter
        int total = paramDemo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of numbers: {total}");
    }
}