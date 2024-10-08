using learndotnet.Endpoints;
using learndotnet.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("SchoolDatabase");

builder.Services.AddDbContext<SchoolContext>(options =>{
    options.UseSqlServer(connectionString);
});

app.MapGamesEndpoint();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
app.Run();
