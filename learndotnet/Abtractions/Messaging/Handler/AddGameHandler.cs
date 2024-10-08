using System;
using learndotnet.Abtractions.Messaging.Repositories;
using learndotnet.Dtos;
using MediatR;

namespace learndotnet.Abtractions.Messaging.Handler;

public class AddGameHandler : IRequestHandler<AddGameCommand,int>
{
    private readonly IGameRepository _gameRepository;
    public AddGameHandler(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }
 public async Task<int> Handle(AddGameCommand request, CancellationToken token)
    {
        // Sử dụng constructor thay vì object initializer
        var game = new GameDto(
            Id: 123,  // Bạn có thể truyền Id tùy ý hoặc tự động nếu cần
            Name: request.Name,
            Gerne: request.Gerne,
            Price: request.Price,
            ReleaseDate: request.ReleaseDate
        );

        // Nếu repository có phương thức lưu trò chơi, gọi nó ở đây
        await _gameRepository.AddGameAsync(game);
        return game.Id;
    }
}
