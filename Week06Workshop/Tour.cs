public class Tour
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
    public void Task6()
    {
        List<Tour> tours = new List<Tour>()
    {
        new Tour { CustomerName="Ram", Destination="Dubai", Price=35000, DurationInDay=5, IsInternational=true },
        new Tour { CustomerName="Sita", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false },
        new Tour { CustomerName="Hari", Destination="Thailand", Price=25000, DurationInDay=6, IsInternational=true },
        new Tour { CustomerName="Gita", Destination="Chitwan", Price=12000, DurationInDay=5, IsInternational=false },
        new Tour { CustomerName="Nabin", Destination="Malaysia", Price=18000, DurationInDay=7, IsInternational=true }
    };

        //FILTER: Price > 10,000 AND Duration > 4
        var filteredTours = tours
            .Where(t => t.Price > 10000 && t.DurationInDay > 4);

        // TRANSFORM: New anonymous type with category
        var transformed = filteredTours.Select(t => new
        {
            t.CustomerName,
            t.Destination,
            Category = t.IsInternational ? "International" : "Domestic",
            t.Price
        });

        // SORT: Domestic first, then International → then by Price
        var sorted = transformed
            .OrderBy(t => t.Category)     // Domestic first
            .ThenBy(t => t.Price);        // Then price ascending

        // DISPLAY CLEAN FORMAT
        Console.WriteLine("=== Travel Report Summary ===");

        foreach (var t in sorted)
        {
            Console.WriteLine(
                $"Customer: {t.CustomerName} | " +
                $"Destination: {t.Destination} | " +
                $"Category: {t.Category} | " +
                $"Price: Rs. {t.Price}"
            );
        }
    }

}
