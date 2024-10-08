using System;
using MediatR;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace learndotnet.Abtractions.Messaging;

public class AddGameCommand : IRequest<int>
{
    public string Name { get; }
    public string Gerne { get; }
    public Decimal Price { get; }
    public DateOnly ReleaseDate;
    public AddGameCommand(string name, string gerne, decimal price, DateOnly datetime)
    {
        Name = name;
        Gerne = gerne;
        Price = price;
        ReleaseDate = datetime;
    }
}
