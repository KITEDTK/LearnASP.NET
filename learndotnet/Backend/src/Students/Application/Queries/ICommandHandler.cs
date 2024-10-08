using System;

namespace learndotnet.Backend.src.Students.Application.Queries;

public class ICommandHandler<TCommand, Tresult>
{
    Task<Tresult> Handle(TCommand command, CancellationToken token);
}
