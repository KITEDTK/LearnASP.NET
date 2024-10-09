using System;
using learndotnet.Entities;
using Microsoft.EntityFrameworkCore;

namespace learndotnet.Backend.src.SchoolDB.Infrastructure.Persistence;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        // Kết nối cơ sở dữ liệu ở đây
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
}
