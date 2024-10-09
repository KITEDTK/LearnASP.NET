using System;
using System.Text.Json.Serialization;
using MediatR;

namespace learndotnet.Backend.src.SchoolDB.Application.DTOS.Students;

public class CreateStudentDTO : IRequest
{
    public required string Name {get;set;}
    public required int Age {get;set;}
    [JsonConstructor]
    public CreateStudentDTO(string name, int age){
        Name = name;
        Age = age;
    }
}
