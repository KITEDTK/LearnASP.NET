using System;
using learndotnet.Backend.src.SchoolDB.Application.DTOS.Students;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Persistence;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Repositories;
using learndotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace learndotnet.Backend.src.SchoolDB.Domain.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDBContext _context; //Kết nối cơ sở dữ liệu

    public StudentRepository(ApplicationDBContext context)
    { //hàm constructor khai báo context
        _context = context;
    }
    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }
    public async Task CreateStudentAsync(Student newStudent)
    {
        await _context.Students.AddAsync(newStudent);
        await _context.SaveChangesAsync();
    }
}
