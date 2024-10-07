using System;
using learndotnet.Dtos;
using MediatR;

namespace learndotnet.Queries;

public class getAllDriverQueries : IRequest<IEnumerable<GameDto>>
{

}
