using APIIntegration.DaoLayer;
using APIIntegration.DaoLayer.DbContextLayer;
using APIIntegration.Models;
using APIIntegration.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext<Student>>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddScoped<IService, newService>();
builder.Services.AddScoped<IStudentDao, StudentDao>();
builder.Services.AddScoped<IStudentService, StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
