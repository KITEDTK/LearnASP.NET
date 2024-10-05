using System;
using learndotnet.Dtos;

namespace learndotnet.Endpoints;

public static class GamesEndpoint
{
    const string GetGameEndpointName = "Get game";
    private static readonly List<GameDto> games = [
    new(1, "Dragon ball Z","Fighting",19.99M, new DateOnly(2001,1,1)),
    new(1, "League of legends","Moba",20.88M, new DateOnly(2001,1,2)),
    new(1, "Valorant","Shooter",21.22M, new DateOnly(2001,3,1)),
    ];
    public static WebApplication MapGamesEndpoint(this WebApplication app)
    {
        var group = app.MapGroup("games");
        // GET /games
        group.MapGet("/", () => games);
        // GET /games/1
        group.MapGet("/{id}", (int id) => games.Find(game => game.Id == id)).WithName(GetGameEndpointName);

        // Post /games
        group.MapPost("/", (CreateGameDto newGame) =>
        {
            if(string.IsNullOrEmpty(newGame.Name)){
                return Results.BadRequest("Name is required");
            };
            GameDto game = new(
                games.Count + 1,
                newGame.Name,
                newGame.Gerne,
                newGame.Price,
                newGame.ReleaseDate
            );
            games.Add(game);
            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
        });

        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame) =>
        {
            var index = games.FindIndex(game => game.Id == id);
            games[index] = new GameDto(
                id,
                updatedGame.Name,
                updatedGame.Gerne,
                updatedGame.Price,
                updatedGame.ReleaseDate
            );

            return Results.NoContent();
        });

        group.MapDelete("/{id}", (int id) =>
        {
            games.RemoveAll(game => game.Id == id);
        });
        return app;
    }
}
