using System.ComponentModel.DataAnnotations;

namespace learndotnet.Dtos;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    string Gerne,
    decimal Price,
    DateOnly ReleaseDate
);
