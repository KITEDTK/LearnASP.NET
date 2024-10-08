using System;
using learndotnet.Entities;

namespace learndotnet.Backend.src.Students.Infrastructure.Repositories;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllStudentsAsync();
}
