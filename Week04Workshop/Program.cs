public class Program
{
    //Task 5: Record
    public record Book(string Title, string Author, double Price);

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

        //Task 4
        // Default constructor
        Player player1 = new Player();
        Console.WriteLine("Player Name:" + player1.playerName);
        Console.WriteLine("Player Level:" + player1.level);
        Console.WriteLine("Player Health:" + player1.health);

        // Parameterized constructor
        Player player2 = new Player("Hero", 10, 150);
        Console.WriteLine("\n\nPlayer Name:" + player2.playerName);
        Console.WriteLine("Player Level:" + player2.level);
        Console.WriteLine("Player Health:" + player2.health);

        // Enum usage
        Console.Write("Enter a day (e.g., Sunday): ");
        string? dayInput = Console.ReadLine();

        DayType dayType;
        if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }
        Console.WriteLine($"It is: {dayType}");

        // Record usage
        Book book1 = new Book("C# Programming", "John Smith", 29.99);
        Book book2 = book1 with { Title = "Advanced C#", Price = 39.99 };

        Console.WriteLine($"First Book: {book1}");

        // Deconstruction
        var (title, author, price) = book2;
        Console.WriteLine($"Deconstructed - Title: {title}, Author: {author}, Price: {price}");

        Console.WriteLine("\nTask 6: Debugging");
        DebuggingExample();

        Console.WriteLine("\nAll Task Completed\nPress any key to exit...");
        Console.ReadKey();

    }

    //New method for Debugging Demo
    static void DebuggingExample()
    {
        Console.Write("Enter marks: ");
        if (int.TryParse(Console.ReadLine(), out int marks))
        {
            Console.Write("Enter total: ");
            if (int.TryParse(Console.ReadLine(), out int total))
            {
                // 1st Breakpoint 
                double percentage = (double)marks / total * 100; // Fixed: added cast to double
                // 2nd Breakpoint 
                Console.WriteLine($"Percentage: {percentage:F2}%");
            }
            else
            {
                Console.WriteLine("Invalid total input");
            }
        }
        else
        {
            Console.WriteLine("Invalid marks input");   
        }
    }
}