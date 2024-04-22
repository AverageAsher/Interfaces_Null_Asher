public class Movie : IGenre
{
    public string ESRB { get; set; }
    public string Genre { get; set; }
    public string Title { get; set; }

    public Movie(string genre, string esrb, string title)
    {
        Genre = genre;
        ESRB = esrb;
        Title = title;
    }

    public void PlayMovie()
    {
        Console.WriteLine("Movie is Starting, Ssssshhhhh");
    }

    public string Describe()
    {
        return $"Title: {Title}, Genre: {Genre}, ESRB: {ESRB}";
    }
}