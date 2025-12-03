public class Student
{
    public string Name { get; set; }
    public void SortStudents()
    {
        List<Student> students = new List<Student>()
    {
        new Student { Name = "Sita" },
        new Student { Name = "Ram" },
        new Student { Name = "Aashish" },
        new Student { Name = "Bikash" },
        new Student { Name = "Gita" }
    };

        // Sort alphabetically
        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("Students sorted alphabetically:");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name);
        }
    }

}
