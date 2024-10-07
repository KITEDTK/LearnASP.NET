using System;
using learndotnet.Dtos;

namespace learndotnet.Abtractions.Messaging.Repositories;

public interface IGameRepository
{
    Task AddGameAsync(GameDto gameDto);
}
