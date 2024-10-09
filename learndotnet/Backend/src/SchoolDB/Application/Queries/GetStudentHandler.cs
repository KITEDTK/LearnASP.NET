using System;
using learndotnet.Backend.src.SchoolDB.Application.Commands;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Repositories;
using learndotnet.Entities;
using MediatR;

namespace learndotnet.Backend.src.SchoolDB.Application.Queries;

public class GetStudentHandler : IRequestHandler<GetStudentCommand, IEnumerable<Student>>
{
    private readonly IStudentRepository _studentRepository;
    public GetStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<IEnumerable<Student>> Handle(GetStudentCommand request, CancellationToken tokent){
        var students = await _studentRepository.GetAllStudentsAsync();
        return students;
    }
}
