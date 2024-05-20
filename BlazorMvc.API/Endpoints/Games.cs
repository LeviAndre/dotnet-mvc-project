using BlazorMvc.API.Dtos;

namespace BlazorMvc.API.Endpoints;

public static class Games
{
    const string GetGameEndpointName = "GetGame";

    private static readonly List<GameDto> games = [
        new (
            1,
            "Street Fighter II",
            "Fighting",
            19.99M,
            new DateOnly(1992, 7, 15)
        ),
        new (
            1,
            "Street Fighter II",
            "Fighting",
            19.99M,
            new DateOnly(1992, 7, 15)
        ),
        new (
            1,
            "FIFA 23",
            "Sports",
            19.99M,
            new DateOnly(1992, 7, 15)
        ),
    ]
}
