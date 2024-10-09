using System;
using learndotnet.Entities;
using MediatR;

namespace learndotnet.Backend.src.SchoolDB.Application.Commands;

public class GetStudentCommand : IRequest<IEnumerable<Student>>
{
    
}
