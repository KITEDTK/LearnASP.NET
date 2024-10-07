using System;
using learndotnet.Dtos;

namespace learndotnet.Entities;

public class Games
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int GerneId { get; set; }
    public Gerne? Gerne { get; set; }
    public decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
    private static readonly List<GameDto> games = [
    new(1, "Dragon ball Z","Fighting",19.99M, new DateOnly(2001,1,1)),
    new(1, "League of legends","Moba",20.88M, new DateOnly(2001,1,2)),
    new(1, "Valorant","Shooter",21.22M, new DateOnly(2001,3,1)),
    ];
    public void createGame(CreateGameDto newGame)
    {
        GameDto game = new(
            games.Count + 1,
            newGame.Name,
            newGame.Gerne,
            newGame.Price,
            newGame.ReleaseDate
        );
        games.Add(game);
    }
}
