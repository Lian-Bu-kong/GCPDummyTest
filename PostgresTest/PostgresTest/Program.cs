using Microsoft.EntityFrameworkCore;
using PostgresTest.Core.Helper;
using PostgresTest.Infra;
using PostgresTest.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPhotoInformationService, PhotoInfmationService>();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddVersioning();

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
