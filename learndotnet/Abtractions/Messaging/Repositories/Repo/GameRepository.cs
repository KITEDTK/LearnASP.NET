using System;
using System.Net.Http.Headers;
using learndotnet.Dtos;

namespace learndotnet.Abtractions.Messaging.Repositories.Repo;

public class GameRepository : IGameRepository
{
    private static readonly List<GameDto> games = [
    new(1, "Dragon ball Z","Fighting",19.99M, new DateOnly(2001,1,1)),
    new(1, "League of legends","Moba",20.88M, new DateOnly(2001,1,2)),
    new(1, "Valorant","Shooter",21.22M, new DateOnly(2001,3,1)),
    ];
    public async Task AddGameAsync(GameDto newGame)
    {
        // Thực hiện logic ở đây
        await Task.Run(() =>
        {
            GameDto game = new(
                games.Count + 1,
                newGame.Name,
                newGame.Gerne,
                newGame.Price,
                newGame.ReleaseDate
            );
            games.Add(game);
        });
    }
}
