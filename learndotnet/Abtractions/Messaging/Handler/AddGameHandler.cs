using System;
using learndotnet.Abtractions.Messaging.Repositories;
using MediatR;

namespace learndotnet.Abtractions.Messaging.Handler;

public class AddGameHandler : IRequestHandler<AddGameCommand>
{
    private readonly IGameRepository _gameRepository;
    public AddGameHandler(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }
    public async Task<Unit> Handle(AddGameCommand request, CancellationToken token)
    {
        return Unit.Value;
    }
}
