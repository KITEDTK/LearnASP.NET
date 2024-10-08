using learndotnet.Endpoints;
using learndotnet.Entities;
using Microsoft.EntityFrameworkCore;
using MediatR;
using learndotnet.Abtractions.Messaging.Repositories;
using learndotnet.Abtractions.Messaging.Repositories.Repo;
using learndotnet.Backend.src.Students.Infrastructure.Repositories;
using learndotnet.Backend.src.Students.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký Razor Pages
builder.Services.AddRazorPages();

// Lấy chuỗi kết nối từ cấu hình
var connectionString = builder.Configuration.GetConnectionString("SchoolDatabase");

// Cấu hình DbContext với chuỗi kết nối
builder.Services.AddDbContext<SchoolContext>(options =>
{
   options.UseSqlServer("Server=localhost;Database=SchoolDB;User Id=sa;Password=123;Trusted_Connection=False;MultipleActiveResultSets=true;Encrypt=False;");
});


// Đăng ký MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
builder.Services.AddTransient<IGameRepository, GameRepository>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
// Sau khi cấu hình tất cả các dịch vụ, khởi tạo ứng dụng
var app = builder.Build();

// Ánh xạ các endpoint được định nghĩa trong MapGamesEndpoint
app.MapGamesEndpoint();

// Ánh xạ Razor Pages
app.MapRazorPages();

app.Run();
