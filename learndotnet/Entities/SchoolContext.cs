using System;
using Microsoft.EntityFrameworkCore;

namespace learndotnet.Entities;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public SchoolContext(DbContextOptions options) : base(options)
    {
        
    }
}
