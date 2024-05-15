using BlazorMvc.Frontend.Models;

namespace BlazorMvc.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres = [
        new (){
            Id = 1,
            Name = "Role Playing"
        },
        new (){
            Id = 1,
            Name = "Sports"
        },
        new (){
            Id = 1,
            Name = "Kids and Family"
        },
        new (){
            Id = 1,
            Name = "Fighting"
        },
        new (){
            Id = 1,
            Name = "Racing"
        },
    ];

    public Genre[] GetGenres() => genres;
}
