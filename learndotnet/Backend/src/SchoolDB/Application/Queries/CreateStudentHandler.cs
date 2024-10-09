using System;
using learndotnet.Backend.src.SchoolDB.Application.Commands.Students;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Repositories;
using learndotnet.Entities;
using MediatR;

namespace learndotnet.Backend.src.SchoolDB.Application.Queries;

public class CreateStudentHandler : IRequest<CreateStudentCommand>
{
    private readonly IStudentRepository _studentRepository;
    public CreateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task Handle(CreateStudentCommand request, CancellationToken token){
         Student newStudent = new Student
    {
        Id = Guid.NewGuid(), // Giả sử Id là Guid
        name = request.newName,
        age = request.newAge
    };
        await _studentRepository.CreateStudentAsync(newStudent);
    }
}
