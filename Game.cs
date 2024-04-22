public class Game : IGenre
{
    public string ESRB { get; set; }
    public string Genre { get; set; }
    public string Title { get; set; }

    public Game(string genre, string esrb, string title)
    {
        Genre = genre;
        ESRB = esrb;
        Title = title;
    }

    public void PlayGame()
    {
        Console.WriteLine("Game is Starting");
    }

    public string Describe()
    {
        return $"Title: {Title}, Genre: {Genre}, ESRB: {ESRB}";
    }
}