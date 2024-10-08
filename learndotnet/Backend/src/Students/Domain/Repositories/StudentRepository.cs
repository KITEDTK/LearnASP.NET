using System;
using learndotnet.Backend.src.Students.Infrastructure.Persistence;
using learndotnet.Backend.src.Students.Infrastructure.Repositories;
using learndotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace learndotnet.Backend.src.Students.Domain.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDBContext _context; //Kết nối cơ sở dữ liệu

    public StudentRepository(ApplicationDBContext context){ //hàm constructor khai báo context
        _context = context;
    }
    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }
}
