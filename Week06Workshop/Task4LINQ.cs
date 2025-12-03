public class Task4LINQ
{
    public void Projection()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squared = numbers.Select(n => n * n).ToList();

        squared.ForEach(Console.WriteLine);
    }
}
