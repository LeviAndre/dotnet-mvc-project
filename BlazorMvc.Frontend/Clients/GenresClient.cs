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
            Id = 2,
            Name = "Sports"
        },
        new (){
            Id = 3,
            Name = "Kids and Family"
        },
        new (){
            Id = 4,
            Name = "Fighting"
        },
        new (){
            Id = 5,
            Name = "Racing"
        },
    ];

    public Genre[] GetGenres() => genres;
}
