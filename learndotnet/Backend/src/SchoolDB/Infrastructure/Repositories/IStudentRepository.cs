using System;
using learndotnet.Backend.src.SchoolDB.Application.DTOS.Students;
using learndotnet.Entities;

namespace learndotnet.Backend.src.SchoolDB.Infrastructure.Repositories;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task CreateStudentAsync(Student newStudent);
}
