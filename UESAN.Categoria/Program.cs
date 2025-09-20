using Microsoft.EntityFrameworkCore;
using UESAN.Categoria.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var _config = builder.Configuration;
var cnx = _config.GetConnectionString("DevConnection");

builder.Services.AddDbContext<LogisticaBdContext>
    (options => options.UseSqlServer(cnx));
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
