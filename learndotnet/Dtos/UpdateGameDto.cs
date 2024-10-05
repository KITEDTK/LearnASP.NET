namespace learndotnet.Dtos;

public record class UpdateGameDto(
    string Name,
    string Gerne,
    decimal Price,
    DateOnly ReleaseDate
);
