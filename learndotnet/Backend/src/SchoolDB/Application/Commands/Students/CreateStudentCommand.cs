using System;
using learndotnet.Entities;
using MediatR;
using System.Text.Json.Serialization;

namespace learndotnet.Backend.src.SchoolDB.Application.Commands.Students;

public class CreateStudentCommand : IRequest
{
    [JsonPropertyName("newName")]
    public string newName { get; set; }
     [JsonPropertyName("newAge")]
    public int newAge { get; set; }
    public CreateStudentCommand(string name, int age)
    {
        newName = name;
        newAge = age;
    }
}
