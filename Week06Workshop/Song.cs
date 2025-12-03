public class Song
{
    public string Title { get; set; }
    public int Duration { get; set; } // seconds
    public void Task5_Elements()
    {
        List<Song> songs = new List<Song>()
    {
        new Song { Title = "Song A", Duration = 120 },   // 2 mins
        new Song { Title = "Song B", Duration = 250 },   // 4.1 mins
        new Song { Title = "Song C", Duration = 400 }    // 6.6 mins
    };

        Console.WriteLine("First song: " + songs.First().Title);
        Console.WriteLine("Last song: " + songs.Last().Title);

        Console.WriteLine("First song > 4 min: " +
            songs.First(s => s.Duration > 240).Title);

        var longSong = songs.FirstOrDefault(s => s.Duration > 600);

        Console.WriteLine("First song > 10 min: " +
            (longSong?.Title ?? "No song found"));
    }

}
