
using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string connectionString = "Server=localhost;Database=MyDatabase;User=root;Password=1234;";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(connectionString));

//var connectionStringg = builder.Configuration.GetConnectionString("DefaultConnection")
//                       ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseMySQL(connectionStringg));



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
