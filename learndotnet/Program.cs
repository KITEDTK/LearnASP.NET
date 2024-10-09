using Microsoft.EntityFrameworkCore;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Repositories;
using learndotnet.Backend.src.SchoolDB.Domain.Repositories;
using learndotnet.Backend.src.SchoolDB.Infrastructure.Persistence;
using learndotnet.Backend.src.SchoolDB.Application.Queries;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký Controllers
builder.Services.AddControllers();

// Lấy chuỗi kết nối từ cấu hình (appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("SchoolDatabase");

// Cấu hình DbContext với chuỗi kết nối từ appsettings.json
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
   options.UseSqlServer(connectionString);
});

// Đăng ký MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

// Đăng ký các repository
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
// Khởi tạo ứng dụng
var app = builder.Build();

// Ánh xạ API Controllers
app.MapControllers();

// Nếu cần Razor Pages, có thể thêm dòng dưới đây
// app.MapRazorPages();

app.Run();
