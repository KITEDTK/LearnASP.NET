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
}
