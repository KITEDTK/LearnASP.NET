using System;

namespace learndotnet.Abtractions.Messaging;

public interface ICommandHandler<TCommand, Tresult>
{
    Task<Tresult> Handle(TCommand command, CancellationToken token);
}
