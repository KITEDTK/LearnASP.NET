namespace learndotnet.Dtos;

public record class GameDto(
    int Id,
    string Name,
    string Gerne,
    decimal Price,
    DateOnly ReleaseDate
    );
