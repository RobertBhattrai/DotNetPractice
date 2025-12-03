//Task 5: Aggregation Operations on Cashier Sales Data
public class CashierSales
{
    public string CashierName { get; set; }
    public double Sales { get; set; }
    public void Task5_Aggregation()
    {
        List<CashierSales> salesList = new List<CashierSales>()
    {
        new CashierSales { CashierName = "Ram", Sales = 2500 },
        new CashierSales { CashierName = "Sita", Sales = 3200 },
        new CashierSales { CashierName = "Hari", Sales = 1800 },
        new CashierSales { CashierName = "Gita", Sales = 4100 }
    };

        Console.WriteLine("Total Cashiers: " + salesList.Count());
        Console.WriteLine("Total Sales: " + salesList.Sum(s => s.Sales));
        Console.WriteLine("Highest Sale: " + salesList.Max(s => s.Sales));
        Console.WriteLine("Lowest Sale: " + salesList.Min(s => s.Sales));
        Console.WriteLine("Average Sale: " + salesList.Average(s => s.Sales));
    }
}
