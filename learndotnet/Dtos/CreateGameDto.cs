using System.ComponentModel.DataAnnotations;

namespace learndotnet.Dtos;

public record class CreateGameDto(
    [Required][StringLength(50)] string Name,
    [Required][StringLength(20)]string Gerne,
    [Range(1,100)]decimal Price,
    DateOnly ReleaseDate
);
