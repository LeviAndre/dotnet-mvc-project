using BlazorMvc.Frontend;
using BlazorMvc.Frontend.Clients;
using BlazorMvc.Frontend.Models;

public class GamesClient
{   
        private readonly List<GameSummary> games =  
    [
        new(){
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new(){
            Id = 2,
            Name = "Final Fantasy",
            Genre = "Role Playing",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new(){
            Id = 3,
            Name = "Dark Souls III",
            Genre = "Role Playing",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        }
    ];

    private readonly Genre[] genres = new GenresClient().GetGenres();

    public GameSummary[] getGames () => games.ToArray();

    public void AddGame(GameDetails game) {
        ArgumentException.ThrowIfNullOrEmpty(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var gameSummary = new GameSummary{
            Id = games.Count + 1,
            Name = game.Name,
            Genre  = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(gameSummary);
    }
}
