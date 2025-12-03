public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; } 
    public string GetDetails() => $"Title: {Title}, Author: {Author}, Price: {Price}";

    public void Task4()
    {
        List<Book> books = new List<Book>()
    {
        new Book { Title="The Great Gatsby", Author="F. Scott Fitzgerald", Price=500 },
        new Book { Title="Rich Dad Poor Dad", Author="Robert Kiyosaki", Price=1200 },
        new Book { Title="Atomic Habits", Author="James Clear", Price=1500 }
    };

        // LINQ Filtering
        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("Books priced above Rs. 1000:");
        foreach (var b in premiumBooks)
        {
            Console.WriteLine(b.GetDetails());
        }
    }

}
