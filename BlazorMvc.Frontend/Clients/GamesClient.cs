using BlazorMvc.Frontend.Models;

namespace BlazorMvc.Frontend.Clients;

public class GamesClient
{   
        private readonly GameSummary[] games =  
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

    public GameSummary[] getGames () => games.ToArray();
}
