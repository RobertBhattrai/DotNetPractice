public class Applicant
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Task5_Quantifiers()
    {
        List<Applicant> applicants = new List<Applicant>()
    {
        new Applicant { Name = "Ramesh", Age = 20 },
        new Applicant { Name = "Suresh", Age = 17 },
        new Applicant { Name = "Anita", Age = 19 }
    };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("Any applicant under 18? " + anyUnder18);
        Console.WriteLine("Are all applicants above 16? " + allAbove16);
    }
}
