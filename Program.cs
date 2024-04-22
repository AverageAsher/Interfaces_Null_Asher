using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Game object
        Game myGame = new Game("Action", "Mature", "The Last of Us");
        Console.WriteLine(myGame.Describe());
        myGame.PlayGame();

        // Creating Movie object
        Movie myMovie = new Movie("Sci-Fi", "PG-13", "Interstellar");
        Console.WriteLine(myMovie.Describe());
        myMovie.PlayMovie();
    }
}